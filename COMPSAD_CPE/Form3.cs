using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMPSAD_CPE
{
    public partial class Form3 : Form
    {
        private String admin_name;
        private String id;
        private String max_terms;
        private String[] drow = new string[40];
        private int index = 0;
        private Form1 form1;
        public Form3(String label, String confirmed)
        {
            if(!confirmed.Equals("NONE") || confirmed.Substring(0,1).Equals("1"))
            {
                setupCBox();
                String[] split = confirmed.Split(' ');
                String split0 = split[0];
                String split1 = split[1];
                addIDtoBox(split0);
                referenceID(split1);
            }
            form1 = new Form1();
            form1.connectDB();
            InitializeComponent();
            admin_name = "Admin " + label;
            admin_lbl.Text = admin_name;
            add_btn.FlatStyle = FlatStyle.Flat;
            add_btn.FlatAppearance.BorderColor = Color.Gray;
            add_btn.FlatAppearance.BorderSize = 1;
            setupCBox();
            cur_view.SelectedIndex = 0;
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            Boolean boo = false;
            String message = "ID Number:";
            String caption = "New Curriculum";
            MessageBoxButtons button = MessageBoxButtons.OK;
            String id_number = Microsoft.VisualBasic.Interaction.InputBox(message, caption, "");
            id_number = id_number.ToUpper();
            id = id_number;
            if (id_number.Equals("") || id_number.Equals(null) || !id_number.Substring(0, 2).ToUpper().Equals("ID"))
            {
                String msg = "Invalid Inputs";
                String cap = "ID Number Error";
                MessageBox.Show(msg, cap, button);
            }
            else
            {
                boo = checkID(id_number);
                if(boo == false)
                {
                    String m = "ID number added";
                    String c = "Successfully added";
                    MessageBoxButtons b = MessageBoxButtons.OK;
                    MessageBox.Show(m, c, b);
                    newid_lbl.Text = id_number;
                    newid_lbl.Visible = true;
                    exist_lbl.Visible = true;
                    y_cbox.Visible = true;
                    n_cbox.Visible = true;
                }
                else
                {
                    String m = "ID number already has a curriculum";
                    String c = "Existing curriculum error";
                    MessageBoxButtons b = MessageBoxButtons.OK;
                    MessageBox.Show(m, c, b);
                }
            }
        }
        private void setupCBox()
        {
            cur_view.BackColor = Color.Aqua;
            cur_view.ForeColor = Color.White;
            cur_view.Items.Add("<Select curriculum>");
            cur_view.Items.Add("ID 115");
            cur_view.Items.Add("ID 116");
            cur_view.Items.Add("ID 117");
            cur_view.Items.Add("ID 118");
            basis_cb.BackColor = Color.Aqua;
            basis_cb.ForeColor = Color.White;
            basis_cb.Items.Add("<Select curriculum>");
            basis_cb.Items.Add("ID 115");
            basis_cb.Items.Add("ID 116");
            basis_cb.Items.Add("ID 117");
            basis_cb.Items.Add("ID 118");
        }
        private void cur_view_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cur_view.SelectedIndex > 0)
            {
                setupGrid();
            }
        }
        private void setupGrid()
        {
            String table_name = "";
            String prev_term = "0";
            String next_term;
            String returned;
            DataTable table = new DataTable();
            if(cur_view.SelectedIndex > 0 && cur_view.SelectedIndex < 4)
            {
                table_name = "115";
            }
            else if(cur_view.SelectedIndex == 4)
            {
                table_name = "118";
            }
            else if(cur_view.SelectedIndex != 0 && cur_view.SelectedIndex > 4)
            {
                String[] split = cur_view.SelectedText.Split(' ');
                table_name = split[1];
            }
            SqlCommand command = new SqlCommand("SELECT * FROM [curriculumTable_" + table_name + "]", form1.connection);
            SqlDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                next_term = reader["term_no"].ToString();
                if(!prev_term.Equals(next_term) && (Int32.Parse(next_term) - Int32.Parse(prev_term) == 1) && Int32.Parse(next_term) <14)
                {
                    prev_term = next_term;
                    table.Columns.Add("Term " + prev_term + " Courses:");
                    table.Columns.Add("Units[" + prev_term + "]:");
                    table.Columns.Add(prev_term);
                    max_terms = prev_term;
                }
            }
            prev_term = "0";
            next_term = "";
            SqlCommand cmd = new SqlCommand("SELECT * FROM [curriculumTable_" + table_name + "]", form1.connection);
            SqlDataReader r = cmd.ExecuteReader();
            while(r.Read())
            {
                next_term = r["term_no"].ToString();
                if (!prev_term.Equals(next_term) && (Int32.Parse(next_term) - Int32.Parse(prev_term) == 1) && Int32.Parse(next_term) < 14)
                {
                    prev_term = next_term;
                    returned = addData(table_name, prev_term, table);
                    returnTable(returned, prev_term, table);
                }
            }
            foreach(String c in drow)
            {
                try
                {
                    int terms = 1;
                    var datarow = table.NewRow();
                    String[] per_term = c.Split('!');
                    foreach (String d in per_term)
                    {
                        if (terms <= Int32.Parse(max_terms))
                        {
                            String[] per_table = d.Split('#');
                            if (per_table.Length == 2)
                            {
                                datarow["Term " + terms + " Courses:"] = per_table[0];
                                datarow["Units[" + terms + "]:"] = per_table[1];
                                datarow[terms] = "";
                                terms++;
                            }
                        }
                    }
                    table.Rows.Add(datarow);
                }
                catch(NullReferenceException e)
                {

                }
            }
            wterm_dgv.DataSource = table;
        }
        private String addData(String n, String p, DataTable t)
        {
            String[] table_array = new string[25];
            String toarr = "";
            SqlCommand command = new SqlCommand("SELECT * FROM [curriculumTable_" + n + "] WHERE term_no = '" + p + "'", form1.connection);
            SqlDataReader r = command.ExecuteReader();
            while (r.Read())
            {
                toarr = toarr + r["course_name"].ToString() + "!" + r["units"].ToString() + "!";
                table_array[index] = toarr;
            }
            index++;
            return table_array[index - 1];
        }
        private void returnTable(String r, String p, DataTable t)
        {
            int ind = 0;
            String data = "";
            String limiter = "!";
            String[] split = r.Split('!');
            var datarow = t.NewRow();
            for (int b = 0; b < split.Length; b = b + 2)
            {
                if (b + 1 != split.Length) data = split[b] + "#" + split[b + 1] + limiter;
                drow[ind] = drow[ind] + data;
                ind++;
                //ind = b + 1;
                //datarow["Term " + ind + " Courses:"] = split[b];
                //if (b + 1 != split.Length) datarow["Units[" + ind + "]:"] = split[b + 1];
                //datarow[ind] = "";
            }
            //t.Rows.Add(datarow);
        }
        private Boolean checkID(String id_1)
        {
            Boolean send = false;
            for(int a = 0; a < cur_view.Items.Count; a++)
            {
                if(id_1.Equals(cur_view.GetItemText(cur_view.Items[a])))
                {
                    send = true;
                    break;
                }
                else
                {
                    send = false;
                }
            }
            return send;
        }
        private void addIDtoBox(String id_cb)
        {
            cur_view.Items.Add("ID "+ id_cb);
            basis_cb.Items.Add("ID "+ id_cb);
        }
        private void ybox_CheckedChanged(object sender, EventArgs e)
        {
            if(y_cbox.Checked == true)
            {
                basis_cb.Visible = true;
                basisid_lbl.Visible = true;
                n_cbox.CheckState = CheckState.Unchecked;
                proceed_btn.Visible = true;
            }
            else if(y_cbox.Checked == false)
            {
                basis_cb.Visible = false;
                basisid_lbl.Visible = false;
                proceed_btn.Visible = false;
            }
        }
        private void nbox_CheckedChanged(object sender, EventArgs e)
        {
            if(n_cbox.Checked == true)
            {
                terms_lbl.Visible = true;
                terms_tb.Visible = true;
                y_cbox.CheckState = CheckState.Unchecked;
                proceed_btn.Visible = true;
            }
            else if(n_cbox.Checked == false)
            {
                terms_lbl.Visible = false;
                terms_tb.Visible = false;
                proceed_btn.Visible = false;
            }
        }
        private void proceed_btn_Click(object sender, EventArgs e)
        {
            if(y_cbox.CheckState == CheckState.Checked)
            {
                OpenForm4();
            }
            if(n_cbox.CheckState == CheckState.Checked)
            {
                OpenForm5();
            }
        }
        private void OpenForm4()
        {
            this.Hide();
            String b = basis_cb.SelectedItem.ToString();
            Form4 form4 = new Form4(id, b);
            form4.Show();
        }
        private void OpenForm5()
        {
            Form5 form5 = new Form5();
            form5.Show();
        }
        private void referenceID(String s)
        {

        }
    }
}

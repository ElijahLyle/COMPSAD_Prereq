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
        private String max_terms;
        private String[] drow = new string[40];
        private int index = 0;
        private Form1 form1;
        public Form3(String label)
        {
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
    }
}

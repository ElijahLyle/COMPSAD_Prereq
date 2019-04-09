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
        private String table_no;
        private String course_name;
        private String prechanged_value;
        private String added_ID;
        private String[] comboID_new = new string[10];
        private String[] comboIDref_new = new string[10];
        private int combo_index = 0;
        private int cell_index;
        private int number = 1;
        private Form1 form1;
        public Form3(String label)
        {
            InitializeComponent();
            form1 = new Form1();
            form1.connectDB();
            admin_lbl.Text = "Admin " + label.ToUpper();
            CBOX();           
            id_cbox.SelectedIndex = 0;
            terms_lbl.Text = "Term " + number.ToString();
            setupBtns();
        }
        private void setupBtns()
        {
            left_btn.FlatStyle = FlatStyle.Flat;
            left_btn.FlatAppearance.BorderColor = Color.Gray;
            left_btn.FlatAppearance.BorderSize = 1;
            right_btn.FlatStyle = FlatStyle.Flat;
            right_btn.FlatAppearance.BorderColor = Color.Gray;
            right_btn.FlatAppearance.BorderSize = 1;
            add_btn.FlatStyle = FlatStyle.Flat;
            add_btn.FlatAppearance.BorderColor = Color.Gray;
            add_btn.FlatAppearance.BorderSize = 0;
        }
        private void Form3_Load(object sender, EventArgs e)
        {

        }
        private void CBOX()
        {
            id_cbox.BackColor = Color.Aqua;
            id_cbox.ForeColor = Color.White;
            id_cbox.Items.Add("<Select curriculum>");
            id_cbox.Items.Add("ID 115");
            id_cbox.Items.Add("ID 116");
            id_cbox.Items.Add("ID 117");
            id_cbox.Items.Add("ID 118");
        }
        private void id_cbox_SekectedINdexChanged(object sender, EventArgs e)
        {
            if(id_cbox.SelectedIndex > 0 && id_cbox.SelectedIndex < 4)
            {
                table_no = "115";
                setupGrids(table_no);
            }
            else if(id_cbox.SelectedIndex == 4)
            {
                table_no = "118";
                setupGrids(table_no);
            }
            else if(id_cbox.SelectedIndex > 4)
            {
                if(yes_cbox.Checked == true)
                {
                    referenceID(id_cbox.SelectedItem.ToString());
                    setupGrids(table_no);
                }
                else
                {
                    String[] split = added_ID.Split(' ');
                    table_no = split[1];
                    setupGrids(table_no);
                }
            }
            editLabel();
        }
        private void editLabel()
        {
            select_lbl.Text = id_cbox.SelectedItem.ToString();
        }
        private void setupGrids(String num)
        {
            String load_type = "";
            String prereq = "";
            int index = 0;
            SqlCommand command = new SqlCommand("SELECT * FROM [curriculumTable_" + num + "] WHERE term_no = '" + number + "';", form1.connection);
            DataTable table = new DataTable();
            table.Columns.Add("Course");
            table.Columns.Add("Units");
            table.Columns.Add("Prerequisites");
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                var datarow = table.NewRow();
                datarow["Course"] = reader["course_name"].ToString();
                datarow["Units"] = reader["units"].ToString();
                String[] split = reader["prereq_courses"].ToString().Split('/');
                String[] split2 = reader["prereq_load"].ToString().Split('/');
                foreach (String c in split2)
                {
                    if (c.Equals("S")) load_type = "Soft";
                    else if (c.Equals("C")) load_type = "Corequisite";
                    else if (c.Equals("H")) load_type = "Hard";
                    prereq = prereq + split[index] + " (" + load_type + "),";
                    index++;
                }
                if (prereq.Equals(" (),"))
                {
                    prereq = "";
                    load_type = "";
                }
                datarow["Prerequisites"] = prereq;
                prereq = "";
                load_type = "";
                table.Rows.Add(datarow);
                index = 0;
            }
            dgv.DataSource = table;
            dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
        private void left_btn_Click(object sender, EventArgs e)
        {
            if (number > 1)
            {
                number--;
            }
            else
            {
                number = 13;
            }
            terms_lbl.Text = "Term " + number.ToString();
            setupGrids(table_no);
        }
        private void right_btn_Click(object sender, EventArgs e)
        {
            if (number < 13)
            {
                number++;
            }
            else
            {
                number = 1;
            }
            terms_lbl.Text = "Term " + number.ToString();
            setupGrids(table_no);
        }
        private void dgv_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgv.Rows[e.RowIndex];
            var changedValue = (String)row.Cells[e.ColumnIndex].Value;
            course_name = (String)row.Cells[0].Value;
            cell_index = e.ColumnIndex;
            UpdateValues(course_name, changedValue);
        }
        private void UpdateValues(String c_name, String c_value)
        {
            String course_concat = "";
            String lcourse_concat = "";
            String loader = "";
            if(cell_index == 0)
            {
                SqlCommand command = new SqlCommand("UPDATE [curriculumTable_" + table_no + "] SET course_name = @course WHERE course_name = '" + prechanged_value + "';", form1.connection);
                command.Parameters.AddWithValue("@course", c_value);
                command.ExecuteNonQuery();
            }
            else if(cell_index == 1)
            {
                SqlCommand command = new SqlCommand("UPDATE [curriculumTable_" + table_no + "] SET units = @units WHERE course_name = '" + c_name + "';", form1.connection);
                command.Parameters.AddWithValue("@units", c_value);
                command.ExecuteNonQuery();
            }
            else if(cell_index == 2)
            {
                String[] split = c_value.Split(',');
                for(int a = 0; a < split.Length - 1; a++)
                {
                    String[] split2 = split[a].Split(' ');
                    course_concat = course_concat + split2[0] + "/";
                    String move = split2[1];
                    String identifier = split2[1].Substring(1, move.Length - 2);
                    if (identifier.Equals("Soft")) loader = "S";
                    else if (identifier.Equals("Corequisite")) loader = "C";
                    else if (identifier.Equals("Hard")) loader = "H";
                    lcourse_concat = lcourse_concat + loader + "/";
                }
                course_concat = course_concat.Substring(0,course_concat.Length - 1);
                lcourse_concat = lcourse_concat.Substring(0, lcourse_concat.Length - 1);
                SqlCommand command = new SqlCommand("UPDATE [curriculumTable_" + table_no + "] SET prereq_courses = @prereq_courses, prereq_load = @prereq_load WHERE course_name = '" + c_name + "';", form1.connection);
                command.Parameters.AddWithValue("@prereq_courses", course_concat);
                command.Parameters.AddWithValue("@prereq_load", lcourse_concat);
                Console.WriteLine(course_concat);
                Console.WriteLine(lcourse_concat);
                command.ExecuteNonQuery();
            }
        }
        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                prechanged_value = dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            }
        }
        private void add_btn_Click(object sender, EventArgs e)
        {
            Boolean HasId = false;
            String caption = "Adding New Curriculum";
            String message = "Write ID number of new curriculum (Format: ID 119)";
            String new_id = Microsoft.VisualBasic.Interaction.InputBox(message, caption, "");
            new_id = new_id.ToUpper();
            for(int a = 0; a < id_cbox.Items.Count - 1; a++)
            {
                id_cbox.SelectedIndex = a;
                if (id_cbox.SelectedItem.ToString().Equals(new_id))
                {
                    HasId = true;
                    break;
                }
            }
            if (new_id.Equals("") || new_id.Equals(null) || HasId == true)
            {
                String msg = "ID Number should not be null or ID number already exists";
                String cap = "ID Number Input Error";
                MessageBoxButtons b = MessageBoxButtons.OK;
                MessageBox.Show(msg, cap, b);
            }
            else
            {
                use_lbl.Visible = true;
                yes_cbox.Visible = true;
                no_cbox.Visible = true;
                added_ID = new_id;
                addIDtoCB(new_id);
            }
        }
        private void ybox_CheckChanged(object sender, EventArgs e)
        {
            Boolean HasCombo = false;
            if (yes_cbox.Checked == true)
            {
                no_cbox.CheckState = CheckState.Unchecked;
                String message = "Input ID number of curriculum to be based on (Format: ID 115): ";
                String caption = "Basis ID";
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                String basis_id = Microsoft.VisualBasic.Interaction.InputBox(message, caption, "");
                basis_id = basis_id.ToUpper();
                for (int a = 0; a < id_cbox.Items.Count - 1; a++)
                {
                    id_cbox.SelectedIndex = a;
                    if (basis_id.Equals(id_cbox.SelectedItem.ToString()))
                    {
                        HasCombo = true;
                        break;
                    }
                }
                if (basis_id.Equals("") || basis_id.Equals(null) || HasCombo == false)
                {
                    String msg = "Invalid Inputs or Basis ID Number Without Curriculum";
                    String cap = "ID Number Input Error";
                    MessageBoxButtons b = MessageBoxButtons.OK;
                    MessageBox.Show(msg, cap, b);
                }
                else
                {
                    //Add ID number with basis ID
                    comboID_new[combo_index] = added_ID;
                    if (basis_id.Equals("ID 116") || basis_id.Equals("ID 117"))
                    {
                        basis_id = "ID 115";
                    }
                    comboIDref_new[combo_index] = basis_id;
                    status_lbl.Visible = true;
                    status_lbl.Text = added_ID + ": From " + basis_id + " curriculum";
                    combo_index++;
                }
            }
        }
        private void nbox_CheckChanged(object sender, EventArgs e)
        {
            if(no_cbox.Checked == true)
            {
                yes_cbox.CheckState = CheckState.Unchecked;
                String message = "Input number of terms for new curriculum (Note: Integer values only)";
                String caption = "Number of Terms";
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                String terms = Microsoft.VisualBasic.Interaction.InputBox(message, caption, "");
                OpenForm5(added_ID, terms);
            }
        }
        private void addIDtoCB(String id)
        {
            id_cbox.Items.Add(id);
        }
        private void referenceID(String selectedID)
        {
            String toTable = null;
            for(int a = 0; a < comboID_new.Length;a++)
            {
                if(selectedID.Equals(comboID_new[a]))
                {
                    String[] split = comboIDref_new[a].Split(' ');
                    toTable = split[1];
                    break;
                }
            }
            table_no = toTable;
        }
        private void OpenForm5(String id, String t)
        {
            Form5 form5 = new Form5(id, t);
            form5.Show();
        }
    }
}

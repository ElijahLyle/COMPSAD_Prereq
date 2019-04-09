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
    public partial class Form5 : Form
    {
        private int max_terms;
        private int term_no = 1;
        private Form1 form1;
        private String course = null;
        private String unit = null;
        private String prereqs = null;
        private String l_prereqs = null;
        private String id_number;
        private Boolean view_active = false;
        public Form5(String id, String terms)
        {
            InitializeComponent();
            form1 = new Form1();
            form1.connectDB();
            id_lbl.Text = "Curriculum for " + id;
            terms_lbl.Text = "Term " + term_no.ToString();
            max_terms = Int32.Parse(terms);
            String[] split = id.Split(' ');
            String number = split[1];
            id_number = number;
            createTable(number);
            InitGrid();
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
            view_btn.FlatStyle = FlatStyle.Flat;
            view_btn.FlatAppearance.BorderColor = Color.Gray;
            view_btn.FlatAppearance.BorderSize = 0;
            done_btn.FlatStyle = FlatStyle.Flat;
            done_btn.FlatAppearance.BorderColor = Color.Gray;
            done_btn.FlatAppearance.BorderSize = 0;
        }
        private void left_btn_Click(object sender, EventArgs e)
        {
            if(term_no > 1)
            {
                term_no--;
            }
            else
            {
                term_no = max_terms;
            }
            terms_lbl.Text = "Term " + term_no.ToString();
            if(view_active == false)
            {
                dgv.Rows.Clear();
            }
            else
            {
                showGrid();
            }
        }
        private void right_btn_Click(object sender, EventArgs e)
        {
            if(term_no < max_terms)
            {
                term_no++;
            }
            else
            {
                term_no = 1;
            }
            terms_lbl.Text = "Term " + term_no.ToString();
            if (view_active == false)
            {
                dgv.Rows.Clear();
            }
            else
            {
                showGrid();
            }
        }
        private void createTable(String n)
        {
            String cr = "CREATE TABLE [dbo].[curriculumTable_" + n + "](" +
                            "[ent_id] [int] IDENTITY(1,1) NOT NULL," +
                            "[term_no] [int] NULL," +
                            "[course_name] [nvarchar](50) NOT NULL," +
                            "[prereq_courses] [nvarchar](100) NULL," +
                            "[units] [varchar](5) NOT NULL," +
                            "[prereq_load] [nvarchar](20) NULL);";
            SqlCommand command = new SqlCommand(cr, form1.connection);
            command.ExecuteNonQuery();
        }
        private void InitGrid()
        {
            dgv.RowCount = 2;
            dgv.ColumnCount = 4;
            dgv.Columns[0].Name = "Course";
            dgv.Columns[1].Name = "Units";
            dgv.Columns[2].Name = "Prerequisites";
            dgv.Columns[3].Name = "Prerequisite Loads";
        }
        private void dgv_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var r = dgv.Rows[e.RowIndex];
            if(e.RowIndex > 0)
            {
                var row = dgv.Rows[e.RowIndex - 1];
                if ((String)row.Cells["Course"].Value != null)
                {
                    course = (String)row.Cells["Course"].Value;
                }
                unit = (String)row.Cells["Units"].Value;
                prereqs = (String)row.Cells["Prerequisites"].Value;
                l_prereqs = (String)row.Cells["Prerequisite Loads"].Value;
                if(!course.Equals(null) && !unit.Equals(null))
                {
                    addToDB(course, unit, prereqs, l_prereqs);
                }
            }
        }
        private void dgv_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

        }
        private void addToDB(String c, String u, String p, String l)
        {
            if (!c.Equals(null) || !c.Equals("") || !u.Equals(null) || !u.Equals(""))
            {
                SqlCommand command = new SqlCommand("INSERT INTO [curriculumTable_" + id_number + "](term_no, course_name, units, prereq_courses, prereq_load) VALUES (@term_no, @course_name, @units, @prereq_courses, @prereq_load)", form1.connection);
                command.Parameters.AddWithValue("@term_no", term_no.ToString());
                command.Parameters.AddWithValue("@course_name", c);
                command.Parameters.AddWithValue("@units", u);
                command.Parameters.AddWithValue("@prereq_courses", p);
                command.Parameters.AddWithValue("@prereq_load", l);
                command.ExecuteNonQuery();
            }
            checkDistinct(c);
        }
        private void done_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void view_btn_Click(object sender, EventArgs e)
        {
            view_active = true;
            dgv.Rows.Clear();
            dgv.Columns.Clear();
            if(term_no != 1)
            {
                term_no = 1;
            }
            terms_lbl.Text = "Term " + term_no.ToString();
            showGrid();
        }
        private void checkDistinct(String cour)
        {
            SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM [curriculumTable_" + id_number + "] WHERE course_name = '" + cour + "';", form1.connection);
            Int32 count = (Int32)command.ExecuteScalar();
            String rec = "";
            String reu = "";
            String repre = "";
            String relpre = "";
            Console.WriteLine(count);
            if(count > 1)
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM [curriculumTable_" + id_number + "] WHERE course_name = '" + cour + "';", form1.connection);
                SqlDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    rec = reader["course_name"].ToString();
                    reu = reader["units"].ToString();
                    repre = reader["prereq_courses"].ToString();
                    relpre = reader["prereq_load"].ToString();
                }
                SqlCommand del_cmd = new SqlCommand("DELETE FROM [curriculumTable_" + id_number + "] WHERE course_name = '" + cour + "';", form1.connection);
                del_cmd.ExecuteNonQuery();
                SqlCommand new_cmd = new SqlCommand("INSERT INTO [curriculumTable_" + id_number + "](term_no, course_name, units, prereq_courses, prereq_load) VALUES (@term_no, @course_name, @units, @prereq_courses, @prereq_load)", form1.connection);
                new_cmd.Parameters.AddWithValue("@term_no", term_no.ToString());
                new_cmd.Parameters.AddWithValue("@course_name", rec);
                new_cmd.Parameters.AddWithValue("@units", reu);
                new_cmd.Parameters.AddWithValue("@prereq_courses", repre);
                new_cmd.Parameters.AddWithValue("@prereq_load", relpre);
                new_cmd.ExecuteNonQuery();
            }
        }
        private void showGrid()
        {
            String load_type = "";
            String prereq = "";
            int index = 0;
            SqlCommand command = new SqlCommand("SELECT * FROM [curriculumTable_" + id_number + "] WHERE term_no = '" + term_no.ToString() + "';", form1.connection);
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
                    if(!split[index].Equals("NULL"))
                    {
                        if (c.Equals("S")) load_type = "Soft";
                        else if (c.Equals("C")) load_type = "Corequisite";
                        else if (c.Equals("H")) load_type = "Hard";
                        else if (c.Equals("NULL")) load_type = "";
                        prereq = prereq + split[index] + " (" + load_type + "),";
                        index++;
                    }
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
    }
}

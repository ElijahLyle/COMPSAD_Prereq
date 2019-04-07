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
    public partial class Form2 : Form
    {
        private String id_no;
        private String table_no;
        private Boolean HasExists = false;
        private int number = 1;
        private Form1 form1 = new Form1();
        public Form2(String label)
        {
            id_no = label;
            table_no = id_no.Substring(0,3);
            if (table_no.Equals("116") || table_no.Equals("117")) table_no = "115";
            InitializeComponent();
            welcome_lbl.Text = "Welcome, " + id_no + "!";
            form1.connectDB();
            no_lbl.Text = number.ToString();
            SetupBtn();
            updateGrid();
            //InitGrid();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            form1 = new Form1();
            form1.Visible = true;
        }
        private void SetupBtn()
        {
            left_btn.FlatStyle = FlatStyle.Flat;
            left_btn.FlatAppearance.BorderColor = Color.Gray;
            left_btn.FlatAppearance.BorderSize = 1;
            right_btn.FlatStyle = FlatStyle.Flat;
            right_btn.FlatAppearance.BorderColor = Color.Gray;
            right_btn.FlatAppearance.BorderSize = 1;
            back_btn.FlatStyle = FlatStyle.Flat;
            back_btn.FlatAppearance.BorderColor = Color.Gray;
            back_btn.FlatAppearance.BorderSize = 0;
        }
        private void InitGrid()
        {
            dgv.ColumnCount = 2;
            dgv.ColumnHeadersVisible = true;
            DataGridViewCellStyle headerstyle = new DataGridViewCellStyle();
            headerstyle.BackColor = Color.Black;
            headerstyle.ForeColor = Color.LightGray;
            headerstyle.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Bold);
            dgv.Columns[0].Name = "Course";
            dgv.Columns[1].Name = "Units";
        }
        private void right_btn_Click(object sender, EventArgs e)
        {
            if(number < 13)
            {
                number++;
            }
            else
            {
                number = 1;
            }
            no_lbl.Text = number.ToString();
            updateGrid();
        }
        private void left_btn_Click(object sender, EventArgs e)
        {
            if(number > 1)
            {
                number--;
            }
            else
            {
                number = 13;
            }
            no_lbl.Text = number.ToString();
            updateGrid();
        }
        private void updateGrid()
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT course_name as 'Course', units as 'Units' FROM [curriculumTable_" + table_no + "] WHERE term_no = '" + number + "';", form1.connection);
            DataTable table = new DataTable();
            dataAdapter.Fill(table);
            dgv.DataSource = table;
            dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
        private void search_txt_TextChanged(object sender, EventArgs e)
        {
            search_txt.ForeColor = Color.Black;
            searchCourse(search_txt.Text.ToUpper());
        }
        private void searchCourse(String course)
        {
            String prereq_c = "";
            String prereq_l = "";
            SqlCommand command = new SqlCommand("SELECT * FROM [curriculumTable_" + table_no + "] WHERE course_name = '" + course + "'", form1.connection);
            SqlCommand command2 = new SqlCommand("SELECT * FROM [auditTable] WHERE course = '" + course + "'", form1.connection);
            SqlDataReader reader2 = command2.ExecuteReader();
            SqlDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                if (course.Equals(reader["course_name"].ToString()))
                {
                    HasExists = true;
                    course_lbl.Text = reader["course_name"].ToString();
                    units_lbl.Text = reader["units"].ToString();
                    prereq_c = reader["prereq_courses"].ToString();
                    prereq_l = reader["prereq_load"].ToString();
                    break;
                }
                else HasExists = false;
            }
            while(reader2.Read())
            {
                if(course.Equals(reader2["course"].ToString()))
                {
                    status_lbl.Text = reader2["HasTaken"].ToString();
                    break;
                }
            }
            if (HasExists == true) setupPR(prereq_c, prereq_l);
            else if (HasExists == false && course.Length > 7)
            {
                MessageBoxButtons button = MessageBoxButtons.OK;
                String message = "Typed course does not exist in your current curriculum";
                String caption = "Course non-existing";
                MessageBox.Show(message, caption, button);
            }
        }
        private void setupPR(String courses, String loads)
        {
            String[] split1 = courses.Split('/');
            String[] split2 = loads.Split('/');
            String status = "";
            String value = "";
            int n = 0;
            DataTable table = new DataTable();
            table.Columns.Add("Course Name:");
            table.Columns.Add("Load");
            table.Columns.Add("Course Status");
            foreach(String c in split1)
            {
                SqlCommand cm = new SqlCommand("SELECT * FROM [auditTable] WHERE course = '" + c + "'", form1.connection);
                SqlDataReader r = cm.ExecuteReader();
                while(r.Read())
                {
                    if(c.Equals(r["course"].ToString()))
                    {
                        status = r["HasTaken"].ToString();
                    }
                }
                var datarow = table.NewRow();
                datarow["Course Name:"] = c;
                if (split2[n].Equals("S")) datarow["Load"] = "Soft";
                else if (split2[n].Equals("C")) datarow["Load"] = "Corequisite";
                else if (split2[n].Equals("H")) datarow["Load"] = "Hard";
                if(status.Equals("1"))
                {
                    value = "Passed";
                }
                else if(status.Equals("0"))
                {
                    value = "Currently Taking";
                }
                else if(status.Equals("2"))
                {
                    value = "Failed";
                }
                datarow["Course Status"] = value;
                table.Rows.Add(datarow);
                n++;
            }
            n = 0;
            dgv2.DataSource = table;
        }
        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewSelectedRowCollection rows = dgv.SelectedRows;
            searchCourse(rows[e.RowIndex].Cells["Course"].Value.ToString());
        }
        private void search_txt_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor.Current = Cursors.IBeam;
        }
        private void search_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if(search_txt.Text.Equals("Enter course here..."))
            {
                search_txt.Text = "";
                search_txt.ForeColor = Color.Black;
            }
        }
        private void search_txt_KeyUp(object sender, KeyEventArgs e)
        {
            if(search_txt.Text.Equals(null) || search_txt.Text.Equals(""))
            {
                search_txt.Text = "Enter course here...";
                search_txt.ForeColor = Color.Gray;
            }
        }
    }
}

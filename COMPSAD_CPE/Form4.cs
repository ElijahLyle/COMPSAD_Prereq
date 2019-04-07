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
    public partial class Form4 : Form
    {
        private int number = 1;
        private Form1 form1;
        private String id_number;
        private String s1;
        private String s2;
        public Form4(String id, String basis)
        {
            form1 = new Form1();
            form1.connectDB();
            InitializeComponent();
            id_lbl.Text = id;
            basis_lbl.Text = basis;
            String[] split = basis.Split(' ');
            String[] split2 = id.Split(' ');
            s1 = split2[1];
            s2 = split[1];
            term_lbl.Text = "Term" + number;
            if (split[1].Equals("116") || split[1].Equals("117")) split[1] = "115";
            id_number = split[1];
            setupBtns();
            UpdateGrid();
        }
        private void setupBtns()
        {
            left_btn.FlatStyle = FlatStyle.Flat;
            left_btn.FlatAppearance.BorderColor = Color.Gray;
            left_btn.FlatAppearance.BorderSize = 1;
            right_btn.FlatStyle = FlatStyle.Flat;
            right_btn.FlatAppearance.BorderColor = Color.Gray;
            right_btn.FlatAppearance.BorderSize = 1;
        }
        private void Form4_Load(object sender, EventArgs e)
        {

        }
        private void leftbtn_Click(object sender, EventArgs e)
        {
            if (number > 1)
            {
                number--;
            }
            else
            {
                number = 13;
            }
            term_lbl.Text = "Term " + number;
            UpdateGrid();
        }
        private void rightbtn_Click(object sender, EventArgs e)
        {
            if (number < 13)
            {
                number++;
            }
            else
            {
                number = 1;
            }
            term_lbl.Text = "Term " + number;
            UpdateGrid();
        }
        private void UpdateGrid()
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT course_name as 'Course', units as 'Units', prereq_courses as 'Prerequisites', prereq_load as 'Prerequisite Loads' FROM [curriculumTable_" + id_number + "] WHERE term_no = '" + number + "';", form1.connection);
            DataTable table = new DataTable();
            dataAdapter.Fill(table);
            cur_dgv.DataSource = table;
            cur_dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void confirm_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3("", s1 + " " + s2);
            form3.Show();
        }
    }
}

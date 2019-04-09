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
        private Form1 form1;
        private String id_number;
        private String id_strip;
        private String chValue;
        private String chValue_Course;
        private String hastaken;
        private int saved_index;
        public Form4(String label)
        {
            InitializeComponent();
            form1 = new Form1();
            form1.connectDB();
            id_number = label;
            id_lbl.Text = "ID Number:" + id_number;
            id_strip = id_number.Substring(0,3);
            UpdateGrid();
            setupBtns();
        }
        private void setupBtns()
        {
            done_btn.FlatStyle = FlatStyle.Flat;
            done_btn.FlatAppearance.BorderColor = Color.Gray;
            done_btn.FlatAppearance.BorderSize = 1;
        }
        private void Form4_Load(object sender, EventArgs e)
        {

        }
        private void UpdateGrid()
        {
            int index = 0;
            String status = "";
            DataTable table = new DataTable();
            table.Columns.Add("Course");
            table.Columns.Add("Status");
            SqlCommand command = new SqlCommand("SELECT * FROM auditTable", form1.connection);
            SqlDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                String course = reader["course"].ToString();
                hastaken = reader["HasTaken"].ToString();
                String[] split = reader["student_ID"].ToString().Split('/');
                String[] split2 = reader["HasTaken"].ToString().Split('/');
                foreach(String c in split)
                {
                    if(c.Equals(id_number))
                    {
                        status = split2[index];
                        saved_index = index;
                    }
                    index++;
                }
                var datarow = table.NewRow();
                datarow["Course"] = course;
                if (status.Equals("0")) datarow["Status"] = "Not Yet Taken";
                else if (status.Equals("1")) datarow["Status"] = "Passed";
                else if (status.Equals("2")) datarow["Status"] = "Currently Taking";
                else if (status.Equals("3")) datarow["Status"] = "Failed";
                table.Rows.Add(datarow);
                index = 0;
            }
            dgv.DataSource = table;
            //0 = Not Yet Taken
            //1 = Passed
            //2 = Currently Taking
            //3 = Failed
        }
        private void dgv_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgv.Rows[e.RowIndex];
            var changedValue = (String)row.Cells[e.ColumnIndex].Value;
            chValue = changedValue;
            chValue_Course = (String)row.Cells[e.ColumnIndex - 1].Value;
            UpdateState(chValue, chValue_Course);
        }
        private void UpdateState(String stat, String cour)
        {
            String toadd = "";
            String concat = "";
            if (stat.Equals("Not Yet Taken")) toadd = "0";
            else if (stat.Equals("Passed")) toadd = "1";
            else if (stat.Equals("Currently Taking")) toadd = "2";
            else if (stat.Equals("Failed")) toadd = "3";
            String[] split = hastaken.Split('/');
            split[saved_index] = toadd;
            for(int a = 0; a < split.Length; a++)
            {
                if (split.Length == 1) concat = concat + split[a];
                else
                    concat = concat + split[a] + "/";
            }
            SqlCommand comm = new SqlCommand("UPDATE [auditTable] SET HasTaken = @HasTaken WHERE course = '" + cour + "'", form1.connection);
            comm.Parameters.AddWithValue("@HasTaken", concat);
            comm.ExecuteNonQuery();
        }
        private void done_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

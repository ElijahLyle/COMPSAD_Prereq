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
    public partial class Form1 : Form
    {
        public SqlConnection connection;
        private Boolean checkUsernameExists;
        private String s1;
        private String s2;
        private String[] split_user;
        public Form1()
        {
            InitializeComponent();
            EditLogin();
            connectDB();
        }

        public void connectDB()
        {
            connection = new SqlConnection();
            connection.ConnectionString = ("Data Source=LYLE-PC;Initial Catalog=compsad_db;Integrated Security=True;MultipleActiveResultSets=true");
            connection.Open();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void log_btn_Click(object sender, EventArgs e)
        {
            checkUsernameExists = false;
            String message;
            String caption;
            MessageBoxButtons button = MessageBoxButtons.OK;
            if (user_txt.Text.Equals("") || pword_txt.Text.Equals(""))
            {
                message = "Incomplete input of either username or password.";
                caption = "Login Error";
                MessageBox.Show(message, caption, button);
            }
            else
            {
                UserCheck();
                if(checkUsernameExists == false)
                {
                    message = "Incorrect credentials, please enter correct username and password.";
                    caption = "Login Error";
                    MessageBox.Show(message, caption, button);
                }
                else if(checkUsernameExists == true && s1.Equals("student"))
                {
                    OpenForm2();
                }
                else if(checkUsernameExists == true && s1.Equals("admin"))
                {
                    OpenForm3();
                }
            }
        }
        private void UserCheck()
        {
            String text = user_txt.Text;
            split_user = text.Split('.');
            Console.WriteLine(split_user.Length);
            s1 = split_user[0];
            s2 = split_user[1];
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            SqlCommand command = new SqlCommand("SELECT * FROM [user_table]", connection);
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                if (dataReader[0].ToString().Equals(s1) && dataReader[1].ToString().Equals(s2) && dataReader[2].ToString().Equals(pword_txt.Text))
                {
                    checkUsernameExists = true;
                    dataReader.Close();
                    break;
                }
                else
                {
                    checkUsernameExists = false;
                }
            }
        }
        private void OpenForm2()
        {
            this.Hide();
            Form2 form2 = new Form2(s2);
            form2.Show();
        }
        private void EditLogin()
        {
            log_btn.FlatStyle = FlatStyle.Flat;
            log_btn.FlatAppearance.BorderColor = Color.Gray;
            log_btn.FlatAppearance.BorderSize = 1;
            pword_txt.PasswordChar = '*';
            pword_txt.MaxLength = 30;
        }
        private void OpenForm3()
        {
            this.Hide();
            Form3 form3 = new Form3(s2);
            form3.Show();
        }
    }
}

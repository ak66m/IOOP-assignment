using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace IOOP_ASSIGNMENT_FORMS_REG_MENU
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            logedregester f1 = new logedregester();
            f1.Show();
        }

        private void loginForm_Load(object sender, EventArgs e)
        {

        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            try
            {
               
                if (!(textBox1.Text == string.Empty))
                {
                    if (!(textBox2.Text == string.Empty))
                    {
                        SqlConnection con = new SqlConnection("Data Source=LAPTOP-SQA3VM06;Initial Catalog=IOOP assignment; Integrated Security=true;");
                        con.Open();
                        string sqlQuery = "Select * from REGESTERATION_T where app_username=@Username AND app_password=@Password";
                        SqlCommand cmd = new SqlCommand(sqlQuery, con);
                        cmd.Parameters.AddWithValue("@Username", textBox1.Text);
                        cmd.Parameters.AddWithValue("@Password", textBox2.Text);
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read() == true)
                        {
                            this.Hide();
                            MenuForm f2 = new MenuForm();
                            f2.ShowDialog();
                        }
                        else
                        {
                            ErrorMessage.Text = "Invalid Username or Password!";
                        }
                        con.Close();

                        
                    }
                    else
                    {
                        ErrorMessage.Text = "Username or Password is Empty! Try again";
                    }

                }
                else
                {
                    ErrorMessage.Text = "Username or Password is Empty! Try again";
                }
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }
    }
}

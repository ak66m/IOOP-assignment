using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP_ASSIGNMENT_FORMS_REG_MENU
{
    public partial class logedregester : Form
    {
        public logedregester()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuForm f2 = new MenuForm();
            f2.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void submitBTN_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedIndex >= 0)
                {
                    if (!(textBox1.Text == String.Empty))
                    {
                        if (!(textBox2.Text == String.Empty))
                        {
                            if (!(textBox3.Text == String.Empty))
                            {
                                if (!(textBox4.Text == String.Empty))
                                {
                                    if (!(textBox5.Text == String.Empty))
                                    {
                                        if (!(textBox6.Text == String.Empty))
                                        {
                                            SqlConnection con = new SqlConnection("Data Source=LAPTOP-SQA3VM06;Initial Catalog=IOOP assignment; Integrated Security=true;");
                                            SqlCommand Selectcmd = new SqlCommand("Select count(*) from REGESTERATION_T where app_id = '" + textBox1.Text + "'; ", con);
                                            con.Open();
                                            int UserID = Convert.ToInt32(Selectcmd.ExecuteScalar().ToString());
                                            con.Close();

                                            if (UserID == 0)
                                            {
                                                SqlCommand SelectUsernamecmd = new SqlCommand("Select count(*) from REGESTERATION_T where app_username = '" + textBox2.Text + "'; ", con);
                                                con.Open();
                                                int Username = Convert.ToInt32(SelectUsernamecmd.ExecuteScalar().ToString());
                                                con.Close();
                                                if (Username == 0)
                                                {
                                                    string qurey = "INSERT INTO REGESTERATION_T VALUES (@ID,@First_Name,@Last_Name,@Address,@Username,@Password,@Gender)";
                                                    SqlCommand Insertcmd = new SqlCommand(qurey, con);
                                                    Insertcmd.Parameters.AddWithValue("@ID", textBox1.Text);
                                                    Insertcmd.Parameters.AddWithValue("@First_Name", textBox6.Text);
                                                    Insertcmd.Parameters.AddWithValue("@Last_Name", textBox4.Text);
                                                    Insertcmd.Parameters.AddWithValue("@Address", textBox5.Text);
                                                    Insertcmd.Parameters.AddWithValue("@Username", textBox2.Text);
                                                    Insertcmd.Parameters.AddWithValue("@Password", textBox3.Text);
                                                    Insertcmd.Parameters.AddWithValue("@Gender", comboBox1.SelectedItem.ToString());
                                                    con.Open();
                                                    Insertcmd.ExecuteNonQuery();
                                                    con.Close();

                                                    this.Hide();
                                                    MenuForm f2 = new MenuForm();
                                                    f2.ShowDialog();
                                                }
                                                else
                                                {
                                                    ErorrMessage.Text = "Username is already taken!";
                                                }

                                            }
                                            else
                                            {
                                                ErorrMessage.Text = "ID is already taken!";
                                            }





                                        }
                                        else
                                        {
                                            ErorrMessage.Text = "Please fill in your information";
                                        }
                                    }
                                    else
                                    {
                                        ErorrMessage.Text = "Please fill in your information";
                                    }
                                }
                                else
                                {
                                    ErorrMessage.Text = "Please fill in your information";
                                }
                            }
                            else
                            {
                                ErorrMessage.Text = "Please fill in your information";
                            }
                        }
                        else
                        {
                            ErorrMessage.Text = "Please fill in your information";
                        }
                    }
                    else
                    {
                        ErorrMessage.Text = "Please fill in your information";
                    }
                }
                else
                {
                    ErorrMessage.Text = "Please fill in your information";
                }
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

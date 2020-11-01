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

namespace IOOP_ASSIGNMENT_FORMS_REG_MENU
{
    public partial class payfrm : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        public payfrm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "Data Source=LAPTOP-SQA3VM06;Initial Catalog=IOOP assignment; Integrated Security=true;";
            con.Open();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {;
                com.CommandText = "select * from REGESTERATION_T where app_id = '" + textBox1.Text + "' ";
                com.Connection = con;
                com.ExecuteNonQuery();
                SqlDataReader dr = com.ExecuteReader();
                
                


                if (dr.Read())
                {
                    dr.Close();
                    if(comboBox2.Text == "Third Party")
                    {
                        double totalThirdpaarty = 1500;
                        double sst = 170.40;
                        double stamp = 10;
                        double rate = 0.0266;
                        double Total = totalThirdpaarty + sst + stamp + rate;


                        com.CommandText = "insert into payment (app_id, payment_method, type_of_insurance, date_start, date_end, total, years_used) values ('" + textBox1.Text + "','" + comboBox1.SelectedItem + "','" + comboBox2.SelectedItem + "','" + DateTime.Now + "'," +
                            "'" + DateTime.Now.AddDays(365) + "','"+ Total + "','0 years') ";
                        com.Connection = con;
                        com.ExecuteNonQuery(); 
                
                  
                    }

                    else if(comboBox2.SelectedItem == "Third Party, fire and tefth")
                    {
                        double Thirdpartyandtefth = 2000;
                        double sst = 170.40;
                        double stamp = 10;
                        double rate = 0.0266;
                        double Total = Thirdpartyandtefth + sst + stamp + rate;


                        com.CommandText = "insert into payment (app_id, payment_method, type_of_insurance, date_start, date_end, total, years_used) values ('" + textBox1.Text + "','" + comboBox1.SelectedItem + "','" + comboBox2.SelectedItem + "','" + DateTime.Now + "'," +
                            "'" + DateTime.Now.AddDays(365) + "','" + Total + "','0 years') ";
                        com.Connection = con;
                        com.ExecuteNonQuery();
                    }

                    else if(comboBox2.SelectedItem == "Comprehensive Cover")
                    {
                        double Comprehensive = 2500;
                        double sst = 170.40;
                        double stamp = 10;
                        double rate = 0.0266;
                        double Total = Comprehensive + sst + stamp + rate;



                        com.CommandText = "insert into payment (app_id, payment_method, type_of_insurance, date_start, date_end, total,years_used) values ('" + textBox1.Text + "','" + comboBox1.SelectedItem + "','" + comboBox2.SelectedItem + "','" + DateTime.Now + "'," +
                            "'" + DateTime.Now.AddDays(365) + "','" + Total + "','0 years') ";
                        com.Connection = con;
                        com.ExecuteNonQuery();
                       
                    }
                    MessageBox.Show("Payment Successful!");

                    this.Hide();
                    MenuForm f2 = new MenuForm();
                    f2.Show();


                }
                else
                {
                    MessageBox.Show("Info not found");

                }
                con.Close();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
          
               
                




        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuForm f2 = new MenuForm();
            f2.Show();
        }
    }
}

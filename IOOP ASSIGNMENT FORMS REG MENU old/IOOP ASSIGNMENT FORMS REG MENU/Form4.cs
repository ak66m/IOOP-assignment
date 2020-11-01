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
    public partial class renewfrm : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        public renewfrm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void menubtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuForm f2 = new MenuForm();
            f2.Show();

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "Data Source=LAPTOP-SQA3VM06;Initial Catalog=IOOP assignment; Integrated Security=true;";
            con.Open();
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuForm f2 = new MenuForm();
            f2.Show();
        }

        private void Renewbtn_Click(object sender, EventArgs e)
        {
            try
            {
                com.CommandText = "select * from payment where app_id = '" + textBox1.Text + "' ";
                com.Connection = con;
                com.ExecuteNonQuery();
                SqlDataReader dr = com.ExecuteReader();


                if (dr.Read())
                {
                    dr.Close();
                    string insuranceType = string.Empty;
                    com.CommandText = "select * from payment where app_id = '" + textBox1.Text + "'";
                    com.Connection = con;
                    com.ExecuteNonQuery();
                    SqlDataReader dtr = com.ExecuteReader();
                    if (dtr.Read())
                    {
                        insuranceType = dtr[2].ToString();                      
                        string years = dtr[6].ToString();
                        DateTime enddate = DateTime.Parse(dtr[4].ToString());
                        DateTime startdate = DateTime.Parse(dtr[3].ToString());
                        int days = DateTime.Compare(enddate, DateTime.Now);
                        int expiry = DateTime.Compare(startdate, enddate);
                        dtr.Close();
                        double Total;
                        double price;
                        double NCD;

                        if(days <= 60 && expiry <= 365)
                        {
                            if (insuranceType == "Third Party" && years == "0 years")
                            {
                                Total = 1680.42;
                                com.CommandText = "update payment set payment_method = '" + comboBox1.SelectedItem + "',date_start = '" + DateTime.Now + "', date_end = '" + DateTime.Now.AddDays(365) + "' total = '"+ Total +"', years_used = '1 year' where app_id = '" + textBox1.Text + "',''";
                                com.Connection = con;
                                com.ExecuteNonQuery();

                            }
                            else if (insuranceType == "Third Party" && years == "1 year" && comboBox2.SelectedItem == "No")
                            {
                                price = 1680.42;
                                NCD = 0.25;
                                Total = price + NCD;
                                com.CommandText = "update payment set payment_method = '" + comboBox1.SelectedItem + "',date_start = '" + DateTime.Now + "', date_end = '" + DateTime.Now.AddDays(365) + "' total = '" + Total + "', years_used = '2 years' where app_id = '" + textBox1.Text + "',''";
                                com.Connection = con;
                                com.ExecuteNonQuery();

                            }
                            else if (insuranceType == "Third Party" && years == "2 years" && comboBox2.SelectedItem == "No")
                            {

                                price = 1680.42;
                                NCD = 0.30;
                                Total = price + NCD;
                                com.CommandText = "update payment set payment_method = '" + comboBox1.SelectedItem + "',date_start = '" + DateTime.Now + "', date_end = '" + DateTime.Now.AddDays(365) + "' total = '" + Total + "', years_used = '3 years' where app_id = '" + textBox1.Text + "',''";
                                com.Connection = con;
                                com.ExecuteNonQuery();

                            }
                            else if (insuranceType == "Third Party" && years == "3 years" && comboBox2.SelectedItem == "No")
                            {

                                price = 1680.42;
                                NCD = 0.38;
                                Total = price + NCD;
                                com.CommandText = "update payment set payment_method = '" + comboBox1.SelectedItem + "',date_start = '" + DateTime.Now + "', date_end = '" + DateTime.Now.AddDays(365) + "' total = '" + Total + "', years_used = '4 years' where app_id = '" + textBox1.Text + "',''";
                                com.Connection = con;
                                com.ExecuteNonQuery();
                            }
                            else if (insuranceType == "Third Party" && years == "4 years" && comboBox2.SelectedItem == "No")
                            {

                                price = 1680.42;
                                NCD = 0.45;
                                Total = price + NCD;
                                com.CommandText = "update payment set payment_method = '" + comboBox1.SelectedItem + "',date_start = '" + DateTime.Now + "', date_end = '" + DateTime.Now.AddDays(365) + "' total = '" + Total + "', years_used = '5 years' where app_id = '" + textBox1.Text + "',''";
                                com.Connection = con;
                                com.ExecuteNonQuery();
                            }
                            else if (insuranceType == "Third Party" && years == "5 years" && comboBox2.SelectedItem == "No")
                            {

                                price = 1680.42;
                                NCD = 0.55;
                                Total = price + NCD;
                                com.CommandText = "update payment set payment_method = '" + comboBox1.SelectedItem + "',date_start = '" + DateTime.Now + "', date_end = '" + DateTime.Now.AddDays(365) + "' total = '" + Total + "', years_used = '6 years plus' where app_id = '" + textBox1.Text + "',''";
                                com.Connection = con;
                                com.ExecuteNonQuery();
                            }
                            else if (insuranceType == "Third Party" && years == "6 years plus" && comboBox2.SelectedItem == "No")
                            {

                                price = 1680.42;
                                NCD = 0.55;
                                Total = price + NCD;
                                com.CommandText = "update payment set payment_method = '" + comboBox1.SelectedItem + "',date_start = '" + DateTime.Now + "', date_end = '" + DateTime.Now.AddDays(365) + "' total = '" + Total + "', years_used = '6 years plus' where app_id = '" + textBox1.Text + "',''";
                                com.Connection = con;
                                com.ExecuteNonQuery();
                            }






                            else if (insuranceType == "Third Party, fire and tefth" && years == "0 years")
                            {
                                Total = 2180.42;
                                com.CommandText = "update payment set payment_method = '" + comboBox1.SelectedItem + "',date_start = '" + DateTime.Now + "', date_end = '" + DateTime.Now.AddDays(365) + "' total = '" + Total + "', years_used = '1 year' where app_id = '" + textBox1.Text + "'";
                                com.Connection = con;
                                com.ExecuteNonQuery();
                            }
                            else if(insuranceType == "Third Party, fire and tefth" && years == "1 year" && comboBox2.SelectedItem == "No")
                            {
                                price = 2180.42;
                                NCD = 0.25;
                                Total = price + NCD;
                                com.CommandText = "update payment set payment_method = '" + comboBox1.SelectedItem + "',date_start = '" + DateTime.Now + "', date_end = '" + DateTime.Now.AddDays(365) + "' total = '" + Total + "', years_used = '2 years' where app_id = '" + textBox1.Text + "',''";
                                com.Connection = con;
                                com.ExecuteNonQuery();
                            }
                            else if (insuranceType == "Third Party, fire and tefth" && years == "2 years" && comboBox2.SelectedItem == "No")
                            {
                                price = 2180.42;
                                NCD = 0.30;
                                Total = price + NCD;
                                com.CommandText = "update payment set payment_method = '" + comboBox1.SelectedItem + "',date_start = '" + DateTime.Now + "', date_end = '" + DateTime.Now.AddDays(365) + "' total = '" + Total + "', years_used = '3 years' where app_id = '" + textBox1.Text + "',''";
                                com.Connection = con;
                                com.ExecuteNonQuery();
                            }
                            else if (insuranceType == "Third Party, fire and tefth" && years == "3 years" && comboBox2.SelectedItem == "No")
                            {
                                price = 2180.42;
                                NCD = 0.38;
                                Total = price + NCD;
                                com.CommandText = "update payment set payment_method = '" + comboBox1.SelectedItem + "',date_start = '" + DateTime.Now + "', date_end = '" + DateTime.Now.AddDays(365) + "' total = '" + Total + "', years_used = '4 years' where app_id = '" + textBox1.Text + "',''";
                                com.Connection = con;
                                com.ExecuteNonQuery();
                            }
                            else if (insuranceType == "Third Party, fire and tefth" && years == "4 years" && comboBox2.SelectedItem == "No")
                            {
                                price = 2180.42;
                                NCD = 0.45;
                                Total = price + NCD;
                                com.CommandText = "update payment set payment_method = '" + comboBox1.SelectedItem + "',date_start = '" + DateTime.Now + "', date_end = '" + DateTime.Now.AddDays(365) + "' total = '" + Total + "', years_used = '5 years' where app_id = '" + textBox1.Text + "',''";
                                com.Connection = con;
                                com.ExecuteNonQuery();
                            }
                            else if (insuranceType == "Third Party, fire and tefth" && years == "5 years" && comboBox2.SelectedItem == "No")
                            {
                                price = 2180.42;
                                NCD = 0.55;
                                Total = price + NCD;
                                com.CommandText = "update payment set payment_method = '" + comboBox1.SelectedItem + "',date_start = '" + DateTime.Now + "', date_end = '" + DateTime.Now.AddDays(365) + "' total = '" + Total + "', years_used = '6 years plus' where app_id = '" + textBox1.Text + "',''";
                                com.Connection = con;
                                com.ExecuteNonQuery();
                            }
                            else if (insuranceType == "Third Party, fire and tefth" && years == "6 years plus" && comboBox2.SelectedItem == "No")
                            {
                                price = 2180.42;
                                NCD = 0.55;
                                Total = price + NCD;
                                com.CommandText = "update payment set payment_method = '" + comboBox1.SelectedItem + "',date_start = '" + DateTime.Now + "', date_end = '" + DateTime.Now.AddDays(365) + "' total = '" + Total + "', years_used = '6 years plus' where app_id = '" + textBox1.Text + "',''";
                                com.Connection = con;
                                com.ExecuteNonQuery();
                            }





                            else if (insuranceType == "Comprehensive Cover" && years == "0 years" && comboBox2.SelectedItem == "No")
                            {
                                Total = 2680.42;
                                com.CommandText = "update payment set payment_method = '" + comboBox1.SelectedItem + "',date_start = '" + DateTime.Now + "', date_end = '" + DateTime.Now.AddDays(365) + "' total = '" + Total + "', years_used = '1 year' where app_id = '" + textBox1.Text + "'";
                                com.Connection = con;
                                com.ExecuteNonQuery();

                            }
                            else if (insuranceType == "Comprehensive Cover" && years == "1 year" && comboBox2.SelectedItem == "No")
                            {
                                price = 2680.42;
                                NCD = 0.25;
                                Total = price + NCD;
                                com.CommandText = "update payment set payment_method = '" + comboBox1.SelectedItem + "',date_start = '" + DateTime.Now + "', date_end = '" + DateTime.Now.AddDays(365) + "' total = '" + Total + "', years_used = '2 years' where app_id = '" + textBox1.Text + "',''";
                                com.Connection = con;
                                com.ExecuteNonQuery();
                            }
                            else if (insuranceType == "Comprehensive Cover" && years == "2 years" && comboBox2.SelectedItem == "No")
                            {
                                price = 2680.42;
                                NCD = 0.30;
                                Total = price + NCD;
                                com.CommandText = "update payment set payment_method = '" + comboBox1.SelectedItem + "',date_start = '" + DateTime.Now + "', date_end = '" + DateTime.Now.AddDays(365) + "' total = '" + Total + "', years_used = '3 years' where app_id = '" + textBox1.Text + "',''";
                                com.Connection = con;
                                com.ExecuteNonQuery();
                            }
                            else if (insuranceType == "Comprehensive Cover" && years == "3 years" && comboBox2.SelectedItem == "No")
                            {
                                price = 2680.42;
                                NCD = 0.38;
                                Total = price + NCD;
                                com.CommandText = "update payment set payment_method = '" + comboBox1.SelectedItem + "',date_start = '" + DateTime.Now + "', date_end = '" + DateTime.Now.AddDays(365) + "' total = '" + Total + "', years_used = '4 years' where app_id = '" + textBox1.Text + "',''";
                                com.Connection = con;
                                com.ExecuteNonQuery();

                            }
                            else if (insuranceType == "Comprehensive Cover" && years == "4 years" && comboBox2.SelectedItem == "No")
                            {
                                price = 2680.42;
                                NCD = 0.45;
                                Total = price + NCD;
                                com.CommandText = "update payment set payment_method = '" + comboBox1.SelectedItem + "',date_start = '" + DateTime.Now + "', date_end = '" + DateTime.Now.AddDays(365) + "' total = '" + Total + "', years_used = '5 years' where app_id = '" + textBox1.Text + "',''";
                                com.Connection = con;
                                com.ExecuteNonQuery();
                            }
                            else if (insuranceType == "Comprehensive Cover" && years == "5 years" && comboBox2.SelectedItem == "No")
                            {
                                price = 2680.42;
                                NCD = 0.55;
                                Total = price + NCD;
                                com.CommandText = "update payment set payment_method = '" + comboBox1.SelectedItem + "',date_start = '" + DateTime.Now + "', date_end = '" + DateTime.Now.AddDays(365) + "' total = '" + Total + "', years_used = '6 years plus' where app_id = '" + textBox1.Text + "',''";
                                com.Connection = con;
                                com.ExecuteNonQuery();
                            }
                            else if (insuranceType == "Comprehensive Cover" && years == "5 years" && comboBox2.SelectedItem == "No")
                            {
                                price = 2680.42;
                                NCD = 0.55;
                                Total = price + NCD;
                                com.CommandText = "update payment set payment_method = '" + comboBox1.SelectedItem + "',date_start = '" + DateTime.Now + "', date_end = '" + DateTime.Now.AddDays(365) + "' total = '" + Total + "', years_used = '6 years plus' where app_id = '" + textBox1.Text + "',''";
                                com.Connection = con;
                                com.ExecuteNonQuery();
                            }
                            MessageBox.Show("Renewal Successful!");
                            this.Hide();
                            MenuForm f2 = new MenuForm();
                            f2.Show();

                        }
                        else
                        {
                            MessageBox.Show("Insurance can't be renewed");
                                                                             
                        }
                        con.Close();

                    }

                }
                else
                {
                    MessageBox.Show("Data not found");
                }
                con.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();



        }
    }
}

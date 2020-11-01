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
                        dtr.Close();
                        string years = dtr[6].ToString();
                        DateTime enddate = DateTime.Parse(dtr[4].ToString());
                        DateTime startdate = DateTime.Parse(dtr[3].ToString());
                        int days = DateTime.Compare(enddate, DateTime.Now);
                        int expiry = DateTime.Compare(startdate, enddate);
                        double Total;
                        double price;
                        double NCD;

                        if(days <= 60 && expiry <= 365)
                        {
                            if(insuranceType == "Third Party" && years == "1 year")
                            {
                               
                            }
                            else if (insuranceType == "Third Party" && years == "2 years")
                            {

                            }
                            else if (insuranceType == "Third Party" && years == "3 years")
                            {

                            }
                            else if (insuranceType == "Third Party" && years == "4 years")
                            {

                            }
                            else if (insuranceType == "Third Party" && years == "5 years")
                            {

                            }
                            else if(insuranceType == "")

                            com.CommandText = "update payment set payment_method = '" + comboBox1.SelectedItem +"',date_start = '"+ DateTime.Now +"', date_end = '"+ DateTime.Now.AddDays(365) + "'," +
                                ",'' where app_id = '" + textBox1.Text + "',''";
                            com.Connection = con;
                            com.ExecuteNonQuery();
                            SqlDataReader dtr1 = com.ExecuteReader();
                        }
                        else
                        {
                            MessageBox.Show("Insurance can't be renewed");
                                                                             
                        }
                        

                    }

                }
                else
                {
                    MessageBox.Show("Data not found");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            con.Close();

        }
    }
}

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
    
    public partial class edituserfrm : Form
    {
        public edituserfrm()
        {
            InitializeComponent();
        }

        

        

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        

       

        private void Search_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-SQA3VM06;Initial Catalog=IOOP assignment; Integrated Security=true;");
            con.Open();
            SqlCommand SelectIDcmd = new SqlCommand("Select * from REGESTERATION_T where app_id=@app_id", con);
            SelectIDcmd.Parameters.AddWithValue("@app_id", textBox1.Text);
            SqlDataAdapter da = new SqlDataAdapter(SelectIDcmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                textBox2.Text = dt.Rows[0][3].ToString();
                textBox3.Text = dt.Rows[0][5].ToString();

                ErrorMessage.Text = " ";
            }
            else
            {
                textBox2.Text = " ";
                textBox3.Text = " ";
                lblMessage.Text = " ";
                lblSMessage.Text = " ";

                ErrorMessage.Text = "Not Found!";

            }

            con.Close();

        }

        private void Update1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-SQA3VM06;Initial Catalog=IOOP assignment; Integrated Security=true;");
            con.Open();
            string sqlQuery = "UPDATE REGESTERATION_T SET app_address = '" + textBox2.Text + "' where app_id = '" + textBox1.Text + "';";
            SqlCommand cmd = new SqlCommand(sqlQuery, con);
            int result = cmd.ExecuteNonQuery();
            if (result > 0)
            {
                lblMessage.Text = "Successfully Updated!";
            }
            else
            {
                lblMessage.Text = "Not able to Update now! Please try again later";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-SQA3VM06;Initial Catalog=IOOP assignment; Integrated Security=true;");
            con.Open();
            string sqlQuery = "UPDATE REGESTERATION_T SET app_password = '" + textBox3.Text + "' where app_id = '" + textBox1.Text + "';";
            SqlCommand cmd = new SqlCommand(sqlQuery, con);
            int result = cmd.ExecuteNonQuery();
            if (result > 0)
            {
                lblSMessage.Text = "Successfully Updated!";
            }
            else
            {
                lblSMessage.Text = "Not able to Update now! Please try again later";
            }
        }

        private void Mainbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuForm f2 = new MenuForm();
            f2.Show();
        }
    }
}

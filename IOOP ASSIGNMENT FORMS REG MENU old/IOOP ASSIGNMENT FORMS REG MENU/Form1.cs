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
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        public Form1()
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
            com.CommandText = "";
            com.Connection = con;
            com.ExecuteNonQuery();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}

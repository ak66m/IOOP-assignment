using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP_ASSIGNMENT_FORMS_REG_MENU
{
    public partial class Registeration : Form
    {
        public Registeration()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Registeration_Load(object sender, EventArgs e)
        {
            
        }

        private void Backbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginForm f3 = new loginForm();
            f3.Show();
        }

        private void RegisterBTN_Click(object sender, EventArgs e)
        {
            try
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
                                        this.Hide();
                                        MenuForm f2 = new MenuForm();
                                        f2.ShowDialog();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Please fill in your information");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Please fill in your information");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Please fill in your information");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please fill in your information");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please fill in your information");
                    }
                }
                else
                {
                    MessageBox.Show("Please fill in your information");
                }
            }
            catch(Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void tologinbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginForm f3 = new loginForm();
            f3.Show();
        }
    }
}

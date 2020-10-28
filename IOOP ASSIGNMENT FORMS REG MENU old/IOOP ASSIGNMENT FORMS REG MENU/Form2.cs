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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            renewfrm f4 = new renewfrm();
            f4.Show();
        }

        private void Logoutbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginForm f3 = new loginForm();
            f3.Show();
        }

        private void Registering_Click(object sender, EventArgs e)
        {
            this.Hide();
            logedregester f1 = new logedregester();
            f1.Show();
        }

        private void NewInsurance_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewInsuranceFrm f6 = new NewInsuranceFrm();
            f6.Show();
        }

        private void EditUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            edituserfrm f5 = new edituserfrm();
            f5.Show();

        }
    }
}

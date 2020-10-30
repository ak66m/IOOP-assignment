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
    public partial class NewInsuranceFrm : Form
    {
        public NewInsuranceFrm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void NewInsuranceFrm_Load(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void maimenubtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuForm f2 = new MenuForm();
            f2.Show();
        }

        private void PurchasThirdParty_Click(object sender, EventArgs e)
        {
            payfrm f8 = new payfrm();
            f8.Show();
            this.Hide();
        }

        private void PurchaseFireandTheft_Click(object sender, EventArgs e)
        {
            payfrm f8 = new payfrm();
            f8.Show();
            this.Hide();
        }

        private void PurchaseComp_Click(object sender, EventArgs e)
        {
            payfrm f8 = new payfrm();
            f8.Show();
            this.Hide();
        }
    }
}

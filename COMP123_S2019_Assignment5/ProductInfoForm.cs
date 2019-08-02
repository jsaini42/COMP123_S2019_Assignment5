using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Assignment5
{
    public partial class ProductInfoForm : Form
    {
        public ProductInfoForm()
        {
            InitializeComponent();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.Forms[FormName.ORDER_FORM].Show();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ChooseAnotherProductButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.Forms[FormName.SELECT_FORM].Show();
        }
    }
}

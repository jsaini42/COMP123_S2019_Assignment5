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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void StartForm_Load(object sender, EventArgs e)
        {

        }

        private void StartNewOrderButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.Forms[FormName.SELECT_FORM].Show();
        }

        private void ExitProgramButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoadSavedOrderButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.Forms[FormName.PRODUCTINFO_FORM].Show();
        }
    }
}

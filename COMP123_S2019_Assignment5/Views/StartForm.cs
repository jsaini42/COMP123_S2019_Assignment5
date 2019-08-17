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

        /// <summary>
        /// This is the event handler for Startneworder click event which will hide startForm and open selectform
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartNewOrderButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.Forms[FormName.SELECT_FORM].Show();
        }

        /// <summary>
        ///  This is the event handler forexitprogram click event which will exit the program.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitProgramButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        ///  This is the event handler for Loadsaveorder click event which will open Productinfoform
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadSavedOrderButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.Forms[FormName.PRODUCTINFO_FORM].Show();
           
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Assignment5.Views
{
    public partial class SplashScreen : Form
    {
        /// <summary>
        /// This is the constructor method
        /// </summary>
        public SplashScreen()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This is event handler for SplashTimer_Tick event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SplashTimer_Tick(object sender, EventArgs e)
        {
            SplashTimer.Enabled = false;
            this.Hide();
            Program.Forms[FormName.START_FORM].Show();
        }

        /// <summary>
        /// This is event handler for SplashScreen_Load event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SplashScreen_Load(object sender, EventArgs e)
        {
            SplashTimer.Enabled = true;
        }

    }
}

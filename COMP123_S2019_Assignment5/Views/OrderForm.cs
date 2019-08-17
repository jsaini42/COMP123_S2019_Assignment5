using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing.Printing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Assignment5.Views
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This is the event handler for backToolStripMenuItem click event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.Forms[FormName.PRODUCTINFO_FORM].Show();
        }

        /// <summary>
        /// This is the event handler for  aboutToolStripMenuItem click event which will open about form .
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.Forms[FormName.ABOUT_FORM].Show();
        }

        /// <summary>
        /// This is the event handler for  exitToolStripMenuItem click event which will exit the program .
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// This is the event handler for cancelbutton click event which will exit the program .
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// This is the event handler for backbutton click event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.Forms[FormName.PRODUCTINFO_FORM].Show();
        }

        private void FinishButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for Shopping" + "\n Your Order will be processed in 2-3 business days", "Order Confirmed",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductPrintForm.PrintAction = PrintAction.PrintToPreview;
            ProductPrintForm.Print();
        }

        private void OrderForm_Activated(object sender, EventArgs e)
        {
            ConditionTextBox.Text = "" + Program.product.condition;
            ManufacturerTextBox.Text = "" + Program.product.manufacturer;
            LCDSizeTextBox.Text = "" + Program.product.screensize;
            PlatformTextBox.Text = "" + Program.product.platform;
            ModelTextBox.Text = "" + Program.product.model;
            MemoryTextBox.Text = "" + Program.product.RAM_size;
            CPUBrandTextBox.Text = "" + Program.product.CPU_brand;
            CPUNumberTextBox.Text = "" + Program.product.CPU_number;
            CPUTypeTextBox.Text = "" + Program.product.CPU_type;
            CPUSpeedTextBox.Text = "" + Program.product.CPU_speed;
            HDDTextBox.Text = "" + Program.product.HDD_size;
            GPUTypeTextBox.Text = "" + Program.product.GPU_Type;
            WebCamTextBox.Text = "" + Program.product.webcam;
            WebCamTextBox.Text = "" + Program.product.webcam;
            OSTextBox.Text = "" + Program.product.OS;
            PriceTextBox.Text = "" + Program.product.cost;
            SalesTaxTextBox.Text = "" + (19 * Program.product.cost )/100;
            TotalTextBox.Text = ""+ $"{ PriceTextBox.Text + SalesTaxTextBox.Text}";
        }
    }
}


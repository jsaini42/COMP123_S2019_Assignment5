using COMP123_S2019_Assignment5.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Assignment5.Views
{
    public partial class SelectForm : Form
    {
        public SelectForm()
        {
            InitializeComponent();
        }

        /// <summary>
        ///  This is the event handler for nextbutton click event which will hide  selectform and open Productinfoform.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.Forms[FormName.PRODUCTINFO_FORM].Show();
        }

        /// <summary>
        /// This is the event handler for cancelbutton click event which willexit the program.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// This is event handler for select form load event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectForm_Load(object sender, EventArgs e)
        {
            using (var db = new DollarComputersContext())
            {
                db.products.Load();
                productBindingSource.DataSource = db.products.Local.ToBindingList();
            }
        }

        private void ProductDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            var rowIndex = ProductDataGridView.CurrentCell.RowIndex;
            var currentRow = ProductDataGridView.Rows[rowIndex];

            SelectedProductTextBox.Text = ProductDataGridViewSelectedItem();

            Program.product.productID = short.Parse(currentRow.Cells[0].Value.ToString());
            Program.product.cost = decimal.Parse(currentRow.Cells[1].Value.ToString());
            Program.product.manufacturer = currentRow.Cells[2].Value.ToString();
            Program.product.model = currentRow.Cells[3].Value.ToString();
            Program.product.RAM_type = currentRow.Cells[4].Value.ToString();
            Program.product.RAM_size= currentRow.Cells[5].Value.ToString();
            Program.product.displaytype = currentRow.Cells[6].Value.ToString();
            Program.product.screensize = currentRow.Cells[7].Value.ToString();
            Program.product.resolution = currentRow.Cells[8].Value.ToString();
            Program.product.CPU_Class= currentRow.Cells[9].Value.ToString();
            Program.product.CPU_brand = currentRow.Cells[10].Value.ToString();
            Program.product.CPU_type= currentRow.Cells[11].Value.ToString();
            Program.product.CPU_speed = currentRow.Cells[12].Value.ToString();
            Program.product.CPU_number = currentRow.Cells[13].Value.ToString();
            Program.product.condition = currentRow.Cells[14].Value.ToString();
            Program.product.OS = currentRow.Cells[15].Value.ToString();
            Program.product.platform = currentRow.Cells[16].Value.ToString();
            Program.product.HDD_size = currentRow.Cells[17].Value.ToString();
            Program.product.HDD_speed = currentRow.Cells[18].Value.ToString();
            Program.product.GPU_Type = currentRow.Cells[19].Value.ToString();
            Program.product.webcam = currentRow.Cells[30].Value.ToString();


        }
        private string ProductDataGridViewSelectedItem()
        {
            var rowIndex = ProductDataGridView.CurrentCell.RowIndex;
            var currentRow = ProductDataGridView.Rows[rowIndex];
            var cost = currentRow.Cells[1].Value.ToString();
            var manufacturer = currentRow.Cells[2].Value.ToString();
            var model = currentRow.Cells[3].Value.ToString();

            string outputstring = manufacturer + " " + model + "  $" + cost;
            return outputstring;
        }
    }
}

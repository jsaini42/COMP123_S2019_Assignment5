using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Assignment5.Views
{
    public partial class ProductInfoForm : Form
    {
        /// <summary>
        /// This is the default constructor 
        /// </summary>
        public ProductInfoForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This is the event handler for nextbutton click event which will hide  Productinfoform and openorderform.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.Forms[FormName.ORDER_FORM].Show();
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
        /// this is event handler for ChooseAnotherProduct click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChooseAnotherProductButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.Forms[FormName.SELECT_FORM].Show();
        }       

        /// <summary>
        /// This is the event handler for exitToolStripMenuItem Click event to exit the program .
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ProductInfoForm_Activated(object sender, EventArgs e)
        {
            ProductIDTextBox.Text = ""+Program.product.productID;
            ConditionTextBox.Text = "" + Program.product.condition;
            CostTextBox.Text = "" + Program.product.cost;
            ManufacturerTextBox.Text = "" + Program.product.manufacturer;
            PlatformTextBox.Text= "" + Program.product.platform;
            OSTextBox.Text= "" + Program.product.OS;
            ModelTextBox.Text= "" + Program.product.model;
            MemoryTextBox.Text= "" + Program.product.RAM_size;
            LCDSizeTextBox.Text= "" + Program.product.screensize;
            HDDTextBox.Text= "" + Program.product.HDD_size;
            CPUBrandTextBox.Text= "" + Program.product.CPU_brand;
            CPUNumberTextBox.Text= "" + Program.product.CPU_number;
            GPUTypeTextBox.Text= "" + Program.product.GPU_Type;
            CPUTypeTextBox.Text= "" + Program.product.CPU_type;
            CPUSpeedTextBox.Text= "" + Program.product.CPU_speed;
            WebCamTextBox.Text= "" + Program.product.webcam;

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //file dialog configuration
            SelectedProductSaveFileDialog.FileName = "Selected Product.txt";
            SelectedProductSaveFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            SelectedProductSaveFileDialog.Filter = "Text Files (*.txt)|*.txt| All Files (*.*)|*.*";

            // to open file dialog
            var value = SelectedProductSaveFileDialog.ShowDialog();
            if (value != DialogResult.Cancel)
            {
                // open the stream for writing
                using (StreamWriter writer = new StreamWriter(
                    File.Open(SelectedProductSaveFileDialog.FileName, FileMode.Create)))
                {
                    // writing content to file

                    writer.WriteLine(Program.product.productID.ToString());
                    writer.WriteLine(Program.product.condition);
                    writer.WriteLine(Program.product.cost.ToString());
                    writer.WriteLine(Program.product.manufacturer);
                    writer.WriteLine(Program.product.platform);
                    writer.WriteLine(Program.product.OS);
                    writer.WriteLine(Program.product.model);
                    writer.WriteLine(Program.product.RAM_size);
                    writer.WriteLine(Program.product.screensize);
                    writer.WriteLine(Program.product.HDD_size);
                    writer.WriteLine(Program.product.CPU_brand);
                    writer.WriteLine(Program.product.CPU_number);
                    writer.WriteLine(Program.product.GPU_Type);
                    writer.WriteLine(Program.product.CPU_type);
                    writer.WriteLine(Program.product.CPU_speed);
                    writer.WriteLine(Program.product.webcam);
                    

                    // cleanup
                    writer.Close();
                    writer.Dispose();

                    // user feedback
                    MessageBox.Show("Conputer Configuration List saved successfully...", "Saving File...",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                }
            }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //file dialog configuration
            SelectedProductOpenFileDialog.FileName = "Selected Product.txt";
            SelectedProductOpenFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            SelectedProductOpenFileDialog.Filter = "Text Files (*.txt)|*.txt| All Files (*.*)|*.*";

            // to open file dialog
            var value = SelectedProductOpenFileDialog.ShowDialog();
            if (value != DialogResult.Cancel)
            {
                try
                {
                    // open stream for reading
                    using (StreamReader reader = new StreamReader(
                        File.Open(SelectedProductOpenFileDialog.FileName, FileMode.Open)))
                    {
                        // read from the file
                        Program.product.productID= short.Parse(reader.ReadLine());
                        Program.product.condition = reader.ReadLine();
                        Program.product.cost = decimal.Parse(reader.ReadLine());
                        Program.product.manufacturer = reader.ReadLine();
                        Program.product.platform = reader.ReadLine();
                        Program.product.OS = reader.ReadLine();
                        Program.product.model = reader.ReadLine();
                        Program.product.RAM_size = reader.ReadLine();
                        Program.product.screensize = reader.ReadLine();
                        Program.product.HDD_size = reader.ReadLine();
                        Program.product.CPU_brand = reader.ReadLine();
                        Program.product.CPU_number = reader.ReadLine();
                        Program.product.GPU_Type = reader.ReadLine();
                        Program.product.CPU_type = reader.ReadLine();
                        Program.product.CPU_speed = reader.ReadLine();
                        Program.product.webcam = reader.ReadLine();


                        // to clear
                        reader.Close();
                        reader.Dispose();
                    }

                    NextButton_Click(sender, e);
                }
                catch (IOException exception)
                {

                    System.Diagnostics.Debug.WriteLine("ERROR: " + exception.Message);

                    MessageBox.Show("ERROR: " + exception.Message, "ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            }
    }
}

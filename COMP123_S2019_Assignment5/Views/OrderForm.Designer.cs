namespace COMP123_S2019_Assignment5.Views
{
    partial class OrderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            this.OrderFormMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SystemComponentsGroupBox = new System.Windows.Forms.GroupBox();
            this.OSTextBox = new System.Windows.Forms.TextBox();
            this.OSLabel = new System.Windows.Forms.Label();
            this.HDDTextBox = new System.Windows.Forms.TextBox();
            this.HDDLabel = new System.Windows.Forms.Label();
            this.GPUTypeTextBox = new System.Windows.Forms.TextBox();
            this.GPUTypeLabel = new System.Windows.Forms.Label();
            this.WebCamTextBox = new System.Windows.Forms.TextBox();
            this.WebCamLabel = new System.Windows.Forms.Label();
            this.CPUSpeedTextBox = new System.Windows.Forms.TextBox();
            this.CPUSpeedLabel = new System.Windows.Forms.Label();
            this.CPUNumberTextBox = new System.Windows.Forms.TextBox();
            this.CPUNumberLabel = new System.Windows.Forms.Label();
            this.CPUTypeTextBox = new System.Windows.Forms.TextBox();
            this.CPUTypeLabel = new System.Windows.Forms.Label();
            this.CPUBrandTextBox = new System.Windows.Forms.TextBox();
            this.CPUBrandLabel = new System.Windows.Forms.Label();
            this.MemoryTextBox = new System.Windows.Forms.TextBox();
            this.MemoryLabel = new System.Windows.Forms.Label();
            this.LCDSizeTextBox = new System.Windows.Forms.TextBox();
            this.LCDSizeLabel = new System.Windows.Forms.Label();
            this.ModelTextBox = new System.Windows.Forms.TextBox();
            this.PlatformTextBox = new System.Windows.Forms.TextBox();
            this.ManufacturerTextBox = new System.Windows.Forms.TextBox();
            this.ConditionTextBox = new System.Windows.Forms.TextBox();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.PlatformLabel = new System.Windows.Forms.Label();
            this.ManufacturerLabel = new System.Windows.Forms.Label();
            this.ConditionLabel = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.SystemComponentslineShape = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.PriceGroupBox = new System.Windows.Forms.GroupBox();
            this.TotalTextBox = new System.Windows.Forms.TextBox();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.SalesTaxTextBox = new System.Windows.Forms.TextBox();
            this.SalesTaxLabel = new System.Windows.Forms.Label();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.FinishButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.ProductPrintForm = new Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(this.components);
            this.OrderFormMenuStrip.SuspendLayout();
            this.SystemComponentsGroupBox.SuspendLayout();
            this.PriceGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // OrderFormMenuStrip
            // 
            this.OrderFormMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.OrderFormMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.OrderFormMenuStrip.Name = "OrderFormMenuStrip";
            this.OrderFormMenuStrip.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.OrderFormMenuStrip.Size = new System.Drawing.Size(784, 25);
            this.OrderFormMenuStrip.TabIndex = 1;
            this.OrderFormMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 19);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 19);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 19);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // SystemComponentsGroupBox
            // 
            this.SystemComponentsGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.SystemComponentsGroupBox.Controls.Add(this.OSTextBox);
            this.SystemComponentsGroupBox.Controls.Add(this.OSLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.HDDTextBox);
            this.SystemComponentsGroupBox.Controls.Add(this.HDDLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.GPUTypeTextBox);
            this.SystemComponentsGroupBox.Controls.Add(this.GPUTypeLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.WebCamTextBox);
            this.SystemComponentsGroupBox.Controls.Add(this.WebCamLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.CPUSpeedTextBox);
            this.SystemComponentsGroupBox.Controls.Add(this.CPUSpeedLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.CPUNumberTextBox);
            this.SystemComponentsGroupBox.Controls.Add(this.CPUNumberLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.CPUTypeTextBox);
            this.SystemComponentsGroupBox.Controls.Add(this.CPUTypeLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.CPUBrandTextBox);
            this.SystemComponentsGroupBox.Controls.Add(this.CPUBrandLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.MemoryTextBox);
            this.SystemComponentsGroupBox.Controls.Add(this.MemoryLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.LCDSizeTextBox);
            this.SystemComponentsGroupBox.Controls.Add(this.LCDSizeLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.ModelTextBox);
            this.SystemComponentsGroupBox.Controls.Add(this.PlatformTextBox);
            this.SystemComponentsGroupBox.Controls.Add(this.ManufacturerTextBox);
            this.SystemComponentsGroupBox.Controls.Add(this.ConditionTextBox);
            this.SystemComponentsGroupBox.Controls.Add(this.ModelLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.PlatformLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.ManufacturerLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.ConditionLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.shapeContainer1);
            this.SystemComponentsGroupBox.ForeColor = System.Drawing.Color.White;
            this.SystemComponentsGroupBox.Location = new System.Drawing.Point(8, 39);
            this.SystemComponentsGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.SystemComponentsGroupBox.Name = "SystemComponentsGroupBox";
            this.SystemComponentsGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.SystemComponentsGroupBox.Size = new System.Drawing.Size(476, 459);
            this.SystemComponentsGroupBox.TabIndex = 8;
            this.SystemComponentsGroupBox.TabStop = false;
            this.SystemComponentsGroupBox.Text = "System Components";
            // 
            // OSTextBox
            // 
            this.OSTextBox.Enabled = false;
            this.OSTextBox.Location = new System.Drawing.Point(105, 419);
            this.OSTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.OSTextBox.Name = "OSTextBox";
            this.OSTextBox.Size = new System.Drawing.Size(191, 26);
            this.OSTextBox.TabIndex = 23;
            // 
            // OSLabel
            // 
            this.OSLabel.AutoSize = true;
            this.OSLabel.Location = new System.Drawing.Point(68, 422);
            this.OSLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.OSLabel.Name = "OSLabel";
            this.OSLabel.Size = new System.Drawing.Size(32, 20);
            this.OSLabel.TabIndex = 22;
            this.OSLabel.Text = "OS";
            // 
            // HDDTextBox
            // 
            this.HDDTextBox.Enabled = false;
            this.HDDTextBox.Location = new System.Drawing.Point(105, 317);
            this.HDDTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.HDDTextBox.Name = "HDDTextBox";
            this.HDDTextBox.Size = new System.Drawing.Size(191, 26);
            this.HDDTextBox.TabIndex = 14;
            // 
            // HDDLabel
            // 
            this.HDDLabel.AutoSize = true;
            this.HDDLabel.Location = new System.Drawing.Point(58, 319);
            this.HDDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HDDLabel.Name = "HDDLabel";
            this.HDDLabel.Size = new System.Drawing.Size(45, 20);
            this.HDDLabel.TabIndex = 15;
            this.HDDLabel.Text = "HDD";
            // 
            // GPUTypeTextBox
            // 
            this.GPUTypeTextBox.Enabled = false;
            this.GPUTypeTextBox.Location = new System.Drawing.Point(105, 352);
            this.GPUTypeTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.GPUTypeTextBox.Name = "GPUTypeTextBox";
            this.GPUTypeTextBox.Size = new System.Drawing.Size(191, 26);
            this.GPUTypeTextBox.TabIndex = 18;
            // 
            // GPUTypeLabel
            // 
            this.GPUTypeLabel.AutoSize = true;
            this.GPUTypeLabel.Location = new System.Drawing.Point(19, 354);
            this.GPUTypeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GPUTypeLabel.Name = "GPUTypeLabel";
            this.GPUTypeLabel.Size = new System.Drawing.Size(82, 20);
            this.GPUTypeLabel.TabIndex = 19;
            this.GPUTypeLabel.Text = "GPU Type";
            // 
            // WebCamTextBox
            // 
            this.WebCamTextBox.Enabled = false;
            this.WebCamTextBox.Location = new System.Drawing.Point(105, 384);
            this.WebCamTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.WebCamTextBox.Name = "WebCamTextBox";
            this.WebCamTextBox.Size = new System.Drawing.Size(191, 26);
            this.WebCamTextBox.TabIndex = 20;
            // 
            // WebCamLabel
            // 
            this.WebCamLabel.AutoSize = true;
            this.WebCamLabel.Location = new System.Drawing.Point(25, 387);
            this.WebCamLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WebCamLabel.Name = "WebCamLabel";
            this.WebCamLabel.Size = new System.Drawing.Size(75, 20);
            this.WebCamLabel.TabIndex = 21;
            this.WebCamLabel.Text = "WebCam";
            // 
            // CPUSpeedTextBox
            // 
            this.CPUSpeedTextBox.Enabled = false;
            this.CPUSpeedTextBox.Location = new System.Drawing.Point(105, 281);
            this.CPUSpeedTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.CPUSpeedTextBox.Name = "CPUSpeedTextBox";
            this.CPUSpeedTextBox.Size = new System.Drawing.Size(191, 26);
            this.CPUSpeedTextBox.TabIndex = 16;
            // 
            // CPUSpeedLabel
            // 
            this.CPUSpeedLabel.AutoSize = true;
            this.CPUSpeedLabel.Location = new System.Drawing.Point(9, 283);
            this.CPUSpeedLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CPUSpeedLabel.Name = "CPUSpeedLabel";
            this.CPUSpeedLabel.Size = new System.Drawing.Size(93, 20);
            this.CPUSpeedLabel.TabIndex = 17;
            this.CPUSpeedLabel.Text = "CPU Speed";
            // 
            // CPUNumberTextBox
            // 
            this.CPUNumberTextBox.Enabled = false;
            this.CPUNumberTextBox.Location = new System.Drawing.Point(105, 245);
            this.CPUNumberTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.CPUNumberTextBox.Name = "CPUNumberTextBox";
            this.CPUNumberTextBox.Size = new System.Drawing.Size(106, 26);
            this.CPUNumberTextBox.TabIndex = 8;
            // 
            // CPUNumberLabel
            // 
            this.CPUNumberLabel.AutoSize = true;
            this.CPUNumberLabel.Location = new System.Drawing.Point(-1, 248);
            this.CPUNumberLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CPUNumberLabel.Name = "CPUNumberLabel";
            this.CPUNumberLabel.Size = new System.Drawing.Size(102, 20);
            this.CPUNumberLabel.TabIndex = 8;
            this.CPUNumberLabel.Text = "CPU Number";
            // 
            // CPUTypeTextBox
            // 
            this.CPUTypeTextBox.Enabled = false;
            this.CPUTypeTextBox.Location = new System.Drawing.Point(105, 211);
            this.CPUTypeTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.CPUTypeTextBox.Name = "CPUTypeTextBox";
            this.CPUTypeTextBox.Size = new System.Drawing.Size(106, 26);
            this.CPUTypeTextBox.TabIndex = 13;
            // 
            // CPUTypeLabel
            // 
            this.CPUTypeLabel.AutoSize = true;
            this.CPUTypeLabel.Location = new System.Drawing.Point(20, 215);
            this.CPUTypeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CPUTypeLabel.Name = "CPUTypeLabel";
            this.CPUTypeLabel.Size = new System.Drawing.Size(80, 20);
            this.CPUTypeLabel.TabIndex = 12;
            this.CPUTypeLabel.Text = "CPU Type";
            // 
            // CPUBrandTextBox
            // 
            this.CPUBrandTextBox.Enabled = false;
            this.CPUBrandTextBox.Location = new System.Drawing.Point(105, 177);
            this.CPUBrandTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.CPUBrandTextBox.Name = "CPUBrandTextBox";
            this.CPUBrandTextBox.Size = new System.Drawing.Size(106, 26);
            this.CPUBrandTextBox.TabIndex = 13;
            // 
            // CPUBrandLabel
            // 
            this.CPUBrandLabel.AutoSize = true;
            this.CPUBrandLabel.Location = new System.Drawing.Point(14, 179);
            this.CPUBrandLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CPUBrandLabel.Name = "CPUBrandLabel";
            this.CPUBrandLabel.Size = new System.Drawing.Size(89, 20);
            this.CPUBrandLabel.TabIndex = 14;
            this.CPUBrandLabel.Text = "CPU Brand";
            // 
            // MemoryTextBox
            // 
            this.MemoryTextBox.Enabled = false;
            this.MemoryTextBox.Location = new System.Drawing.Point(105, 141);
            this.MemoryTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.MemoryTextBox.Name = "MemoryTextBox";
            this.MemoryTextBox.Size = new System.Drawing.Size(106, 26);
            this.MemoryTextBox.TabIndex = 11;
            // 
            // MemoryLabel
            // 
            this.MemoryLabel.AutoSize = true;
            this.MemoryLabel.Location = new System.Drawing.Point(35, 145);
            this.MemoryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MemoryLabel.Name = "MemoryLabel";
            this.MemoryLabel.Size = new System.Drawing.Size(65, 20);
            this.MemoryLabel.TabIndex = 11;
            this.MemoryLabel.Text = "Memory";
            // 
            // LCDSizeTextBox
            // 
            this.LCDSizeTextBox.Enabled = false;
            this.LCDSizeTextBox.Location = new System.Drawing.Point(105, 94);
            this.LCDSizeTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.LCDSizeTextBox.Name = "LCDSizeTextBox";
            this.LCDSizeTextBox.Size = new System.Drawing.Size(106, 26);
            this.LCDSizeTextBox.TabIndex = 9;
            // 
            // LCDSizeLabel
            // 
            this.LCDSizeLabel.AutoSize = true;
            this.LCDSizeLabel.Location = new System.Drawing.Point(27, 94);
            this.LCDSizeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LCDSizeLabel.Name = "LCDSizeLabel";
            this.LCDSizeLabel.Size = new System.Drawing.Size(76, 20);
            this.LCDSizeLabel.TabIndex = 9;
            this.LCDSizeLabel.Text = "LCD Size";
            // 
            // ModelTextBox
            // 
            this.ModelTextBox.Enabled = false;
            this.ModelTextBox.Location = new System.Drawing.Point(301, 61);
            this.ModelTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.ModelTextBox.Name = "ModelTextBox";
            this.ModelTextBox.Size = new System.Drawing.Size(158, 26);
            this.ModelTextBox.TabIndex = 8;
            // 
            // PlatformTextBox
            // 
            this.PlatformTextBox.Enabled = false;
            this.PlatformTextBox.Location = new System.Drawing.Point(300, 26);
            this.PlatformTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.PlatformTextBox.Name = "PlatformTextBox";
            this.PlatformTextBox.Size = new System.Drawing.Size(158, 26);
            this.PlatformTextBox.TabIndex = 9;
            // 
            // ManufacturerTextBox
            // 
            this.ManufacturerTextBox.Enabled = false;
            this.ManufacturerTextBox.Location = new System.Drawing.Point(105, 61);
            this.ManufacturerTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.ManufacturerTextBox.Name = "ManufacturerTextBox";
            this.ManufacturerTextBox.Size = new System.Drawing.Size(106, 26);
            this.ManufacturerTextBox.TabIndex = 10;
            // 
            // ConditionTextBox
            // 
            this.ConditionTextBox.Enabled = false;
            this.ConditionTextBox.Location = new System.Drawing.Point(105, 26);
            this.ConditionTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.ConditionTextBox.Name = "ConditionTextBox";
            this.ConditionTextBox.Size = new System.Drawing.Size(106, 26);
            this.ConditionTextBox.TabIndex = 11;
            // 
            // ModelLabel
            // 
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.Location = new System.Drawing.Point(244, 63);
            this.ModelLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(52, 20);
            this.ModelLabel.TabIndex = 8;
            this.ModelLabel.Text = "Model";
            // 
            // PlatformLabel
            // 
            this.PlatformLabel.AutoSize = true;
            this.PlatformLabel.Location = new System.Drawing.Point(230, 26);
            this.PlatformLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PlatformLabel.Name = "PlatformLabel";
            this.PlatformLabel.Size = new System.Drawing.Size(68, 20);
            this.PlatformLabel.TabIndex = 9;
            this.PlatformLabel.Text = "Platform";
            // 
            // ManufacturerLabel
            // 
            this.ManufacturerLabel.AutoSize = true;
            this.ManufacturerLabel.Location = new System.Drawing.Point(3, 63);
            this.ManufacturerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ManufacturerLabel.Name = "ManufacturerLabel";
            this.ManufacturerLabel.Size = new System.Drawing.Size(104, 20);
            this.ManufacturerLabel.TabIndex = 10;
            this.ManufacturerLabel.Text = "Manufacturer";
            // 
            // ConditionLabel
            // 
            this.ConditionLabel.AutoSize = true;
            this.ConditionLabel.Location = new System.Drawing.Point(27, 30);
            this.ConditionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ConditionLabel.Name = "ConditionLabel";
            this.ConditionLabel.Size = new System.Drawing.Size(76, 20);
            this.ConditionLabel.TabIndex = 11;
            this.ConditionLabel.Text = "Condition";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(2, 21);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.SystemComponentslineShape});
            this.shapeContainer1.Size = new System.Drawing.Size(472, 436);
            this.shapeContainer1.TabIndex = 12;
            this.shapeContainer1.TabStop = false;
            // 
            // SystemComponentslineShape
            // 
            this.SystemComponentslineShape.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.SystemComponentslineShape.Name = "SystemComponentslineShape";
            this.SystemComponentslineShape.X1 = -12;
            this.SystemComponentslineShape.X2 = 497;
            this.SystemComponentslineShape.Y1 = 106;
            this.SystemComponentslineShape.Y2 = 106;
            // 
            // PriceGroupBox
            // 
            this.PriceGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.PriceGroupBox.Controls.Add(this.TotalTextBox);
            this.PriceGroupBox.Controls.Add(this.TotalLabel);
            this.PriceGroupBox.Controls.Add(this.SalesTaxTextBox);
            this.PriceGroupBox.Controls.Add(this.SalesTaxLabel);
            this.PriceGroupBox.Controls.Add(this.PriceTextBox);
            this.PriceGroupBox.Controls.Add(this.PriceLabel);
            this.PriceGroupBox.Controls.Add(this.shapeContainer2);
            this.PriceGroupBox.ForeColor = System.Drawing.Color.White;
            this.PriceGroupBox.Location = new System.Drawing.Point(489, 242);
            this.PriceGroupBox.Name = "PriceGroupBox";
            this.PriceGroupBox.Size = new System.Drawing.Size(283, 150);
            this.PriceGroupBox.TabIndex = 9;
            this.PriceGroupBox.TabStop = false;
            this.PriceGroupBox.Text = "Price";
            // 
            // TotalTextBox
            // 
            this.TotalTextBox.Enabled = false;
            this.TotalTextBox.Location = new System.Drawing.Point(172, 108);
            this.TotalTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.TotalTextBox.Name = "TotalTextBox";
            this.TotalTextBox.Size = new System.Drawing.Size(82, 26);
            this.TotalTextBox.TabIndex = 21;
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Location = new System.Drawing.Point(5, 114);
            this.TotalLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(44, 20);
            this.TotalLabel.TabIndex = 20;
            this.TotalLabel.Text = "Total";
            // 
            // SalesTaxTextBox
            // 
            this.SalesTaxTextBox.Enabled = false;
            this.SalesTaxTextBox.Location = new System.Drawing.Point(172, 63);
            this.SalesTaxTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.SalesTaxTextBox.Name = "SalesTaxTextBox";
            this.SalesTaxTextBox.Size = new System.Drawing.Size(82, 26);
            this.SalesTaxTextBox.TabIndex = 17;
            // 
            // SalesTaxLabel
            // 
            this.SalesTaxLabel.AutoSize = true;
            this.SalesTaxLabel.Location = new System.Drawing.Point(5, 66);
            this.SalesTaxLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SalesTaxLabel.Name = "SalesTaxLabel";
            this.SalesTaxLabel.Size = new System.Drawing.Size(116, 20);
            this.SalesTaxLabel.TabIndex = 18;
            this.SalesTaxLabel.Text = "SalesTax(19%)";
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Enabled = false;
            this.PriceTextBox.Location = new System.Drawing.Point(172, 24);
            this.PriceTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(82, 26);
            this.PriceTextBox.TabIndex = 15;
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(5, 33);
            this.PriceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(44, 20);
            this.PriceLabel.TabIndex = 16;
            this.PriceLabel.Text = "Price";
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(3, 22);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer2.Size = new System.Drawing.Size(277, 125);
            this.shapeContainer2.TabIndex = 19;
            this.shapeContainer2.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = -2;
            this.lineShape1.X2 = 277;
            this.lineShape1.Y1 = 79;
            this.lineShape1.Y2 = 79;
            // 
            // FinishButton
            // 
            this.FinishButton.BackColor = System.Drawing.SystemColors.Control;
            this.FinishButton.Location = new System.Drawing.Point(711, 465);
            this.FinishButton.Margin = new System.Windows.Forms.Padding(2);
            this.FinishButton.Name = "FinishButton";
            this.FinishButton.Size = new System.Drawing.Size(61, 33);
            this.FinishButton.TabIndex = 25;
            this.FinishButton.Text = "Finish";
            this.FinishButton.UseVisualStyleBackColor = false;
            this.FinishButton.Click += new System.EventHandler(this.FinishButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton.Location = new System.Drawing.Point(624, 465);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(2);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(71, 33);
            this.CancelButton.TabIndex = 24;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.SystemColors.Control;
            this.BackButton.Location = new System.Drawing.Point(539, 465);
            this.BackButton.Margin = new System.Windows.Forms.Padding(2);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(71, 33);
            this.BackButton.TabIndex = 26;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // ProductPrintForm
            // 
            this.ProductPrintForm.DocumentName = "document";
            this.ProductPrintForm.Form = this;
            this.ProductPrintForm.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter;
            this.ProductPrintForm.PrinterSettings = ((System.Drawing.Printing.PrinterSettings)(resources.GetObject("ProductPrintForm.PrinterSettings")));
            this.ProductPrintForm.PrintFileName = null;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::COMP123_S2019_Assignment5.Properties.Resources.projectbackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 511);
            this.ControlBox = false;
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.FinishButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.PriceGroupBox);
            this.Controls.Add(this.SystemComponentsGroupBox);
            this.Controls.Add(this.OrderFormMenuStrip);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order Your Computer";
            this.Activated += new System.EventHandler(this.OrderForm_Activated);
            this.OrderFormMenuStrip.ResumeLayout(false);
            this.OrderFormMenuStrip.PerformLayout();
            this.SystemComponentsGroupBox.ResumeLayout(false);
            this.SystemComponentsGroupBox.PerformLayout();
            this.PriceGroupBox.ResumeLayout(false);
            this.PriceGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip OrderFormMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox SystemComponentsGroupBox;
        private System.Windows.Forms.TextBox ModelTextBox;
        private System.Windows.Forms.TextBox PlatformTextBox;
        private System.Windows.Forms.TextBox ManufacturerTextBox;
        private System.Windows.Forms.TextBox ConditionTextBox;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.Label PlatformLabel;
        private System.Windows.Forms.Label ManufacturerLabel;
        private System.Windows.Forms.Label ConditionLabel;
        private System.Windows.Forms.TextBox WebCamTextBox;
        private System.Windows.Forms.Label WebCamLabel;
        private System.Windows.Forms.TextBox GPUTypeTextBox;
        private System.Windows.Forms.Label GPUTypeLabel;
        private System.Windows.Forms.TextBox HDDTextBox;
        private System.Windows.Forms.TextBox CPUSpeedTextBox;
        private System.Windows.Forms.Label HDDLabel;
        private System.Windows.Forms.Label CPUSpeedLabel;
        private System.Windows.Forms.TextBox CPUTypeTextBox;
        private System.Windows.Forms.Label CPUTypeLabel;
        private System.Windows.Forms.TextBox CPUNumberTextBox;
        private System.Windows.Forms.TextBox LCDSizeTextBox;
        private System.Windows.Forms.TextBox MemoryTextBox;
        private System.Windows.Forms.Label CPUNumberLabel;
        private System.Windows.Forms.Label LCDSizeLabel;
        private System.Windows.Forms.Label MemoryLabel;
        private System.Windows.Forms.TextBox CPUBrandTextBox;
        private System.Windows.Forms.Label CPUBrandLabel;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape SystemComponentslineShape;
        private System.Windows.Forms.Label OSLabel;
        private System.Windows.Forms.TextBox OSTextBox;
        private System.Windows.Forms.GroupBox PriceGroupBox;
        private System.Windows.Forms.TextBox TotalTextBox;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.TextBox SalesTaxTextBox;
        private System.Windows.Forms.Label SalesTaxLabel;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.Label PriceLabel;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Button FinishButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button BackButton;
        private Microsoft.VisualBasic.PowerPacks.Printing.PrintForm ProductPrintForm;
    }
}
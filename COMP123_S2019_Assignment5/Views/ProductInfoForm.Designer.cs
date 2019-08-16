namespace COMP123_S2019_Assignment5.Views
{
    partial class ProductInfoForm
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
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectedProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductIDLabel = new System.Windows.Forms.Label();
            this.ConditionLabel = new System.Windows.Forms.Label();
            this.CostLabel = new System.Windows.Forms.Label();
            this.ProductIDTextBox = new System.Windows.Forms.TextBox();
            this.ConditionTextBox = new System.Windows.Forms.TextBox();
            this.CostTextBox = new System.Windows.Forms.TextBox();
            this.ProductInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.ModelTextBox = new System.Windows.Forms.TextBox();
            this.OSTextBox = new System.Windows.Forms.TextBox();
            this.ManufacturerTextBox = new System.Windows.Forms.TextBox();
            this.PlatformTextBox = new System.Windows.Forms.TextBox();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.OSLabel = new System.Windows.Forms.Label();
            this.ManufacturerLabel = new System.Windows.Forms.Label();
            this.PlatformLabel = new System.Windows.Forms.Label();
            this.ConfigurationGroupBox = new System.Windows.Forms.GroupBox();
            this.WebCamTextBox = new System.Windows.Forms.TextBox();
            this.WebCamLabel = new System.Windows.Forms.Label();
            this.GPUTypeTextBox = new System.Windows.Forms.TextBox();
            this.GPUTypeLabel = new System.Windows.Forms.Label();
            this.HDDTextBox = new System.Windows.Forms.TextBox();
            this.CPUSpeedTextBox = new System.Windows.Forms.TextBox();
            this.HDDLabel = new System.Windows.Forms.Label();
            this.CPUSpeedLabel = new System.Windows.Forms.Label();
            this.CPUTypeTextBox = new System.Windows.Forms.TextBox();
            this.CPUTypeLabel = new System.Windows.Forms.Label();
            this.CPUNumberTextBox = new System.Windows.Forms.TextBox();
            this.LCDSizeTextBox = new System.Windows.Forms.TextBox();
            this.CPUBrandTextBox = new System.Windows.Forms.TextBox();
            this.MemoryTextBox = new System.Windows.Forms.TextBox();
            this.CPUNumberLabel = new System.Windows.Forms.Label();
            this.LCDSizeLabel = new System.Windows.Forms.Label();
            this.CPUBrandLabel = new System.Windows.Forms.Label();
            this.MemoryLabel = new System.Windows.Forms.Label();
            this.NextButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.ChooseAnotherProductButton = new System.Windows.Forms.Button();
            this.SelectedProductOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SelectedProductSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.MenuStrip.SuspendLayout();
            this.ProductInfoGroupBox.SuspendLayout();
            this.ConfigurationGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.BackColor = System.Drawing.Color.Transparent;
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.MenuStrip.Size = new System.Drawing.Size(784, 24);
            this.MenuStrip.TabIndex = 0;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
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
            this.selectedProductToolStripMenuItem});
            this.editToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 22);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // selectedProductToolStripMenuItem
            // 
            this.selectedProductToolStripMenuItem.Name = "selectedProductToolStripMenuItem";
            this.selectedProductToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.selectedProductToolStripMenuItem.Text = "Selected Product";
            this.selectedProductToolStripMenuItem.Click += new System.EventHandler(this.ChooseAnotherProductButton_Click);
            // 
            // ProductIDLabel
            // 
            this.ProductIDLabel.AutoSize = true;
            this.ProductIDLabel.BackColor = System.Drawing.Color.Transparent;
            this.ProductIDLabel.ForeColor = System.Drawing.Color.White;
            this.ProductIDLabel.Location = new System.Drawing.Point(27, 33);
            this.ProductIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ProductIDLabel.Name = "ProductIDLabel";
            this.ProductIDLabel.Size = new System.Drawing.Size(85, 20);
            this.ProductIDLabel.TabIndex = 1;
            this.ProductIDLabel.Text = "Product ID";
            // 
            // ConditionLabel
            // 
            this.ConditionLabel.AutoSize = true;
            this.ConditionLabel.BackColor = System.Drawing.Color.Transparent;
            this.ConditionLabel.ForeColor = System.Drawing.Color.White;
            this.ConditionLabel.Location = new System.Drawing.Point(281, 33);
            this.ConditionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ConditionLabel.Name = "ConditionLabel";
            this.ConditionLabel.Size = new System.Drawing.Size(76, 20);
            this.ConditionLabel.TabIndex = 2;
            this.ConditionLabel.Text = "Condition";
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.BackColor = System.Drawing.Color.Transparent;
            this.CostLabel.ForeColor = System.Drawing.Color.White;
            this.CostLabel.Location = new System.Drawing.Point(486, 39);
            this.CostLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(42, 20);
            this.CostLabel.TabIndex = 3;
            this.CostLabel.Text = "Cost";
            // 
            // ProductIDTextBox
            // 
            this.ProductIDTextBox.Enabled = false;
            this.ProductIDTextBox.Location = new System.Drawing.Point(116, 33);
            this.ProductIDTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.ProductIDTextBox.Name = "ProductIDTextBox";
            this.ProductIDTextBox.Size = new System.Drawing.Size(82, 26);
            this.ProductIDTextBox.TabIndex = 4;
            // 
            // ConditionTextBox
            // 
            this.ConditionTextBox.Enabled = false;
            this.ConditionTextBox.Location = new System.Drawing.Point(361, 30);
            this.ConditionTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.ConditionTextBox.Name = "ConditionTextBox";
            this.ConditionTextBox.Size = new System.Drawing.Size(82, 26);
            this.ConditionTextBox.TabIndex = 5;
            // 
            // CostTextBox
            // 
            this.CostTextBox.Enabled = false;
            this.CostTextBox.Location = new System.Drawing.Point(544, 36);
            this.CostTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.CostTextBox.Name = "CostTextBox";
            this.CostTextBox.Size = new System.Drawing.Size(82, 26);
            this.CostTextBox.TabIndex = 6;
            // 
            // ProductInfoGroupBox
            // 
            this.ProductInfoGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.ProductInfoGroupBox.Controls.Add(this.ModelTextBox);
            this.ProductInfoGroupBox.Controls.Add(this.OSTextBox);
            this.ProductInfoGroupBox.Controls.Add(this.ManufacturerTextBox);
            this.ProductInfoGroupBox.Controls.Add(this.PlatformTextBox);
            this.ProductInfoGroupBox.Controls.Add(this.ModelLabel);
            this.ProductInfoGroupBox.Controls.Add(this.OSLabel);
            this.ProductInfoGroupBox.Controls.Add(this.ManufacturerLabel);
            this.ProductInfoGroupBox.Controls.Add(this.PlatformLabel);
            this.ProductInfoGroupBox.ForeColor = System.Drawing.Color.White;
            this.ProductInfoGroupBox.Location = new System.Drawing.Point(11, 68);
            this.ProductInfoGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.ProductInfoGroupBox.Name = "ProductInfoGroupBox";
            this.ProductInfoGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.ProductInfoGroupBox.Size = new System.Drawing.Size(750, 106);
            this.ProductInfoGroupBox.TabIndex = 7;
            this.ProductInfoGroupBox.TabStop = false;
            this.ProductInfoGroupBox.Text = "Product Info";
            // 
            // ModelTextBox
            // 
            this.ModelTextBox.Enabled = false;
            this.ModelTextBox.Location = new System.Drawing.Point(350, 64);
            this.ModelTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.ModelTextBox.Name = "ModelTextBox";
            this.ModelTextBox.Size = new System.Drawing.Size(181, 26);
            this.ModelTextBox.TabIndex = 8;
            // 
            // OSTextBox
            // 
            this.OSTextBox.Enabled = false;
            this.OSTextBox.Location = new System.Drawing.Point(350, 30);
            this.OSTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.OSTextBox.Name = "OSTextBox";
            this.OSTextBox.Size = new System.Drawing.Size(181, 26);
            this.OSTextBox.TabIndex = 9;
            // 
            // ManufacturerTextBox
            // 
            this.ManufacturerTextBox.Enabled = false;
            this.ManufacturerTextBox.Location = new System.Drawing.Point(105, 61);
            this.ManufacturerTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.ManufacturerTextBox.Name = "ManufacturerTextBox";
            this.ManufacturerTextBox.Size = new System.Drawing.Size(82, 26);
            this.ManufacturerTextBox.TabIndex = 10;
            // 
            // PlatformTextBox
            // 
            this.PlatformTextBox.Enabled = false;
            this.PlatformTextBox.Location = new System.Drawing.Point(105, 26);
            this.PlatformTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.PlatformTextBox.Name = "PlatformTextBox";
            this.PlatformTextBox.Size = new System.Drawing.Size(82, 26);
            this.PlatformTextBox.TabIndex = 11;
            // 
            // ModelLabel
            // 
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.BackColor = System.Drawing.Color.Transparent;
            this.ModelLabel.Location = new System.Drawing.Point(294, 67);
            this.ModelLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(52, 20);
            this.ModelLabel.TabIndex = 8;
            this.ModelLabel.Text = "Model";
            // 
            // OSLabel
            // 
            this.OSLabel.AutoSize = true;
            this.OSLabel.BackColor = System.Drawing.Color.Transparent;
            this.OSLabel.ForeColor = System.Drawing.Color.White;
            this.OSLabel.Location = new System.Drawing.Point(315, 32);
            this.OSLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.OSLabel.Name = "OSLabel";
            this.OSLabel.Size = new System.Drawing.Size(32, 20);
            this.OSLabel.TabIndex = 9;
            this.OSLabel.Text = "OS";
            // 
            // ManufacturerLabel
            // 
            this.ManufacturerLabel.AutoSize = true;
            this.ManufacturerLabel.BackColor = System.Drawing.Color.Transparent;
            this.ManufacturerLabel.Location = new System.Drawing.Point(-3, 63);
            this.ManufacturerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ManufacturerLabel.Name = "ManufacturerLabel";
            this.ManufacturerLabel.Size = new System.Drawing.Size(104, 20);
            this.ManufacturerLabel.TabIndex = 10;
            this.ManufacturerLabel.Text = "Manufacturer";
            // 
            // PlatformLabel
            // 
            this.PlatformLabel.AutoSize = true;
            this.PlatformLabel.BackColor = System.Drawing.Color.Transparent;
            this.PlatformLabel.Location = new System.Drawing.Point(36, 30);
            this.PlatformLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PlatformLabel.Name = "PlatformLabel";
            this.PlatformLabel.Size = new System.Drawing.Size(68, 20);
            this.PlatformLabel.TabIndex = 11;
            this.PlatformLabel.Text = "Platform";
            // 
            // ConfigurationGroupBox
            // 
            this.ConfigurationGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.ConfigurationGroupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ConfigurationGroupBox.Controls.Add(this.WebCamTextBox);
            this.ConfigurationGroupBox.Controls.Add(this.WebCamLabel);
            this.ConfigurationGroupBox.Controls.Add(this.GPUTypeTextBox);
            this.ConfigurationGroupBox.Controls.Add(this.GPUTypeLabel);
            this.ConfigurationGroupBox.Controls.Add(this.HDDTextBox);
            this.ConfigurationGroupBox.Controls.Add(this.CPUSpeedTextBox);
            this.ConfigurationGroupBox.Controls.Add(this.HDDLabel);
            this.ConfigurationGroupBox.Controls.Add(this.CPUSpeedLabel);
            this.ConfigurationGroupBox.Controls.Add(this.CPUTypeTextBox);
            this.ConfigurationGroupBox.Controls.Add(this.CPUTypeLabel);
            this.ConfigurationGroupBox.Controls.Add(this.CPUNumberTextBox);
            this.ConfigurationGroupBox.Controls.Add(this.LCDSizeTextBox);
            this.ConfigurationGroupBox.Controls.Add(this.CPUBrandTextBox);
            this.ConfigurationGroupBox.Controls.Add(this.MemoryTextBox);
            this.ConfigurationGroupBox.Controls.Add(this.CPUNumberLabel);
            this.ConfigurationGroupBox.Controls.Add(this.LCDSizeLabel);
            this.ConfigurationGroupBox.Controls.Add(this.CPUBrandLabel);
            this.ConfigurationGroupBox.Controls.Add(this.MemoryLabel);
            this.ConfigurationGroupBox.ForeColor = System.Drawing.Color.White;
            this.ConfigurationGroupBox.Location = new System.Drawing.Point(8, 178);
            this.ConfigurationGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.ConfigurationGroupBox.Name = "ConfigurationGroupBox";
            this.ConfigurationGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.ConfigurationGroupBox.Size = new System.Drawing.Size(753, 172);
            this.ConfigurationGroupBox.TabIndex = 12;
            this.ConfigurationGroupBox.TabStop = false;
            this.ConfigurationGroupBox.Text = "Configuration";
            // 
            // WebCamTextBox
            // 
            this.WebCamTextBox.Enabled = false;
            this.WebCamTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.WebCamTextBox.Location = new System.Drawing.Point(536, 103);
            this.WebCamTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.WebCamTextBox.Name = "WebCamTextBox";
            this.WebCamTextBox.Size = new System.Drawing.Size(198, 26);
            this.WebCamTextBox.TabIndex = 20;
            // 
            // WebCamLabel
            // 
            this.WebCamLabel.AutoSize = true;
            this.WebCamLabel.Location = new System.Drawing.Point(459, 105);
            this.WebCamLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WebCamLabel.Name = "WebCamLabel";
            this.WebCamLabel.Size = new System.Drawing.Size(75, 20);
            this.WebCamLabel.TabIndex = 21;
            this.WebCamLabel.Text = "WebCam";
            // 
            // GPUTypeTextBox
            // 
            this.GPUTypeTextBox.Enabled = false;
            this.GPUTypeTextBox.Location = new System.Drawing.Point(536, 67);
            this.GPUTypeTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.GPUTypeTextBox.Name = "GPUTypeTextBox";
            this.GPUTypeTextBox.Size = new System.Drawing.Size(198, 26);
            this.GPUTypeTextBox.TabIndex = 18;
            // 
            // GPUTypeLabel
            // 
            this.GPUTypeLabel.AutoSize = true;
            this.GPUTypeLabel.Location = new System.Drawing.Point(452, 70);
            this.GPUTypeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GPUTypeLabel.Name = "GPUTypeLabel";
            this.GPUTypeLabel.Size = new System.Drawing.Size(82, 20);
            this.GPUTypeLabel.TabIndex = 19;
            this.GPUTypeLabel.Text = "GPU Type";
            // 
            // HDDTextBox
            // 
            this.HDDTextBox.Enabled = false;
            this.HDDTextBox.Location = new System.Drawing.Point(536, 31);
            this.HDDTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.HDDTextBox.Name = "HDDTextBox";
            this.HDDTextBox.Size = new System.Drawing.Size(198, 26);
            this.HDDTextBox.TabIndex = 14;
            // 
            // CPUSpeedTextBox
            // 
            this.CPUSpeedTextBox.Enabled = false;
            this.CPUSpeedTextBox.Location = new System.Drawing.Point(354, 98);
            this.CPUSpeedTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.CPUSpeedTextBox.Name = "CPUSpeedTextBox";
            this.CPUSpeedTextBox.Size = new System.Drawing.Size(82, 26);
            this.CPUSpeedTextBox.TabIndex = 16;
            // 
            // HDDLabel
            // 
            this.HDDLabel.AutoSize = true;
            this.HDDLabel.ForeColor = System.Drawing.Color.White;
            this.HDDLabel.Location = new System.Drawing.Point(487, 34);
            this.HDDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HDDLabel.Name = "HDDLabel";
            this.HDDLabel.Size = new System.Drawing.Size(45, 20);
            this.HDDLabel.TabIndex = 15;
            this.HDDLabel.Text = "HDD";
            // 
            // CPUSpeedLabel
            // 
            this.CPUSpeedLabel.AutoSize = true;
            this.CPUSpeedLabel.Location = new System.Drawing.Point(259, 100);
            this.CPUSpeedLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CPUSpeedLabel.Name = "CPUSpeedLabel";
            this.CPUSpeedLabel.Size = new System.Drawing.Size(93, 20);
            this.CPUSpeedLabel.TabIndex = 17;
            this.CPUSpeedLabel.Text = "CPU Speed";
            // 
            // CPUTypeTextBox
            // 
            this.CPUTypeTextBox.Enabled = false;
            this.CPUTypeTextBox.Location = new System.Drawing.Point(105, 99);
            this.CPUTypeTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.CPUTypeTextBox.Name = "CPUTypeTextBox";
            this.CPUTypeTextBox.Size = new System.Drawing.Size(128, 26);
            this.CPUTypeTextBox.TabIndex = 13;
            // 
            // CPUTypeLabel
            // 
            this.CPUTypeLabel.AutoSize = true;
            this.CPUTypeLabel.Location = new System.Drawing.Point(21, 101);
            this.CPUTypeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CPUTypeLabel.Name = "CPUTypeLabel";
            this.CPUTypeLabel.Size = new System.Drawing.Size(80, 20);
            this.CPUTypeLabel.TabIndex = 12;
            this.CPUTypeLabel.Text = "CPU Type";
            // 
            // CPUNumberTextBox
            // 
            this.CPUNumberTextBox.Enabled = false;
            this.CPUNumberTextBox.Location = new System.Drawing.Point(354, 64);
            this.CPUNumberTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.CPUNumberTextBox.Name = "CPUNumberTextBox";
            this.CPUNumberTextBox.Size = new System.Drawing.Size(82, 26);
            this.CPUNumberTextBox.TabIndex = 8;
            // 
            // LCDSizeTextBox
            // 
            this.LCDSizeTextBox.Enabled = false;
            this.LCDSizeTextBox.Location = new System.Drawing.Point(354, 29);
            this.LCDSizeTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.LCDSizeTextBox.Name = "LCDSizeTextBox";
            this.LCDSizeTextBox.Size = new System.Drawing.Size(82, 26);
            this.LCDSizeTextBox.TabIndex = 9;
            // 
            // CPUBrandTextBox
            // 
            this.CPUBrandTextBox.Enabled = false;
            this.CPUBrandTextBox.Location = new System.Drawing.Point(105, 63);
            this.CPUBrandTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.CPUBrandTextBox.Name = "CPUBrandTextBox";
            this.CPUBrandTextBox.Size = new System.Drawing.Size(128, 26);
            this.CPUBrandTextBox.TabIndex = 10;
            // 
            // MemoryTextBox
            // 
            this.MemoryTextBox.Enabled = false;
            this.MemoryTextBox.Location = new System.Drawing.Point(105, 28);
            this.MemoryTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.MemoryTextBox.Name = "MemoryTextBox";
            this.MemoryTextBox.Size = new System.Drawing.Size(128, 26);
            this.MemoryTextBox.TabIndex = 11;
            // 
            // CPUNumberLabel
            // 
            this.CPUNumberLabel.AutoSize = true;
            this.CPUNumberLabel.Location = new System.Drawing.Point(249, 64);
            this.CPUNumberLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CPUNumberLabel.Name = "CPUNumberLabel";
            this.CPUNumberLabel.Size = new System.Drawing.Size(102, 20);
            this.CPUNumberLabel.TabIndex = 8;
            this.CPUNumberLabel.Text = "CPU Number";
            // 
            // LCDSizeLabel
            // 
            this.LCDSizeLabel.AutoSize = true;
            this.LCDSizeLabel.Location = new System.Drawing.Point(274, 31);
            this.LCDSizeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LCDSizeLabel.Name = "LCDSizeLabel";
            this.LCDSizeLabel.Size = new System.Drawing.Size(76, 20);
            this.LCDSizeLabel.TabIndex = 9;
            this.LCDSizeLabel.Text = "LCD Size";
            // 
            // CPUBrandLabel
            // 
            this.CPUBrandLabel.AutoSize = true;
            this.CPUBrandLabel.Location = new System.Drawing.Point(12, 64);
            this.CPUBrandLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CPUBrandLabel.Name = "CPUBrandLabel";
            this.CPUBrandLabel.Size = new System.Drawing.Size(89, 20);
            this.CPUBrandLabel.TabIndex = 10;
            this.CPUBrandLabel.Text = "CPU Brand";
            // 
            // MemoryLabel
            // 
            this.MemoryLabel.AutoSize = true;
            this.MemoryLabel.Location = new System.Drawing.Point(36, 28);
            this.MemoryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MemoryLabel.Name = "MemoryLabel";
            this.MemoryLabel.Size = new System.Drawing.Size(65, 20);
            this.MemoryLabel.TabIndex = 11;
            this.MemoryLabel.Text = "Memory";
            // 
            // NextButton
            // 
            this.NextButton.BackColor = System.Drawing.Color.Transparent;
            this.NextButton.Location = new System.Drawing.Point(700, 417);
            this.NextButton.Margin = new System.Windows.Forms.Padding(2);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(61, 33);
            this.NextButton.TabIndex = 23;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = false;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.Transparent;
            this.CancelButton.Location = new System.Drawing.Point(598, 417);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(2);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(71, 33);
            this.CancelButton.TabIndex = 22;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ChooseAnotherProductButton
            // 
            this.ChooseAnotherProductButton.BackColor = System.Drawing.Color.Transparent;
            this.ChooseAnotherProductButton.Location = new System.Drawing.Point(341, 417);
            this.ChooseAnotherProductButton.Margin = new System.Windows.Forms.Padding(2);
            this.ChooseAnotherProductButton.Name = "ChooseAnotherProductButton";
            this.ChooseAnotherProductButton.Size = new System.Drawing.Size(199, 33);
            this.ChooseAnotherProductButton.TabIndex = 24;
            this.ChooseAnotherProductButton.Text = "Choose Another Product";
            this.ChooseAnotherProductButton.UseVisualStyleBackColor = false;
            this.ChooseAnotherProductButton.Click += new System.EventHandler(this.ChooseAnotherProductButton_Click);
            // 
            // SelectedProductOpenFileDialog
            // 
            this.SelectedProductOpenFileDialog.FileName = "openFileDialog1";
            // 
            // ProductInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::COMP123_S2019_Assignment5.Properties.Resources.projectbackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.ControlBox = false;
            this.Controls.Add(this.ChooseAnotherProductButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.ConfigurationGroupBox);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.ProductInfoGroupBox);
            this.Controls.Add(this.CostTextBox);
            this.Controls.Add(this.ConditionTextBox);
            this.Controls.Add(this.ProductIDTextBox);
            this.Controls.Add(this.CostLabel);
            this.Controls.Add(this.ConditionLabel);
            this.Controls.Add(this.ProductIDLabel);
            this.Controls.Add(this.MenuStrip);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.MenuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "ProductInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Info Form";
            this.Activated += new System.EventHandler(this.ProductInfoForm_Activated);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ProductInfoGroupBox.ResumeLayout(false);
            this.ProductInfoGroupBox.PerformLayout();
            this.ConfigurationGroupBox.ResumeLayout(false);
            this.ConfigurationGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectedProductToolStripMenuItem;
        private System.Windows.Forms.Label ProductIDLabel;
        private System.Windows.Forms.Label ConditionLabel;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.TextBox ProductIDTextBox;
        private System.Windows.Forms.TextBox ConditionTextBox;
        private System.Windows.Forms.TextBox CostTextBox;
        private System.Windows.Forms.GroupBox ProductInfoGroupBox;
        private System.Windows.Forms.TextBox ModelTextBox;
        private System.Windows.Forms.TextBox OSTextBox;
        private System.Windows.Forms.TextBox ManufacturerTextBox;
        private System.Windows.Forms.TextBox PlatformTextBox;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.Label OSLabel;
        private System.Windows.Forms.Label ManufacturerLabel;
        private System.Windows.Forms.Label PlatformLabel;
        private System.Windows.Forms.GroupBox ConfigurationGroupBox;
        private System.Windows.Forms.TextBox CPUNumberTextBox;
        private System.Windows.Forms.TextBox LCDSizeTextBox;
        private System.Windows.Forms.TextBox CPUBrandTextBox;
        private System.Windows.Forms.TextBox MemoryTextBox;
        private System.Windows.Forms.Label CPUNumberLabel;
        private System.Windows.Forms.Label LCDSizeLabel;
        private System.Windows.Forms.Label CPUBrandLabel;
        private System.Windows.Forms.Label MemoryLabel;
        private System.Windows.Forms.Label CPUTypeLabel;
        private System.Windows.Forms.TextBox HDDTextBox;
        private System.Windows.Forms.TextBox CPUSpeedTextBox;
        private System.Windows.Forms.Label HDDLabel;
        private System.Windows.Forms.Label CPUSpeedLabel;
        private System.Windows.Forms.TextBox CPUTypeTextBox;
        private System.Windows.Forms.TextBox WebCamTextBox;
        private System.Windows.Forms.Label WebCamLabel;
        private System.Windows.Forms.TextBox GPUTypeTextBox;
        private System.Windows.Forms.Label GPUTypeLabel;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button ChooseAnotherProductButton;
        private System.Windows.Forms.OpenFileDialog SelectedProductOpenFileDialog;
        private System.Windows.Forms.SaveFileDialog SelectedProductSaveFileDialog;
    }
}
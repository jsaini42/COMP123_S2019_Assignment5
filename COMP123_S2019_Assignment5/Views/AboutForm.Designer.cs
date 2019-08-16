namespace COMP123_S2019_Assignment5.Views
{
    partial class AboutForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            this.AboutFormLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.labelProgrammerName = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelWebsite = new System.Windows.Forms.Label();
            this.labelContactNumber = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.AboutFormLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // AboutFormLayoutPanel
            // 
            this.AboutFormLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.AboutFormLayoutPanel.ColumnCount = 2;
            this.AboutFormLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.AboutFormLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67F));
            this.AboutFormLayoutPanel.Controls.Add(this.logoPictureBox, 0, 0);
            this.AboutFormLayoutPanel.Controls.Add(this.labelProgrammerName, 1, 0);
            this.AboutFormLayoutPanel.Controls.Add(this.labelVersion, 1, 1);
            this.AboutFormLayoutPanel.Controls.Add(this.labelWebsite, 1, 2);
            this.AboutFormLayoutPanel.Controls.Add(this.labelContactNumber, 1, 3);
            this.AboutFormLayoutPanel.Controls.Add(this.okButton, 1, 4);
            this.AboutFormLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AboutFormLayoutPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AboutFormLayoutPanel.ForeColor = System.Drawing.Color.White;
            this.AboutFormLayoutPanel.Location = new System.Drawing.Point(9, 9);
            this.AboutFormLayoutPanel.Name = "AboutFormLayoutPanel";
            this.AboutFormLayoutPanel.RowCount = 5;
            this.AboutFormLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.AboutFormLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.AboutFormLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.AboutFormLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.AboutFormLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.AboutFormLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.AboutFormLayoutPanel.Size = new System.Drawing.Size(417, 265);
            this.AboutFormLayoutPanel.TabIndex = 0;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logoPictureBox.Image = global::COMP123_S2019_Assignment5.Properties.Resources.aboutlogo1;
            this.logoPictureBox.Location = new System.Drawing.Point(3, 3);
            this.logoPictureBox.Name = "logoPictureBox";
            this.AboutFormLayoutPanel.SetRowSpan(this.logoPictureBox, 5);
            this.logoPictureBox.Size = new System.Drawing.Size(131, 259);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPictureBox.TabIndex = 12;
            this.logoPictureBox.TabStop = false;
            // 
            // labelProgrammerName
            // 
            this.labelProgrammerName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelProgrammerName.Location = new System.Drawing.Point(143, 0);
            this.labelProgrammerName.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.labelProgrammerName.MaximumSize = new System.Drawing.Size(0, 17);
            this.labelProgrammerName.Name = "labelProgrammerName";
            this.labelProgrammerName.Size = new System.Drawing.Size(271, 17);
            this.labelProgrammerName.TabIndex = 19;
            this.labelProgrammerName.Text = "Programmer\'s Name";
            this.labelProgrammerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelVersion
            // 
            this.labelVersion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelVersion.Location = new System.Drawing.Point(143, 53);
            this.labelVersion.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.labelVersion.MaximumSize = new System.Drawing.Size(0, 17);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(271, 17);
            this.labelVersion.TabIndex = 0;
            this.labelVersion.Text = "Version";
            this.labelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelWebsite
            // 
            this.labelWebsite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelWebsite.Location = new System.Drawing.Point(143, 106);
            this.labelWebsite.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.labelWebsite.MaximumSize = new System.Drawing.Size(0, 17);
            this.labelWebsite.Name = "labelWebsite";
            this.labelWebsite.Size = new System.Drawing.Size(271, 17);
            this.labelWebsite.TabIndex = 21;
            this.labelWebsite.Text = "Website";
            this.labelWebsite.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelContactNumber
            // 
            this.labelContactNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelContactNumber.Location = new System.Drawing.Point(143, 159);
            this.labelContactNumber.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.labelContactNumber.MaximumSize = new System.Drawing.Size(0, 17);
            this.labelContactNumber.Name = "labelContactNumber";
            this.labelContactNumber.Size = new System.Drawing.Size(271, 17);
            this.labelContactNumber.TabIndex = 22;
            this.labelContactNumber.Text = "Contact Number";
            this.labelContactNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.okButton.ForeColor = System.Drawing.Color.Black;
            this.okButton.Location = new System.Drawing.Point(339, 230);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 32);
            this.okButton.TabIndex = 24;
            this.okButton.Text = "&OK";
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // AboutForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::COMP123_S2019_Assignment5.Properties.Resources.projectbackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(435, 283);
            this.Controls.Add(this.AboutFormLayoutPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.Padding = new System.Windows.Forms.Padding(9);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AboutBox";
            this.AboutFormLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel AboutFormLayoutPanel;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Label labelProgrammerName;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label labelWebsite;
        private System.Windows.Forms.Label labelContactNumber;
        private System.Windows.Forms.Button okButton;
    }
}

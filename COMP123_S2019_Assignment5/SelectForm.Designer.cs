namespace COMP123_S2019_Assignment5
{
    partial class SelectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectForm));
            this.DisplayLabel = new System.Windows.Forms.Label();
            this.DollarComputersDataGridView = new System.Windows.Forms.DataGridView();
            this.SelectedProductLabel = new System.Windows.Forms.Label();
            this.SelectedProductTextBox = new System.Windows.Forms.TextBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DollarComputersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DisplayLabel
            // 
            this.DisplayLabel.AutoSize = true;
            this.DisplayLabel.Location = new System.Drawing.Point(10, 26);
            this.DisplayLabel.Name = "DisplayLabel";
            this.DisplayLabel.Size = new System.Drawing.Size(323, 29);
            this.DisplayLabel.TabIndex = 0;
            this.DisplayLabel.Text = "Computers Configuration List";
            // 
            // DollarComputersDataGridView
            // 
            this.DollarComputersDataGridView.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DollarComputersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DollarComputersDataGridView.Location = new System.Drawing.Point(16, 72);
            this.DollarComputersDataGridView.Name = "DollarComputersDataGridView";
            this.DollarComputersDataGridView.ReadOnly = true;
            this.DollarComputersDataGridView.Size = new System.Drawing.Size(210, 140);
            this.DollarComputersDataGridView.TabIndex = 1;
            // 
            // SelectedProductLabel
            // 
            this.SelectedProductLabel.AutoSize = true;
            this.SelectedProductLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedProductLabel.Location = new System.Drawing.Point(10, 516);
            this.SelectedProductLabel.Name = "SelectedProductLabel";
            this.SelectedProductLabel.Size = new System.Drawing.Size(198, 29);
            this.SelectedProductLabel.TabIndex = 2;
            this.SelectedProductLabel.Text = "Selected Product";
            // 
            // SelectedProductTextBox
            // 
            this.SelectedProductTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SelectedProductTextBox.Location = new System.Drawing.Point(214, 516);
            this.SelectedProductTextBox.Name = "SelectedProductTextBox";
            this.SelectedProductTextBox.ReadOnly = true;
            this.SelectedProductTextBox.Size = new System.Drawing.Size(300, 35);
            this.SelectedProductTextBox.TabIndex = 3;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(572, 516);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(98, 35);
            this.CancelButton.TabIndex = 4;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(686, 516);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(95, 35);
            this.NextButton.TabIndex = 5;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // SelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.ControlBox = false;
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SelectedProductTextBox);
            this.Controls.Add(this.SelectedProductLabel);
            this.Controls.Add(this.DollarComputersDataGridView);
            this.Controls.Add(this.DisplayLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.MaximizeBox = false;
            this.Name = "SelectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Your Computer";
            ((System.ComponentModel.ISupportInitialize)(this.DollarComputersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DisplayLabel;
        private System.Windows.Forms.DataGridView DollarComputersDataGridView;
        private System.Windows.Forms.Label SelectedProductLabel;
        private System.Windows.Forms.TextBox SelectedProductTextBox;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button NextButton;
    }
}
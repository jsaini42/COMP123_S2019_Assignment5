namespace COMP123_S2019_Assignment5
{
    partial class StartForm
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
            this.DisplayLabel = new System.Windows.Forms.Label();
            this.StartNewOrderButton = new System.Windows.Forms.Button();
            this.LoadSavedOrderButton = new System.Windows.Forms.Button();
            this.ExitProgramButton = new System.Windows.Forms.Button();
            this.logopictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logopictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // DisplayLabel
            // 
            this.DisplayLabel.AutoSize = true;
            this.DisplayLabel.BackColor = System.Drawing.Color.Black;
            this.DisplayLabel.ForeColor = System.Drawing.Color.White;
            this.DisplayLabel.Location = new System.Drawing.Point(41, 26);
            this.DisplayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DisplayLabel.Name = "DisplayLabel";
            this.DisplayLabel.Size = new System.Drawing.Size(200, 20);
            this.DisplayLabel.TabIndex = 0;
            this.DisplayLabel.Text = "Order Your Computer Now!";
            // 
            // StartNewOrderButton
            // 
            this.StartNewOrderButton.BackColor = System.Drawing.SystemColors.Control;
            this.StartNewOrderButton.Location = new System.Drawing.Point(67, 216);
            this.StartNewOrderButton.Margin = new System.Windows.Forms.Padding(2);
            this.StartNewOrderButton.Name = "StartNewOrderButton";
            this.StartNewOrderButton.Size = new System.Drawing.Size(153, 31);
            this.StartNewOrderButton.TabIndex = 1;
            this.StartNewOrderButton.Text = "Start New Order";
            this.StartNewOrderButton.UseVisualStyleBackColor = false;
            this.StartNewOrderButton.Click += new System.EventHandler(this.StartNewOrderButton_Click);
            // 
            // LoadSavedOrderButton
            // 
            this.LoadSavedOrderButton.Location = new System.Drawing.Point(67, 270);
            this.LoadSavedOrderButton.Margin = new System.Windows.Forms.Padding(2);
            this.LoadSavedOrderButton.Name = "LoadSavedOrderButton";
            this.LoadSavedOrderButton.Size = new System.Drawing.Size(153, 31);
            this.LoadSavedOrderButton.TabIndex = 2;
            this.LoadSavedOrderButton.Text = "View Saved Order";
            this.LoadSavedOrderButton.UseVisualStyleBackColor = true;
            this.LoadSavedOrderButton.Click += new System.EventHandler(this.LoadSavedOrderButton_Click);
            // 
            // ExitProgramButton
            // 
            this.ExitProgramButton.Location = new System.Drawing.Point(67, 326);
            this.ExitProgramButton.Margin = new System.Windows.Forms.Padding(2);
            this.ExitProgramButton.Name = "ExitProgramButton";
            this.ExitProgramButton.Size = new System.Drawing.Size(153, 31);
            this.ExitProgramButton.TabIndex = 3;
            this.ExitProgramButton.Text = "Exit Now!";
            this.ExitProgramButton.UseVisualStyleBackColor = true;
            this.ExitProgramButton.Click += new System.EventHandler(this.ExitProgramButton_Click);
            // 
            // logopictureBox
            // 
            this.logopictureBox.Image = global::COMP123_S2019_Assignment5.Properties.Resources.logostartform;
            this.logopictureBox.Location = new System.Drawing.Point(45, 66);
            this.logopictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.logopictureBox.Name = "logopictureBox";
            this.logopictureBox.Size = new System.Drawing.Size(196, 119);
            this.logopictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.logopictureBox.TabIndex = 4;
            this.logopictureBox.TabStop = false;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::COMP123_S2019_Assignment5.Properties.Resources.projectbackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(304, 461);
            this.ControlBox = false;
            this.Controls.Add(this.logopictureBox);
            this.Controls.Add(this.ExitProgramButton);
            this.Controls.Add(this.LoadSavedOrderButton);
            this.Controls.Add(this.StartNewOrderButton);
            this.Controls.Add(this.DisplayLabel);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimizeBox = false;
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome to Dollar Computers!!";
            ((System.ComponentModel.ISupportInitialize)(this.logopictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DisplayLabel;
        private System.Windows.Forms.Button StartNewOrderButton;
        private System.Windows.Forms.Button LoadSavedOrderButton;
        private System.Windows.Forms.Button ExitProgramButton;
        private System.Windows.Forms.PictureBox logopictureBox;
    }
}


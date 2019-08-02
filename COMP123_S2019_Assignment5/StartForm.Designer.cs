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
            this.DisplayLabel.Location = new System.Drawing.Point(17, 30);
            this.DisplayLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.DisplayLabel.Name = "DisplayLabel";
            this.DisplayLabel.Size = new System.Drawing.Size(343, 31);
            this.DisplayLabel.TabIndex = 0;
            this.DisplayLabel.Text = "Order Your Computer Now!";
            // 
            // StartNewOrderButton
            // 
            this.StartNewOrderButton.Location = new System.Drawing.Point(60, 241);
            this.StartNewOrderButton.Name = "StartNewOrderButton";
            this.StartNewOrderButton.Size = new System.Drawing.Size(254, 48);
            this.StartNewOrderButton.TabIndex = 1;
            this.StartNewOrderButton.Text = "Start New Order";
            this.StartNewOrderButton.UseVisualStyleBackColor = true;
            // 
            // LoadSavedOrderButton
            // 
            this.LoadSavedOrderButton.Location = new System.Drawing.Point(60, 306);
            this.LoadSavedOrderButton.Name = "LoadSavedOrderButton";
            this.LoadSavedOrderButton.Size = new System.Drawing.Size(254, 48);
            this.LoadSavedOrderButton.TabIndex = 2;
            this.LoadSavedOrderButton.Text = "Load Saved Order";
            this.LoadSavedOrderButton.UseVisualStyleBackColor = true;
            // 
            // ExitProgramButton
            // 
            this.ExitProgramButton.Location = new System.Drawing.Point(60, 371);
            this.ExitProgramButton.Name = "ExitProgramButton";
            this.ExitProgramButton.Size = new System.Drawing.Size(254, 48);
            this.ExitProgramButton.TabIndex = 3;
            this.ExitProgramButton.Text = "Exit Now!";
            this.ExitProgramButton.UseVisualStyleBackColor = true;
            // 
            // logopictureBox
            // 
            this.logopictureBox.Image = global::COMP123_S2019_Assignment5.Properties.Resources.logostartform;
            this.logopictureBox.Location = new System.Drawing.Point(45, 75);
            this.logopictureBox.Name = "logopictureBox";
            this.logopictureBox.Size = new System.Drawing.Size(279, 149);
            this.logopictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.logopictureBox.TabIndex = 4;
            this.logopictureBox.TabStop = false;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 441);
            this.ControlBox = false;
            this.Controls.Add(this.logopictureBox);
            this.Controls.Add(this.ExitProgramButton);
            this.Controls.Add(this.LoadSavedOrderButton);
            this.Controls.Add(this.StartNewOrderButton);
            this.Controls.Add(this.DisplayLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MinimizeBox = false;
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome to Dollar Computers!!";
            this.Load += new System.EventHandler(this.StartForm_Load);
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


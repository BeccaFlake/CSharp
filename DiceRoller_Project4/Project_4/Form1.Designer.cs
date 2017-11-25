namespace Project_4
{
    partial class DiceRoller
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
            this.instructionLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.totalOutput = new System.Windows.Forms.Label();
            this.rollButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.pictureBoxR2D6 = new System.Windows.Forms.PictureBox();
            this.pictureBoxR2D5 = new System.Windows.Forms.PictureBox();
            this.pictureBoxR2D4 = new System.Windows.Forms.PictureBox();
            this.pictureBoxR2D3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxR2D2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxR2D1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxR1D6 = new System.Windows.Forms.PictureBox();
            this.pictureBoxR1D5 = new System.Windows.Forms.PictureBox();
            this.pictureBoxR1D4 = new System.Windows.Forms.PictureBox();
            this.pictureBoxR1D3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxR1D2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxR1D1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxR2D6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxR2D5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxR2D4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxR2D3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxR2D2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxR2D1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxR1D6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxR1D5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxR1D4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxR1D3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxR1D2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxR1D1)).BeginInit();
            this.SuspendLayout();
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.Location = new System.Drawing.Point(119, 25);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(146, 13);
            this.instructionLabel.TabIndex = 0;
            this.instructionLabel.Text = "Click the button to roll two D6";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(167, 104);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(55, 13);
            this.totalLabel.TabIndex = 3;
            this.totalLabel.Text = "Total Roll:";
            // 
            // totalOutput
            // 
            this.totalOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalOutput.Location = new System.Drawing.Point(167, 117);
            this.totalOutput.Name = "totalOutput";
            this.totalOutput.Size = new System.Drawing.Size(55, 23);
            this.totalOutput.TabIndex = 4;
            this.totalOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rollButton
            // 
            this.rollButton.Location = new System.Drawing.Point(122, 215);
            this.rollButton.Name = "rollButton";
            this.rollButton.Size = new System.Drawing.Size(50, 23);
            this.rollButton.TabIndex = 5;
            this.rollButton.Text = "Roll";
            this.rollButton.UseVisualStyleBackColor = true;
            this.rollButton.Click += new System.EventHandler(this.rollButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(213, 215);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(52, 23);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // pictureBoxR2D6
            // 
            this.pictureBoxR2D6.Image = global::Project_4.Properties.Resources._6Die;
            this.pictureBoxR2D6.Location = new System.Drawing.Point(249, 65);
            this.pictureBoxR2D6.Name = "pictureBoxR2D6";
            this.pictureBoxR2D6.Size = new System.Drawing.Size(108, 106);
            this.pictureBoxR2D6.TabIndex = 17;
            this.pictureBoxR2D6.TabStop = false;
            this.pictureBoxR2D6.Visible = false;
            // 
            // pictureBoxR2D5
            // 
            this.pictureBoxR2D5.Image = global::Project_4.Properties.Resources._5Die;
            this.pictureBoxR2D5.Location = new System.Drawing.Point(249, 65);
            this.pictureBoxR2D5.Name = "pictureBoxR2D5";
            this.pictureBoxR2D5.Size = new System.Drawing.Size(108, 106);
            this.pictureBoxR2D5.TabIndex = 16;
            this.pictureBoxR2D5.TabStop = false;
            this.pictureBoxR2D5.Visible = false;
            // 
            // pictureBoxR2D4
            // 
            this.pictureBoxR2D4.Image = global::Project_4.Properties.Resources._4Die;
            this.pictureBoxR2D4.Location = new System.Drawing.Point(249, 65);
            this.pictureBoxR2D4.Name = "pictureBoxR2D4";
            this.pictureBoxR2D4.Size = new System.Drawing.Size(108, 106);
            this.pictureBoxR2D4.TabIndex = 15;
            this.pictureBoxR2D4.TabStop = false;
            this.pictureBoxR2D4.Visible = false;
            // 
            // pictureBoxR2D3
            // 
            this.pictureBoxR2D3.Image = global::Project_4.Properties.Resources._3Die;
            this.pictureBoxR2D3.Location = new System.Drawing.Point(249, 65);
            this.pictureBoxR2D3.Name = "pictureBoxR2D3";
            this.pictureBoxR2D3.Size = new System.Drawing.Size(108, 106);
            this.pictureBoxR2D3.TabIndex = 14;
            this.pictureBoxR2D3.TabStop = false;
            this.pictureBoxR2D3.Visible = false;
            // 
            // pictureBoxR2D2
            // 
            this.pictureBoxR2D2.Image = global::Project_4.Properties.Resources._2Die;
            this.pictureBoxR2D2.Location = new System.Drawing.Point(249, 65);
            this.pictureBoxR2D2.Name = "pictureBoxR2D2";
            this.pictureBoxR2D2.Size = new System.Drawing.Size(108, 106);
            this.pictureBoxR2D2.TabIndex = 13;
            this.pictureBoxR2D2.TabStop = false;
            this.pictureBoxR2D2.Visible = false;
            // 
            // pictureBoxR2D1
            // 
            this.pictureBoxR2D1.Image = global::Project_4.Properties.Resources._1Die;
            this.pictureBoxR2D1.Location = new System.Drawing.Point(249, 65);
            this.pictureBoxR2D1.Name = "pictureBoxR2D1";
            this.pictureBoxR2D1.Size = new System.Drawing.Size(108, 106);
            this.pictureBoxR2D1.TabIndex = 12;
            this.pictureBoxR2D1.TabStop = false;
            this.pictureBoxR2D1.Visible = false;
            // 
            // pictureBoxR1D6
            // 
            this.pictureBoxR1D6.Image = global::Project_4.Properties.Resources._6Die;
            this.pictureBoxR1D6.Location = new System.Drawing.Point(32, 68);
            this.pictureBoxR1D6.Name = "pictureBoxR1D6";
            this.pictureBoxR1D6.Size = new System.Drawing.Size(108, 106);
            this.pictureBoxR1D6.TabIndex = 11;
            this.pictureBoxR1D6.TabStop = false;
            this.pictureBoxR1D6.Visible = false;
            // 
            // pictureBoxR1D5
            // 
            this.pictureBoxR1D5.Image = global::Project_4.Properties.Resources._5Die;
            this.pictureBoxR1D5.Location = new System.Drawing.Point(32, 68);
            this.pictureBoxR1D5.Name = "pictureBoxR1D5";
            this.pictureBoxR1D5.Size = new System.Drawing.Size(108, 106);
            this.pictureBoxR1D5.TabIndex = 10;
            this.pictureBoxR1D5.TabStop = false;
            this.pictureBoxR1D5.Visible = false;
            // 
            // pictureBoxR1D4
            // 
            this.pictureBoxR1D4.Image = global::Project_4.Properties.Resources._4Die;
            this.pictureBoxR1D4.Location = new System.Drawing.Point(32, 68);
            this.pictureBoxR1D4.Name = "pictureBoxR1D4";
            this.pictureBoxR1D4.Size = new System.Drawing.Size(108, 106);
            this.pictureBoxR1D4.TabIndex = 9;
            this.pictureBoxR1D4.TabStop = false;
            this.pictureBoxR1D4.Visible = false;
            // 
            // pictureBoxR1D3
            // 
            this.pictureBoxR1D3.Image = global::Project_4.Properties.Resources._3Die;
            this.pictureBoxR1D3.Location = new System.Drawing.Point(32, 68);
            this.pictureBoxR1D3.Name = "pictureBoxR1D3";
            this.pictureBoxR1D3.Size = new System.Drawing.Size(108, 106);
            this.pictureBoxR1D3.TabIndex = 8;
            this.pictureBoxR1D3.TabStop = false;
            this.pictureBoxR1D3.Visible = false;
            // 
            // pictureBoxR1D2
            // 
            this.pictureBoxR1D2.Image = global::Project_4.Properties.Resources._2Die;
            this.pictureBoxR1D2.Location = new System.Drawing.Point(32, 68);
            this.pictureBoxR1D2.Name = "pictureBoxR1D2";
            this.pictureBoxR1D2.Size = new System.Drawing.Size(108, 106);
            this.pictureBoxR1D2.TabIndex = 7;
            this.pictureBoxR1D2.TabStop = false;
            this.pictureBoxR1D2.Visible = false;
            // 
            // pictureBoxR1D1
            // 
            this.pictureBoxR1D1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxR1D1.Image = global::Project_4.Properties.Resources._1Die;
            this.pictureBoxR1D1.Location = new System.Drawing.Point(32, 68);
            this.pictureBoxR1D1.Name = "pictureBoxR1D1";
            this.pictureBoxR1D1.Size = new System.Drawing.Size(108, 106);
            this.pictureBoxR1D1.TabIndex = 1;
            this.pictureBoxR1D1.TabStop = false;
            this.pictureBoxR1D1.Visible = false;
            // 
            // DiceRoller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.pictureBoxR2D6);
            this.Controls.Add(this.pictureBoxR2D5);
            this.Controls.Add(this.pictureBoxR2D4);
            this.Controls.Add(this.pictureBoxR2D3);
            this.Controls.Add(this.pictureBoxR2D2);
            this.Controls.Add(this.pictureBoxR2D1);
            this.Controls.Add(this.pictureBoxR1D5);
            this.Controls.Add(this.pictureBoxR1D4);
            this.Controls.Add(this.pictureBoxR1D3);
            this.Controls.Add(this.pictureBoxR1D2);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.rollButton);
            this.Controls.Add(this.totalOutput);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.pictureBoxR1D1);
            this.Controls.Add(this.instructionLabel);
            this.Controls.Add(this.pictureBoxR1D6);
            this.Name = "DiceRoller";
            this.Text = "Dice Roller";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxR2D6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxR2D5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxR2D4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxR2D3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxR2D2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxR2D1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxR1D6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxR1D5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxR1D4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxR1D3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxR1D2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxR1D1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.PictureBox pictureBoxR1D1;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label totalOutput;
        private System.Windows.Forms.Button rollButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.PictureBox pictureBoxR1D2;
        private System.Windows.Forms.PictureBox pictureBoxR1D3;
        private System.Windows.Forms.PictureBox pictureBoxR1D4;
        private System.Windows.Forms.PictureBox pictureBoxR1D5;
        private System.Windows.Forms.PictureBox pictureBoxR1D6;
        private System.Windows.Forms.PictureBox pictureBoxR2D6;
        private System.Windows.Forms.PictureBox pictureBoxR2D5;
        private System.Windows.Forms.PictureBox pictureBoxR2D4;
        private System.Windows.Forms.PictureBox pictureBoxR2D3;
        private System.Windows.Forms.PictureBox pictureBoxR2D2;
        private System.Windows.Forms.PictureBox pictureBoxR2D1;
    }
}


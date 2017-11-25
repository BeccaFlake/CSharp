namespace Project7
{
    partial class slotMachine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(slotMachine));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.textBoxLabel = new System.Windows.Forms.Label();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.spinButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.fruitImageList = new System.Windows.Forms.ImageList(this.components);
            this.spinResultLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 107);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBox2.Location = new System.Drawing.Point(270, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(114, 107);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBox3.Location = new System.Drawing.Point(141, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(114, 107);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // textBoxLabel
            // 
            this.textBoxLabel.AutoSize = true;
            this.textBoxLabel.Location = new System.Drawing.Point(101, 147);
            this.textBoxLabel.Name = "textBoxLabel";
            this.textBoxLabel.Size = new System.Drawing.Size(96, 13);
            this.textBoxLabel.TabIndex = 3;
            this.textBoxLabel.Text = "Amount Inserted: $";
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(196, 144);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(100, 20);
            this.amountTextBox.TabIndex = 4;
            // 
            // spinButton
            // 
            this.spinButton.Location = new System.Drawing.Point(105, 219);
            this.spinButton.Name = "spinButton";
            this.spinButton.Size = new System.Drawing.Size(75, 23);
            this.spinButton.TabIndex = 5;
            this.spinButton.Text = "Spin";
            this.spinButton.UseVisualStyleBackColor = true;
            this.spinButton.Click += new System.EventHandler(this.spinButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(220, 219);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // fruitImageList
            // 
            this.fruitImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("fruitImageList.ImageStream")));
            this.fruitImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.fruitImageList.Images.SetKeyName(0, "Apple.bmp");
            this.fruitImageList.Images.SetKeyName(1, "Banana.bmp");
            this.fruitImageList.Images.SetKeyName(2, "Cherries.bmp");
            this.fruitImageList.Images.SetKeyName(3, "Grapes.bmp");
            this.fruitImageList.Images.SetKeyName(4, "Lemon.bmp");
            this.fruitImageList.Images.SetKeyName(5, "Lime.bmp");
            this.fruitImageList.Images.SetKeyName(6, "Orange.bmp");
            this.fruitImageList.Images.SetKeyName(7, "Pear.bmp");
            this.fruitImageList.Images.SetKeyName(8, "Strawberry.bmp");
            this.fruitImageList.Images.SetKeyName(9, "Watermelon.bmp");
            // 
            // spinResultLabel
            // 
            this.spinResultLabel.AutoSize = true;
            this.spinResultLabel.Location = new System.Drawing.Point(117, 183);
            this.spinResultLabel.Name = "spinResultLabel";
            this.spinResultLabel.Size = new System.Drawing.Size(73, 13);
            this.spinResultLabel.TabIndex = 7;
            this.spinResultLabel.Text = "Spin Result: $";
            // 
            // resultLabel
            // 
            this.resultLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.resultLabel.Location = new System.Drawing.Point(196, 182);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(99, 20);
            this.resultLabel.TabIndex = 8;
            this.resultLabel.Text = " ";
            // 
            // slotMachine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 252);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.spinResultLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.spinButton);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.textBoxLabel);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "slotMachine";
            this.Text = "Slot Machine";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label textBoxLabel;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.Button spinButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ImageList fruitImageList;
        private System.Windows.Forms.Label spinResultLabel;
        private System.Windows.Forms.Label resultLabel;
    }
}


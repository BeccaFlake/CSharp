namespace Project_3
{
    partial class unitConverter
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
            this.inputLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.fromGroup = new System.Windows.Forms.GroupBox();
            this.fromListBox = new System.Windows.Forms.ListBox();
            this.calculationLabel = new System.Windows.Forms.Label();
            this.unitLabel = new System.Windows.Forms.Label();
            this.toGroup = new System.Windows.Forms.GroupBox();
            this.toListBox = new System.Windows.Forms.ListBox();
            this.fromGroup.SuspendLayout();
            this.toGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.Location = new System.Drawing.Point(36, 30);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(141, 13);
            this.inputLabel.TabIndex = 0;
            this.inputLabel.Text = "Enter a distance to convert: ";
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(49, 207);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(105, 13);
            this.outputLabel.TabIndex = 4;
            this.outputLabel.Text = "Converted distance: ";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(60, 247);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 5;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(232, 247);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(203, 27);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(100, 20);
            this.inputTextBox.TabIndex = 1;
            this.inputTextBox.TextChanged += new System.EventHandler(this.inputTextBox_TextChanged);
            // 
            // fromGroup
            // 
            this.fromGroup.Controls.Add(this.fromListBox);
            this.fromGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromGroup.Location = new System.Drawing.Point(39, 93);
            this.fromGroup.Name = "fromGroup";
            this.fromGroup.Size = new System.Drawing.Size(131, 84);
            this.fromGroup.TabIndex = 2;
            this.fromGroup.TabStop = false;
            this.fromGroup.Text = "From:";
            // 
            // fromListBox
            // 
            this.fromListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromListBox.FormattingEnabled = true;
            this.fromListBox.ItemHeight = 15;
            this.fromListBox.Items.AddRange(new object[] {
            "Inches",
            "Feet",
            "Yards"});
            this.fromListBox.Location = new System.Drawing.Point(16, 19);
            this.fromListBox.Name = "fromListBox";
            this.fromListBox.Size = new System.Drawing.Size(68, 49);
            this.fromListBox.TabIndex = 0;
            // 
            // calculationLabel
            // 
            this.calculationLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.calculationLabel.Location = new System.Drawing.Point(172, 201);
            this.calculationLabel.Name = "calculationLabel";
            this.calculationLabel.Size = new System.Drawing.Size(61, 25);
            this.calculationLabel.TabIndex = 6;
            this.calculationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // unitLabel
            // 
            this.unitLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.unitLabel.Location = new System.Drawing.Point(243, 202);
            this.unitLabel.Name = "unitLabel";
            this.unitLabel.Size = new System.Drawing.Size(60, 25);
            this.unitLabel.TabIndex = 7;
            this.unitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toGroup
            // 
            this.toGroup.Controls.Add(this.toListBox);
            this.toGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toGroup.Location = new System.Drawing.Point(193, 93);
            this.toGroup.Name = "toGroup";
            this.toGroup.Size = new System.Drawing.Size(131, 84);
            this.toGroup.TabIndex = 3;
            this.toGroup.TabStop = false;
            this.toGroup.Text = "To:";
            // 
            // toListBox
            // 
            this.toListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toListBox.FormattingEnabled = true;
            this.toListBox.ItemHeight = 15;
            this.toListBox.Items.AddRange(new object[] {
            "Inches",
            "Feet",
            "Yards"});
            this.toListBox.Location = new System.Drawing.Point(16, 19);
            this.toListBox.Name = "toListBox";
            this.toListBox.Size = new System.Drawing.Size(69, 49);
            this.toListBox.TabIndex = 0;
            // 
            // unitConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 297);
            this.Controls.Add(this.toGroup);
            this.Controls.Add(this.unitLabel);
            this.Controls.Add(this.calculationLabel);
            this.Controls.Add(this.fromGroup);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.inputLabel);
            this.Name = "unitConverter";
            this.Text = "Unit Converter";
            this.fromGroup.ResumeLayout(false);
            this.toGroup.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.GroupBox fromGroup;
        private System.Windows.Forms.ListBox fromListBox;
        private System.Windows.Forms.Label calculationLabel;
        private System.Windows.Forms.Label unitLabel;
        private System.Windows.Forms.GroupBox toGroup;
        private System.Windows.Forms.ListBox toListBox;
    }
}


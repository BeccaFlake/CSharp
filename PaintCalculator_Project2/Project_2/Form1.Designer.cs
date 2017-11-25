namespace Project_2
{
    partial class PaintJobCostEstimator
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
            this.SizeTextBoxLabel = new System.Windows.Forms.Label();
            this.paintCostTextBoxLabel = new System.Windows.Forms.Label();
            this.requiredGallonLabel = new System.Windows.Forms.Label();
            this.requiredLaborLabel = new System.Windows.Forms.Label();
            this.paintCostLabel = new System.Windows.Forms.Label();
            this.laborCostLabel = new System.Windows.Forms.Label();
            this.totalCostLabel = new System.Windows.Forms.Label();
            this.sqFtTextBox = new System.Windows.Forms.TextBox();
            this.gallonTextBox = new System.Windows.Forms.TextBox();
            this.totalResult = new System.Windows.Forms.Label();
            this.laborCostResult = new System.Windows.Forms.Label();
            this.paintCostResult = new System.Windows.Forms.Label();
            this.laborResult = new System.Windows.Forms.Label();
            this.gallonResult = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.calculateButton = new System.Windows.Forms.Button();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SizeTextBoxLabel
            // 
            this.SizeTextBoxLabel.Location = new System.Drawing.Point(46, 53);
            this.SizeTextBoxLabel.Name = "SizeTextBoxLabel";
            this.SizeTextBoxLabel.Size = new System.Drawing.Size(129, 42);
            this.SizeTextBoxLabel.TabIndex = 0;
            this.SizeTextBoxLabel.Text = "What is the square footage of the wall?";
            // 
            // paintCostTextBoxLabel
            // 
            this.paintCostTextBoxLabel.Location = new System.Drawing.Point(46, 100);
            this.paintCostTextBoxLabel.Name = "paintCostTextBoxLabel";
            this.paintCostTextBoxLabel.Size = new System.Drawing.Size(129, 45);
            this.paintCostTextBoxLabel.TabIndex = 2;
            this.paintCostTextBoxLabel.Text = "How much does a   gallon of paint cost?";
            // 
            // requiredGallonLabel
            // 
            this.requiredGallonLabel.AutoSize = true;
            this.requiredGallonLabel.Location = new System.Drawing.Point(46, 185);
            this.requiredGallonLabel.Name = "requiredGallonLabel";
            this.requiredGallonLabel.Size = new System.Drawing.Size(83, 13);
            this.requiredGallonLabel.TabIndex = 5;
            this.requiredGallonLabel.Text = "Gallons required";
            // 
            // requiredLaborLabel
            // 
            this.requiredLaborLabel.AutoSize = true;
            this.requiredLaborLabel.Location = new System.Drawing.Point(46, 221);
            this.requiredLaborLabel.Name = "requiredLaborLabel";
            this.requiredLaborLabel.Size = new System.Drawing.Size(76, 13);
            this.requiredLaborLabel.TabIndex = 7;
            this.requiredLaborLabel.Text = "Required labor";
            // 
            // paintCostLabel
            // 
            this.paintCostLabel.AutoSize = true;
            this.paintCostLabel.Location = new System.Drawing.Point(46, 259);
            this.paintCostLabel.Name = "paintCostLabel";
            this.paintCostLabel.Size = new System.Drawing.Size(54, 13);
            this.paintCostLabel.TabIndex = 9;
            this.paintCostLabel.Text = "Paint cost";
            // 
            // laborCostLabel
            // 
            this.laborCostLabel.AutoSize = true;
            this.laborCostLabel.Location = new System.Drawing.Point(46, 296);
            this.laborCostLabel.Name = "laborCostLabel";
            this.laborCostLabel.Size = new System.Drawing.Size(57, 13);
            this.laborCostLabel.TabIndex = 11;
            this.laborCostLabel.Text = "Labor cost";
            // 
            // totalCostLabel
            // 
            this.totalCostLabel.AutoSize = true;
            this.totalCostLabel.Location = new System.Drawing.Point(46, 330);
            this.totalCostLabel.Name = "totalCostLabel";
            this.totalCostLabel.Size = new System.Drawing.Size(83, 13);
            this.totalCostLabel.TabIndex = 13;
            this.totalCostLabel.Text = "Total cost of job";
            // 
            // sqFtTextBox
            // 
            this.sqFtTextBox.Location = new System.Drawing.Point(181, 58);
            this.sqFtTextBox.Name = "sqFtTextBox";
            this.sqFtTextBox.Size = new System.Drawing.Size(100, 20);
            this.sqFtTextBox.TabIndex = 1;
            this.sqFtTextBox.TextChanged += new System.EventHandler(this.sqFtTextBox_TextChanged);
            // 
            // gallonTextBox
            // 
            this.gallonTextBox.Location = new System.Drawing.Point(181, 105);
            this.gallonTextBox.Name = "gallonTextBox";
            this.gallonTextBox.Size = new System.Drawing.Size(100, 20);
            this.gallonTextBox.TabIndex = 3;
            this.gallonTextBox.TextChanged += new System.EventHandler(this.gallonTextBox_TextChanged);
            // 
            // totalResult
            // 
            this.totalResult.BackColor = System.Drawing.SystemColors.Control;
            this.totalResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalResult.ForeColor = System.Drawing.SystemColors.ControlText;
            this.totalResult.Location = new System.Drawing.Point(181, 330);
            this.totalResult.Name = "totalResult";
            this.totalResult.Size = new System.Drawing.Size(100, 19);
            this.totalResult.TabIndex = 14;
            // 
            // laborCostResult
            // 
            this.laborCostResult.BackColor = System.Drawing.SystemColors.Control;
            this.laborCostResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.laborCostResult.Location = new System.Drawing.Point(181, 296);
            this.laborCostResult.Name = "laborCostResult";
            this.laborCostResult.Size = new System.Drawing.Size(100, 19);
            this.laborCostResult.TabIndex = 12;
            // 
            // paintCostResult
            // 
            this.paintCostResult.BackColor = System.Drawing.SystemColors.Control;
            this.paintCostResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paintCostResult.Location = new System.Drawing.Point(181, 259);
            this.paintCostResult.Name = "paintCostResult";
            this.paintCostResult.Size = new System.Drawing.Size(100, 19);
            this.paintCostResult.TabIndex = 10;
            // 
            // laborResult
            // 
            this.laborResult.BackColor = System.Drawing.SystemColors.Control;
            this.laborResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.laborResult.Location = new System.Drawing.Point(181, 221);
            this.laborResult.Name = "laborResult";
            this.laborResult.Size = new System.Drawing.Size(100, 19);
            this.laborResult.TabIndex = 8;
            // 
            // gallonResult
            // 
            this.gallonResult.BackColor = System.Drawing.SystemColors.Control;
            this.gallonResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gallonResult.Location = new System.Drawing.Point(181, 185);
            this.gallonResult.Name = "gallonResult";
            this.gallonResult.Size = new System.Drawing.Size(100, 19);
            this.gallonResult.TabIndex = 6;
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.clearButton.Location = new System.Drawing.Point(52, 367);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 15;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.exitButton.Location = new System.Drawing.Point(204, 367);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 16;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.calculateButton.Location = new System.Drawing.Point(128, 143);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 4;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // instructionLabel
            // 
            this.instructionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionLabel.Location = new System.Drawing.Point(49, 16);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(232, 18);
            this.instructionLabel.TabIndex = 17;
            this.instructionLabel.Text = "Enter the data as numerical values:";
            // 
            // PaintJobCostEstimator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(338, 407);
            this.Controls.Add(this.instructionLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.totalResult);
            this.Controls.Add(this.laborCostResult);
            this.Controls.Add(this.paintCostResult);
            this.Controls.Add(this.laborResult);
            this.Controls.Add(this.gallonResult);
            this.Controls.Add(this.gallonTextBox);
            this.Controls.Add(this.sqFtTextBox);
            this.Controls.Add(this.totalCostLabel);
            this.Controls.Add(this.laborCostLabel);
            this.Controls.Add(this.paintCostLabel);
            this.Controls.Add(this.requiredLaborLabel);
            this.Controls.Add(this.requiredGallonLabel);
            this.Controls.Add(this.paintCostTextBoxLabel);
            this.Controls.Add(this.SizeTextBoxLabel);
            this.Name = "PaintJobCostEstimator";
            this.Text = "Paint Job Cost Estimator";
            this.Load += new System.EventHandler(this.PaintJobCostEstimator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SizeTextBoxLabel;
        private System.Windows.Forms.Label paintCostTextBoxLabel;
        private System.Windows.Forms.Label requiredGallonLabel;
        private System.Windows.Forms.Label requiredLaborLabel;
        private System.Windows.Forms.Label paintCostLabel;
        private System.Windows.Forms.Label laborCostLabel;
        private System.Windows.Forms.Label totalCostLabel;
        private System.Windows.Forms.TextBox sqFtTextBox;
        private System.Windows.Forms.TextBox gallonTextBox;
        private System.Windows.Forms.Label totalResult;
        private System.Windows.Forms.Label laborCostResult;
        private System.Windows.Forms.Label paintCostResult;
        private System.Windows.Forms.Label laborResult;
        private System.Windows.Forms.Label gallonResult;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label instructionLabel;
    }
}


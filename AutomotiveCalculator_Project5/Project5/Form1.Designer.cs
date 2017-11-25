namespace Project5
{
    partial class Automotive
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
            this.oilLubeGB = new System.Windows.Forms.GroupBox();
            this.lubeJobCheckBox = new System.Windows.Forms.CheckBox();
            this.oilChangeCheckBox = new System.Windows.Forms.CheckBox();
            this.flushGB = new System.Windows.Forms.GroupBox();
            this.transmissionCheckBox = new System.Windows.Forms.CheckBox();
            this.radiatorCheckBox = new System.Windows.Forms.CheckBox();
            this.partsLaborGB = new System.Windows.Forms.GroupBox();
            this.LaborLabel = new System.Windows.Forms.Label();
            this.PartsLabel = new System.Windows.Forms.Label();
            this.laborNoteLabel = new System.Windows.Forms.Label();
            this.laborTextBox = new System.Windows.Forms.TextBox();
            this.partsTextBox = new System.Windows.Forms.TextBox();
            this.miscGB = new System.Windows.Forms.GroupBox();
            this.tireCheckBox = new System.Windows.Forms.CheckBox();
            this.mufflerCheckBox = new System.Windows.Forms.CheckBox();
            this.inspectionCheckBox = new System.Windows.Forms.CheckBox();
            this.summeryGB = new System.Windows.Forms.GroupBox();
            this.totalCostlabel = new System.Windows.Forms.Label();
            this.taxTotalLabel = new System.Windows.Forms.Label();
            this.partsTotalLabel = new System.Windows.Forms.Label();
            this.serviceTotalLabel = new System.Windows.Forms.Label();
            this.feesLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.partsSumLabel = new System.Windows.Forms.Label();
            this.serviceLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.infoLabel = new System.Windows.Forms.Label();
            this.oilLubeGB.SuspendLayout();
            this.flushGB.SuspendLayout();
            this.partsLaborGB.SuspendLayout();
            this.miscGB.SuspendLayout();
            this.summeryGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // oilLubeGB
            // 
            this.oilLubeGB.Controls.Add(this.lubeJobCheckBox);
            this.oilLubeGB.Controls.Add(this.oilChangeCheckBox);
            this.oilLubeGB.Location = new System.Drawing.Point(45, 65);
            this.oilLubeGB.Name = "oilLubeGB";
            this.oilLubeGB.Size = new System.Drawing.Size(172, 63);
            this.oilLubeGB.TabIndex = 0;
            this.oilLubeGB.TabStop = false;
            this.oilLubeGB.Text = "Oil && Lube";
            // 
            // lubeJobCheckBox
            // 
            this.lubeJobCheckBox.AutoSize = true;
            this.lubeJobCheckBox.Location = new System.Drawing.Point(6, 40);
            this.lubeJobCheckBox.Name = "lubeJobCheckBox";
            this.lubeJobCheckBox.Size = new System.Drawing.Size(91, 17);
            this.lubeJobCheckBox.TabIndex = 1;
            this.lubeJobCheckBox.Text = "Lube Job $18";
            this.lubeJobCheckBox.UseVisualStyleBackColor = true;
            // 
            // oilChangeCheckBox
            // 
            this.oilChangeCheckBox.AutoSize = true;
            this.oilChangeCheckBox.Location = new System.Drawing.Point(6, 19);
            this.oilChangeCheckBox.Name = "oilChangeCheckBox";
            this.oilChangeCheckBox.Size = new System.Drawing.Size(99, 17);
            this.oilChangeCheckBox.TabIndex = 0;
            this.oilChangeCheckBox.Text = "Oil Change $26";
            this.oilChangeCheckBox.UseVisualStyleBackColor = true;
            // 
            // flushGB
            // 
            this.flushGB.Controls.Add(this.transmissionCheckBox);
            this.flushGB.Controls.Add(this.radiatorCheckBox);
            this.flushGB.Location = new System.Drawing.Point(235, 65);
            this.flushGB.Name = "flushGB";
            this.flushGB.Size = new System.Drawing.Size(167, 63);
            this.flushGB.TabIndex = 1;
            this.flushGB.TabStop = false;
            this.flushGB.Text = "Flushes";
            // 
            // transmissionCheckBox
            // 
            this.transmissionCheckBox.AutoSize = true;
            this.transmissionCheckBox.Location = new System.Drawing.Point(6, 40);
            this.transmissionCheckBox.Name = "transmissionCheckBox";
            this.transmissionCheckBox.Size = new System.Drawing.Size(136, 17);
            this.transmissionCheckBox.TabIndex = 3;
            this.transmissionCheckBox.Text = "Transmission Flush $80";
            this.transmissionCheckBox.UseVisualStyleBackColor = true;
            // 
            // radiatorCheckBox
            // 
            this.radiatorCheckBox.AutoSize = true;
            this.radiatorCheckBox.Location = new System.Drawing.Point(6, 19);
            this.radiatorCheckBox.Name = "radiatorCheckBox";
            this.radiatorCheckBox.Size = new System.Drawing.Size(115, 17);
            this.radiatorCheckBox.TabIndex = 2;
            this.radiatorCheckBox.Text = "Radiator Flush $30";
            this.radiatorCheckBox.UseVisualStyleBackColor = true;
            // 
            // partsLaborGB
            // 
            this.partsLaborGB.Controls.Add(this.LaborLabel);
            this.partsLaborGB.Controls.Add(this.PartsLabel);
            this.partsLaborGB.Controls.Add(this.laborNoteLabel);
            this.partsLaborGB.Controls.Add(this.laborTextBox);
            this.partsLaborGB.Controls.Add(this.partsTextBox);
            this.partsLaborGB.Location = new System.Drawing.Point(235, 138);
            this.partsLaborGB.Name = "partsLaborGB";
            this.partsLaborGB.Size = new System.Drawing.Size(167, 90);
            this.partsLaborGB.TabIndex = 3;
            this.partsLaborGB.TabStop = false;
            this.partsLaborGB.Text = "Parts && Labor";
            // 
            // LaborLabel
            // 
            this.LaborLabel.AutoSize = true;
            this.LaborLabel.Location = new System.Drawing.Point(7, 48);
            this.LaborLabel.Name = "LaborLabel";
            this.LaborLabel.Size = new System.Drawing.Size(61, 13);
            this.LaborLabel.TabIndex = 4;
            this.LaborLabel.Text = "*Labor (hrs)";
            // 
            // PartsLabel
            // 
            this.PartsLabel.AutoSize = true;
            this.PartsLabel.Location = new System.Drawing.Point(33, 26);
            this.PartsLabel.Name = "PartsLabel";
            this.PartsLabel.Size = new System.Drawing.Size(31, 13);
            this.PartsLabel.TabIndex = 3;
            this.PartsLabel.Text = "Parts";
            // 
            // laborNoteLabel
            // 
            this.laborNoteLabel.AutoSize = true;
            this.laborNoteLabel.Location = new System.Drawing.Point(81, 74);
            this.laborNoteLabel.Name = "laborNoteLabel";
            this.laborNoteLabel.Size = new System.Drawing.Size(83, 13);
            this.laborNoteLabel.TabIndex = 2;
            this.laborNoteLabel.Text = "*Labor is $20/hr";
            // 
            // laborTextBox
            // 
            this.laborTextBox.Location = new System.Drawing.Point(70, 45);
            this.laborTextBox.Name = "laborTextBox";
            this.laborTextBox.Size = new System.Drawing.Size(91, 20);
            this.laborTextBox.TabIndex = 1;
            this.laborTextBox.Text = "0.00";
            // 
            // partsTextBox
            // 
            this.partsTextBox.Location = new System.Drawing.Point(70, 19);
            this.partsTextBox.Name = "partsTextBox";
            this.partsTextBox.Size = new System.Drawing.Size(91, 20);
            this.partsTextBox.TabIndex = 0;
            this.partsTextBox.Text = "0.00";
            // 
            // miscGB
            // 
            this.miscGB.Controls.Add(this.tireCheckBox);
            this.miscGB.Controls.Add(this.mufflerCheckBox);
            this.miscGB.Controls.Add(this.inspectionCheckBox);
            this.miscGB.Location = new System.Drawing.Point(45, 138);
            this.miscGB.Name = "miscGB";
            this.miscGB.Size = new System.Drawing.Size(172, 90);
            this.miscGB.TabIndex = 2;
            this.miscGB.TabStop = false;
            this.miscGB.Text = "Misc.";
            // 
            // tireCheckBox
            // 
            this.tireCheckBox.AutoSize = true;
            this.tireCheckBox.Location = new System.Drawing.Point(6, 63);
            this.tireCheckBox.Name = "tireCheckBox";
            this.tireCheckBox.Size = new System.Drawing.Size(108, 17);
            this.tireCheckBox.TabIndex = 10;
            this.tireCheckBox.Text = "Tire Rotation $20";
            this.tireCheckBox.UseVisualStyleBackColor = true;
            // 
            // mufflerCheckBox
            // 
            this.mufflerCheckBox.AutoSize = true;
            this.mufflerCheckBox.Location = new System.Drawing.Point(6, 40);
            this.mufflerCheckBox.Name = "mufflerCheckBox";
            this.mufflerCheckBox.Size = new System.Drawing.Size(151, 17);
            this.mufflerCheckBox.TabIndex = 9;
            this.mufflerCheckBox.Text = "Muffler Replacement $100";
            this.mufflerCheckBox.UseVisualStyleBackColor = true;
            // 
            // inspectionCheckBox
            // 
            this.inspectionCheckBox.AutoSize = true;
            this.inspectionCheckBox.Location = new System.Drawing.Point(6, 19);
            this.inspectionCheckBox.Name = "inspectionCheckBox";
            this.inspectionCheckBox.Size = new System.Drawing.Size(96, 17);
            this.inspectionCheckBox.TabIndex = 8;
            this.inspectionCheckBox.Text = "Inspection $15";
            this.inspectionCheckBox.UseVisualStyleBackColor = true;
            // 
            // summeryGB
            // 
            this.summeryGB.Controls.Add(this.totalCostlabel);
            this.summeryGB.Controls.Add(this.taxTotalLabel);
            this.summeryGB.Controls.Add(this.partsTotalLabel);
            this.summeryGB.Controls.Add(this.serviceTotalLabel);
            this.summeryGB.Controls.Add(this.feesLabel);
            this.summeryGB.Controls.Add(this.taxLabel);
            this.summeryGB.Controls.Add(this.partsSumLabel);
            this.summeryGB.Controls.Add(this.serviceLabel);
            this.summeryGB.Location = new System.Drawing.Point(45, 235);
            this.summeryGB.Name = "summeryGB";
            this.summeryGB.Size = new System.Drawing.Size(358, 140);
            this.summeryGB.TabIndex = 4;
            this.summeryGB.TabStop = false;
            this.summeryGB.Text = "Summary";
            // 
            // totalCostlabel
            // 
            this.totalCostlabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalCostlabel.Location = new System.Drawing.Point(190, 108);
            this.totalCostlabel.Name = "totalCostlabel";
            this.totalCostlabel.Size = new System.Drawing.Size(100, 23);
            this.totalCostlabel.TabIndex = 7;
            // 
            // taxTotalLabel
            // 
            this.taxTotalLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.taxTotalLabel.Location = new System.Drawing.Point(190, 77);
            this.taxTotalLabel.Name = "taxTotalLabel";
            this.taxTotalLabel.Size = new System.Drawing.Size(100, 23);
            this.taxTotalLabel.TabIndex = 6;
            // 
            // partsTotalLabel
            // 
            this.partsTotalLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.partsTotalLabel.Location = new System.Drawing.Point(190, 46);
            this.partsTotalLabel.Name = "partsTotalLabel";
            this.partsTotalLabel.Size = new System.Drawing.Size(100, 23);
            this.partsTotalLabel.TabIndex = 5;
            // 
            // serviceTotalLabel
            // 
            this.serviceTotalLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.serviceTotalLabel.Location = new System.Drawing.Point(190, 15);
            this.serviceTotalLabel.Name = "serviceTotalLabel";
            this.serviceTotalLabel.Size = new System.Drawing.Size(100, 23);
            this.serviceTotalLabel.TabIndex = 4;
            // 
            // feesLabel
            // 
            this.feesLabel.AutoSize = true;
            this.feesLabel.Location = new System.Drawing.Point(115, 118);
            this.feesLabel.Name = "feesLabel";
            this.feesLabel.Size = new System.Drawing.Size(57, 13);
            this.feesLabel.TabIndex = 3;
            this.feesLabel.Text = "Total Fees";
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Location = new System.Drawing.Point(100, 87);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(72, 13);
            this.taxLabel.TabIndex = 2;
            this.taxLabel.Text = "Tax (on parts)";
            // 
            // partsSumLabel
            // 
            this.partsSumLabel.AutoSize = true;
            this.partsSumLabel.Location = new System.Drawing.Point(141, 56);
            this.partsSumLabel.Name = "partsSumLabel";
            this.partsSumLabel.Size = new System.Drawing.Size(31, 13);
            this.partsSumLabel.TabIndex = 1;
            this.partsSumLabel.Text = "Parts";
            // 
            // serviceLabel
            // 
            this.serviceLabel.AutoSize = true;
            this.serviceLabel.Location = new System.Drawing.Point(90, 25);
            this.serviceLabel.Name = "serviceLabel";
            this.serviceLabel.Size = new System.Drawing.Size(82, 13);
            this.serviceLabel.TabIndex = 0;
            this.serviceLabel.Text = "Service && Labor";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(46, 388);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 5;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(187, 388);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(328, 388);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // infoLabel
            // 
            this.infoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLabel.Location = new System.Drawing.Point(42, 11);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(361, 51);
            this.infoLabel.TabIndex = 8;
            this.infoLabel.Text = "Check the services that apply. Enter the price of the parts (if any) as a numeric" +
    " value. Enter the hours of labor as a numeric value. Click calculate to get the " +
    "fee summary.";
            // 
            // Automotive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 429);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.summeryGB);
            this.Controls.Add(this.partsLaborGB);
            this.Controls.Add(this.flushGB);
            this.Controls.Add(this.miscGB);
            this.Controls.Add(this.oilLubeGB);
            this.Name = "Automotive";
            this.Text = "Automotive";
            this.oilLubeGB.ResumeLayout(false);
            this.oilLubeGB.PerformLayout();
            this.flushGB.ResumeLayout(false);
            this.flushGB.PerformLayout();
            this.partsLaborGB.ResumeLayout(false);
            this.partsLaborGB.PerformLayout();
            this.miscGB.ResumeLayout(false);
            this.miscGB.PerformLayout();
            this.summeryGB.ResumeLayout(false);
            this.summeryGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox oilLubeGB;
        private System.Windows.Forms.GroupBox flushGB;
        private System.Windows.Forms.GroupBox partsLaborGB;
        private System.Windows.Forms.GroupBox miscGB;
        private System.Windows.Forms.GroupBox summeryGB;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.CheckBox lubeJobCheckBox;
        private System.Windows.Forms.CheckBox oilChangeCheckBox;
        private System.Windows.Forms.CheckBox transmissionCheckBox;
        private System.Windows.Forms.CheckBox radiatorCheckBox;
        private System.Windows.Forms.Label LaborLabel;
        private System.Windows.Forms.Label PartsLabel;
        private System.Windows.Forms.Label laborNoteLabel;
        private System.Windows.Forms.TextBox laborTextBox;
        private System.Windows.Forms.TextBox partsTextBox;
        private System.Windows.Forms.CheckBox tireCheckBox;
        private System.Windows.Forms.CheckBox mufflerCheckBox;
        private System.Windows.Forms.CheckBox inspectionCheckBox;
        private System.Windows.Forms.Label totalCostlabel;
        private System.Windows.Forms.Label taxTotalLabel;
        private System.Windows.Forms.Label partsTotalLabel;
        private System.Windows.Forms.Label serviceTotalLabel;
        private System.Windows.Forms.Label feesLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label partsSumLabel;
        private System.Windows.Forms.Label serviceLabel;
        private System.Windows.Forms.Label infoLabel;
    }
}


namespace Project6
{
    partial class worldSeriesWinners
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
            this.teamsListBox = new System.Windows.Forms.ListBox();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // teamsListBox
            // 
            this.teamsListBox.FormattingEnabled = true;
            this.teamsListBox.Location = new System.Drawing.Point(27, 56);
            this.teamsListBox.Name = "teamsListBox";
            this.teamsListBox.Size = new System.Drawing.Size(165, 251);
            this.teamsListBox.TabIndex = 1;
            this.teamsListBox.SelectedIndexChanged += new System.EventHandler(this.teamsListBox_SelectedIndexChanged);
            // 
            // instructionLabel
            // 
            this.instructionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionLabel.Location = new System.Drawing.Point(45, 15);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(296, 30);
            this.instructionLabel.TabIndex = 0;
            this.instructionLabel.Text = "Choose a team from the list to see the number of times they have won the World Se" +
    "ries";
            this.instructionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resultLabel
            // 
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.Location = new System.Drawing.Point(209, 140);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(161, 112);
            this.resultLabel.TabIndex = 3;
            this.resultLabel.Text = "The [team name] have won the World Series [number] time(s).";
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitButton.Location = new System.Drawing.Point(171, 313);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // worldSeriesWinners
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(408, 349);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.instructionLabel);
            this.Controls.Add(this.teamsListBox);
            this.Name = "worldSeriesWinners";
            this.Text = "World Series Winners";
            this.Load += new System.EventHandler(this.worldSeriesWinners_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox teamsListBox;
        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button exitButton;
    }
}


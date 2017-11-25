namespace Project_1
{
    partial class cardIdentifier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cardIdentifier));
            this.instructions = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.card1 = new System.Windows.Forms.PictureBox();
            this.card3 = new System.Windows.Forms.PictureBox();
            this.card2 = new System.Windows.Forms.PictureBox();
            this.card4 = new System.Windows.Forms.PictureBox();
            this.card5 = new System.Windows.Forms.PictureBox();
            this.cardName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.card1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card5)).BeginInit();
            this.SuspendLayout();
            // 
            // instructions
            // 
            this.instructions.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.instructions.AutoSize = true;
            this.instructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructions.Location = new System.Drawing.Point(271, 43);
            this.instructions.Name = "instructions";
            this.instructions.Size = new System.Drawing.Size(265, 24);
            this.instructions.TabIndex = 0;
            this.instructions.Text = "Click on a card to see its name";
            this.instructions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(363, 327);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(84, 33);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // card1
            // 
            this.card1.Image = ((System.Drawing.Image)(resources.GetObject("card1.Image")));
            this.card1.Location = new System.Drawing.Point(47, 102);
            this.card1.Name = "card1";
            this.card1.Size = new System.Drawing.Size(100, 137);
            this.card1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.card1.TabIndex = 3;
            this.card1.TabStop = false;
            this.card1.Click += new System.EventHandler(this.card1_Click);
            // 
            // card3
            // 
            this.card3.Image = global::Project_1.Properties.Resources.Ace_Spades;
            this.card3.Location = new System.Drawing.Point(353, 102);
            this.card3.Name = "card3";
            this.card3.Size = new System.Drawing.Size(100, 137);
            this.card3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.card3.TabIndex = 4;
            this.card3.TabStop = false;
            this.card3.Click += new System.EventHandler(this.card3_Click);
            // 
            // card2
            // 
            this.card2.Image = global::Project_1.Properties.Resources._2_Hearts;
            this.card2.Location = new System.Drawing.Point(200, 102);
            this.card2.Name = "card2";
            this.card2.Size = new System.Drawing.Size(100, 137);
            this.card2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.card2.TabIndex = 5;
            this.card2.TabStop = false;
            this.card2.Click += new System.EventHandler(this.card2_Click);
            // 
            // card4
            // 
            this.card4.Image = global::Project_1.Properties.Resources._8_Clubs;
            this.card4.Location = new System.Drawing.Point(506, 102);
            this.card4.Name = "card4";
            this.card4.Size = new System.Drawing.Size(100, 137);
            this.card4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.card4.TabIndex = 6;
            this.card4.TabStop = false;
            this.card4.Click += new System.EventHandler(this.card4_Click);
            // 
            // card5
            // 
            this.card5.Image = global::Project_1.Properties.Resources.Jack_Clubs;
            this.card5.Location = new System.Drawing.Point(659, 102);
            this.card5.Name = "card5";
            this.card5.Size = new System.Drawing.Size(100, 137);
            this.card5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.card5.TabIndex = 7;
            this.card5.TabStop = false;
            this.card5.Click += new System.EventHandler(this.card5_Click);
            // 
            // cardName
            // 
            this.cardName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cardName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardName.Location = new System.Drawing.Point(47, 269);
            this.cardName.Name = "cardName";
            this.cardName.Size = new System.Drawing.Size(712, 42);
            this.cardName.TabIndex = 8;
            this.cardName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cardIdentifier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 387);
            this.Controls.Add(this.cardName);
            this.Controls.Add(this.card5);
            this.Controls.Add(this.card4);
            this.Controls.Add(this.card2);
            this.Controls.Add(this.card3);
            this.Controls.Add(this.card1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.instructions);
            this.Name = "cardIdentifier";
            this.Text = "Card Identifier";
            ((System.ComponentModel.ISupportInitialize)(this.card1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label instructions;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.PictureBox card1;
        private System.Windows.Forms.PictureBox card3;
        private System.Windows.Forms.PictureBox card2;
        private System.Windows.Forms.PictureBox card4;
        private System.Windows.Forms.PictureBox card5;
        private System.Windows.Forms.Label cardName;
    }
}


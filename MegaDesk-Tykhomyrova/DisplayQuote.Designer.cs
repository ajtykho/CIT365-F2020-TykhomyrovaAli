namespace MegaDesk_Tykhomyrova
{
    partial class DisplayQuote
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
            this.quoteOutput = new System.Windows.Forms.Label();
            this.backMainMenu = new System.Windows.Forms.Button();
            this.headerQuote = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nameOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // quoteOutput
            // 
            this.quoteOutput.AutoSize = true;
            this.quoteOutput.Location = new System.Drawing.Point(191, 135);
            this.quoteOutput.Name = "quoteOutput";
            this.quoteOutput.Size = new System.Drawing.Size(70, 25);
            this.quoteOutput.TabIndex = 0;
            this.quoteOutput.Text = "label1";
            // 
            // backMainMenu
            // 
            this.backMainMenu.AutoSize = true;
            this.backMainMenu.Location = new System.Drawing.Point(54, 466);
            this.backMainMenu.Name = "backMainMenu";
            this.backMainMenu.Size = new System.Drawing.Size(207, 56);
            this.backMainMenu.TabIndex = 1;
            this.backMainMenu.Text = "Back to Main Menu";
            this.backMainMenu.UseVisualStyleBackColor = true;
            this.backMainMenu.Click += new System.EventHandler(this.backMainMenu_Click);
            // 
            // headerQuote
            // 
            this.headerQuote.AutoSize = true;
            this.headerQuote.Location = new System.Drawing.Point(44, 30);
            this.headerQuote.Name = "headerQuote";
            this.headerQuote.Size = new System.Drawing.Size(218, 25);
            this.headerQuote.TabIndex = 2;
            this.headerQuote.Text = "Your Quote Summary";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Your Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Total Cost:";
            // 
            // nameOutput
            // 
            this.nameOutput.AutoSize = true;
            this.nameOutput.Location = new System.Drawing.Point(192, 83);
            this.nameOutput.Name = "nameOutput";
            this.nameOutput.Size = new System.Drawing.Size(70, 25);
            this.nameOutput.TabIndex = 5;
            this.nameOutput.Text = "label3";
            // 
            // DisplayQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 583);
            this.Controls.Add(this.nameOutput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.headerQuote);
            this.Controls.Add(this.backMainMenu);
            this.Controls.Add(this.quoteOutput);
            this.Name = "DisplayQuote";
            this.Text = "DisplayQuote";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label quoteOutput;
        private System.Windows.Forms.Button backMainMenu;
        private System.Windows.Forms.Label headerQuote;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nameOutput;
    }
}
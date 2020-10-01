namespace MegaDesk_Tykhomyrova
{
    partial class AddQuote
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
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.deskWidth = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.deskDepth = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.drawerQuantity = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.materialType = new System.Windows.Forms.Label();
            this.processingTime = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.formSubmission = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Location = new System.Drawing.Point(0, 0);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(249, 25);
            this.customerNameLabel.TabIndex = 0;
            this.customerNameLabel.Text = "Please Enter Your Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(496, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 31);
            this.textBox1.TabIndex = 1;
            // 
            // deskWidth
            // 
            this.deskWidth.AutoSize = true;
            this.deskWidth.Location = new System.Drawing.Point(12, 51);
            this.deskWidth.Name = "deskWidth";
            this.deskWidth.Size = new System.Drawing.Size(152, 25);
            this.deskWidth.TabIndex = 2;
            this.deskWidth.Text = "Width of Desk:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(337, 67);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 31);
            this.textBox2.TabIndex = 3;
            // 
            // deskDepth
            // 
            this.deskDepth.AutoSize = true;
            this.deskDepth.Location = new System.Drawing.Point(0, 139);
            this.deskDepth.Name = "deskDepth";
            this.deskDepth.Size = new System.Drawing.Size(154, 25);
            this.deskDepth.TabIndex = 4;
            this.deskDepth.Text = "Depth of Desk:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(256, 133);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 31);
            this.textBox3.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(337, 218);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 33);
            this.comboBox1.TabIndex = 6;
            // 
            // drawerQuantity
            // 
            this.drawerQuantity.AutoSize = true;
            this.drawerQuantity.Location = new System.Drawing.Point(37, 226);
            this.drawerQuantity.Name = "drawerQuantity";
            this.drawerQuantity.Size = new System.Drawing.Size(196, 25);
            this.drawerQuantity.TabIndex = 7;
            this.drawerQuantity.Text = "Number of Drawers";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(306, 291);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 33);
            this.comboBox2.TabIndex = 8;
            // 
            // materialType
            // 
            this.materialType.AutoSize = true;
            this.materialType.Location = new System.Drawing.Point(37, 294);
            this.materialType.Name = "materialType";
            this.materialType.Size = new System.Drawing.Size(143, 25);
            this.materialType.TabIndex = 9;
            this.materialType.Text = "Material Type";
            // 
            // processingTime
            // 
            this.processingTime.AutoSize = true;
            this.processingTime.Location = new System.Drawing.Point(37, 343);
            this.processingTime.Name = "processingTime";
            this.processingTime.Size = new System.Drawing.Size(232, 25);
            this.processingTime.TabIndex = 10;
            this.processingTime.Text = "Order Processing Time";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(451, 343);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 33);
            this.comboBox3.TabIndex = 11;
            // 
            // formSubmission
            // 
            this.formSubmission.AutoSize = true;
            this.formSubmission.Location = new System.Drawing.Point(602, 201);
            this.formSubmission.Name = "formSubmission";
            this.formSubmission.Size = new System.Drawing.Size(148, 35);
            this.formSubmission.TabIndex = 12;
            this.formSubmission.Text = "Submit Order";
            this.formSubmission.UseVisualStyleBackColor = true;
            this.formSubmission.Click += new System.EventHandler(this.formSubmission_Click);
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.formSubmission);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.processingTime);
            this.Controls.Add(this.materialType);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.drawerQuantity);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.deskDepth);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.deskWidth);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.customerNameLabel);
            this.Name = "AddQuote";
            this.Text = "AddQuote";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label customerNameLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label deskWidth;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label deskDepth;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label drawerQuantity;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label materialType;
        private System.Windows.Forms.Label processingTime;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button formSubmission;
    }
}
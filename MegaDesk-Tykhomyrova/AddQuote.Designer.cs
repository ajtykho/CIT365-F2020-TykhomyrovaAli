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
            this.customerNameInput = new System.Windows.Forms.TextBox();
            this.deskWidth = new System.Windows.Forms.Label();
            this.widthInput = new System.Windows.Forms.TextBox();
            this.deskDepth = new System.Windows.Forms.Label();
            this.depthInput = new System.Windows.Forms.TextBox();
            this.numDrawersInput = new System.Windows.Forms.ComboBox();
            this.drawerQuantity = new System.Windows.Forms.Label();
            this.materialInput = new System.Windows.Forms.ComboBox();
            this.materialType = new System.Windows.Forms.Label();
            this.processingTime = new System.Windows.Forms.Label();
            this.rushInput = new System.Windows.Forms.ComboBox();
            this.formSubmission = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Location = new System.Drawing.Point(126, 64);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(249, 25);
            this.customerNameLabel.TabIndex = 0;
            this.customerNameLabel.Text = "Please Enter Your Name";
            // 
            // customerNameInput
            // 
            this.customerNameInput.Location = new System.Drawing.Point(417, 61);
            this.customerNameInput.Name = "customerNameInput";
            this.customerNameInput.Size = new System.Drawing.Size(251, 31);
            this.customerNameInput.TabIndex = 1;
            // 
            // deskWidth
            // 
            this.deskWidth.AutoSize = true;
            this.deskWidth.Location = new System.Drawing.Point(126, 133);
            this.deskWidth.Name = "deskWidth";
            this.deskWidth.Size = new System.Drawing.Size(235, 25);
            this.deskWidth.TabIndex = 2;
            this.deskWidth.Text = "Width of Desk (inches):";
            // 
            // widthInput
            // 
            this.widthInput.Location = new System.Drawing.Point(417, 127);
            this.widthInput.Name = "widthInput";
            this.widthInput.Size = new System.Drawing.Size(251, 31);
            this.widthInput.TabIndex = 3;
            // 
            // deskDepth
            // 
            this.deskDepth.AutoSize = true;
            this.deskDepth.Location = new System.Drawing.Point(126, 204);
            this.deskDepth.Name = "deskDepth";
            this.deskDepth.Size = new System.Drawing.Size(237, 25);
            this.deskDepth.TabIndex = 4;
            this.deskDepth.Text = "Depth of Desk (inches):";
            // 
            // depthInput
            // 
            this.depthInput.Location = new System.Drawing.Point(417, 198);
            this.depthInput.Name = "depthInput";
            this.depthInput.Size = new System.Drawing.Size(251, 31);
            this.depthInput.TabIndex = 5;
            // 
            // numDrawersInput
            // 
            this.numDrawersInput.FormattingEnabled = true;
            this.numDrawersInput.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.numDrawersInput.Location = new System.Drawing.Point(417, 265);
            this.numDrawersInput.Name = "numDrawersInput";
            this.numDrawersInput.Size = new System.Drawing.Size(251, 33);
            this.numDrawersInput.TabIndex = 6;
            // 
            // drawerQuantity
            // 
            this.drawerQuantity.AutoSize = true;
            this.drawerQuantity.Location = new System.Drawing.Point(126, 273);
            this.drawerQuantity.Name = "drawerQuantity";
            this.drawerQuantity.Size = new System.Drawing.Size(196, 25);
            this.drawerQuantity.TabIndex = 7;
            this.drawerQuantity.Text = "Number of Drawers";
            // 
            // materialInput
            // 
            this.materialInput.FormattingEnabled = true;
            this.materialInput.Items.AddRange(new object[] {
            "Laminate",
            "Oak",
            "Rosewood",
            "Veneer",
            "Pine"});
            this.materialInput.Location = new System.Drawing.Point(417, 339);
            this.materialInput.Name = "materialInput";
            this.materialInput.Size = new System.Drawing.Size(251, 33);
            this.materialInput.TabIndex = 8;
            // 
            // materialType
            // 
            this.materialType.AutoSize = true;
            this.materialType.Location = new System.Drawing.Point(126, 342);
            this.materialType.Name = "materialType";
            this.materialType.Size = new System.Drawing.Size(143, 25);
            this.materialType.TabIndex = 9;
            this.materialType.Text = "Material Type";
            // 
            // processingTime
            // 
            this.processingTime.AutoSize = true;
            this.processingTime.Location = new System.Drawing.Point(126, 416);
            this.processingTime.Name = "processingTime";
            this.processingTime.Size = new System.Drawing.Size(232, 25);
            this.processingTime.TabIndex = 10;
            this.processingTime.Text = "Order Processing Time";
            // 
            // rushInput
            // 
            this.rushInput.FormattingEnabled = true;
            this.rushInput.Items.AddRange(new object[] {
            "3 Day Rush",
            "5 Day Rush",
            "7 Day Rush",
            "14 Day Normal Production"});
            this.rushInput.Location = new System.Drawing.Point(417, 416);
            this.rushInput.Name = "rushInput";
            this.rushInput.Size = new System.Drawing.Size(251, 33);
            this.rushInput.TabIndex = 11;
            // 
            // formSubmission
            // 
            this.formSubmission.AutoSize = true;
            this.formSubmission.Location = new System.Drawing.Point(489, 512);
            this.formSubmission.Name = "formSubmission";
            this.formSubmission.Size = new System.Drawing.Size(179, 63);
            this.formSubmission.TabIndex = 12;
            this.formSubmission.Text = "Submit Order";
            this.formSubmission.UseVisualStyleBackColor = true;
            this.formSubmission.Click += new System.EventHandler(this.formSubmission_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(133, 519);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(136, 48);
            this.backButton.TabIndex = 13;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 620);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.formSubmission);
            this.Controls.Add(this.rushInput);
            this.Controls.Add(this.processingTime);
            this.Controls.Add(this.materialType);
            this.Controls.Add(this.materialInput);
            this.Controls.Add(this.drawerQuantity);
            this.Controls.Add(this.numDrawersInput);
            this.Controls.Add(this.depthInput);
            this.Controls.Add(this.deskDepth);
            this.Controls.Add(this.widthInput);
            this.Controls.Add(this.deskWidth);
            this.Controls.Add(this.customerNameInput);
            this.Controls.Add(this.customerNameLabel);
            this.Name = "AddQuote";
            this.Text = "Add Quote";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label customerNameLabel;
        private System.Windows.Forms.TextBox customerNameInput;
        private System.Windows.Forms.Label deskWidth;
        private System.Windows.Forms.TextBox widthInput;
        private System.Windows.Forms.Label deskDepth;
        private System.Windows.Forms.TextBox depthInput;
        private System.Windows.Forms.ComboBox numDrawersInput;
        private System.Windows.Forms.Label drawerQuantity;
        private System.Windows.Forms.ComboBox materialInput;
        private System.Windows.Forms.Label materialType;
        private System.Windows.Forms.Label processingTime;
        private System.Windows.Forms.ComboBox rushInput;
        private System.Windows.Forms.Button formSubmission;
        private System.Windows.Forms.Button backButton;
    }
}
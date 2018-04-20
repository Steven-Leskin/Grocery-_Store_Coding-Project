namespace SitkaGroceryStore
{
    partial class creditIntakeFRM
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
            this.headerLBL = new System.Windows.Forms.Label();
            this.fullNameLBL = new System.Windows.Forms.Label();
            this.cardNuLBL = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cardNuTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.monthLB = new System.Windows.Forms.ListBox();
            this.yearLB = new System.Windows.Forms.ListBox();
            this.cardLBL = new System.Windows.Forms.Label();
            this.CardIssuerLB = new System.Windows.Forms.ListBox();
            this.submitBTN = new System.Windows.Forms.Button();
            this.closeBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerLBL
            // 
            this.headerLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLBL.ForeColor = System.Drawing.Color.ForestGreen;
            this.headerLBL.Location = new System.Drawing.Point(0, 9);
            this.headerLBL.Name = "headerLBL";
            this.headerLBL.Size = new System.Drawing.Size(407, 75);
            this.headerLBL.TabIndex = 0;
            this.headerLBL.Text = "SITKA GROCER\r\nCredit Information\r\n";
            this.headerLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fullNameLBL
            // 
            this.fullNameLBL.AutoSize = true;
            this.fullNameLBL.Location = new System.Drawing.Point(30, 104);
            this.fullNameLBL.Name = "fullNameLBL";
            this.fullNameLBL.Size = new System.Drawing.Size(75, 17);
            this.fullNameLBL.TabIndex = 1;
            this.fullNameLBL.Text = "Full Name:";
            // 
            // cardNuLBL
            // 
            this.cardNuLBL.AutoSize = true;
            this.cardNuLBL.Location = new System.Drawing.Point(29, 126);
            this.cardNuLBL.Name = "cardNuLBL";
            this.cardNuLBL.Size = new System.Drawing.Size(96, 17);
            this.cardNuLBL.TabIndex = 2;
            this.cardNuLBL.Text = "Card Number:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(141, 98);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(226, 22);
            this.textBox1.TabIndex = 7;
            // 
            // cardNuTB
            // 
            this.cardNuTB.Location = new System.Drawing.Point(141, 126);
            this.cardNuTB.Name = "cardNuTB";
            this.cardNuTB.Size = new System.Drawing.Size(226, 22);
            this.cardNuTB.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Expiration Date";
            // 
            // monthLB
            // 
            this.monthLB.FormattingEnabled = true;
            this.monthLB.ItemHeight = 16;
            this.monthLB.Items.AddRange(new object[] {
            "Jan",
            "Feb",
            "Mar",
            "Apr",
            "May",
            "Jun",
            "Jul",
            "Aug",
            "Sep",
            "Oct",
            "Nov",
            "Dec"});
            this.monthLB.Location = new System.Drawing.Point(141, 209);
            this.monthLB.Name = "monthLB";
            this.monthLB.Size = new System.Drawing.Size(67, 100);
            this.monthLB.TabIndex = 10;
            // 
            // yearLB
            // 
            this.yearLB.FormattingEnabled = true;
            this.yearLB.ItemHeight = 16;
            this.yearLB.Items.AddRange(new object[] {
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022"});
            this.yearLB.Location = new System.Drawing.Point(231, 209);
            this.yearLB.Name = "yearLB";
            this.yearLB.Size = new System.Drawing.Size(67, 100);
            this.yearLB.TabIndex = 11;
            // 
            // cardLBL
            // 
            this.cardLBL.AutoSize = true;
            this.cardLBL.Location = new System.Drawing.Point(29, 164);
            this.cardLBL.Name = "cardLBL";
            this.cardLBL.Size = new System.Drawing.Size(94, 17);
            this.cardLBL.TabIndex = 12;
            this.cardLBL.Text = "Type of Card:";
            // 
            // CardIssuerLB
            // 
            this.CardIssuerLB.FormattingEnabled = true;
            this.CardIssuerLB.ItemHeight = 16;
            this.CardIssuerLB.Items.AddRange(new object[] {
            "American Express",
            "Discover",
            "Master Card",
            "Visa"});
            this.CardIssuerLB.Location = new System.Drawing.Point(141, 155);
            this.CardIssuerLB.Name = "CardIssuerLB";
            this.CardIssuerLB.Size = new System.Drawing.Size(226, 36);
            this.CardIssuerLB.TabIndex = 13;
            // 
            // submitBTN
            // 
            this.submitBTN.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.submitBTN.Location = new System.Drawing.Point(33, 329);
            this.submitBTN.Name = "submitBTN";
            this.submitBTN.Size = new System.Drawing.Size(175, 41);
            this.submitBTN.TabIndex = 14;
            this.submitBTN.Text = "SUBMIT";
            this.submitBTN.UseVisualStyleBackColor = true;
            this.submitBTN.Click += new System.EventHandler(this.submitBTN_Click);
            // 
            // closeBTN
            // 
            this.closeBTN.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeBTN.Location = new System.Drawing.Point(214, 329);
            this.closeBTN.Name = "closeBTN";
            this.closeBTN.Size = new System.Drawing.Size(175, 41);
            this.closeBTN.TabIndex = 15;
            this.closeBTN.Text = "CLOSE";
            this.closeBTN.UseVisualStyleBackColor = true;
            // 
            // creditIntakeFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 410);
            this.Controls.Add(this.closeBTN);
            this.Controls.Add(this.submitBTN);
            this.Controls.Add(this.CardIssuerLB);
            this.Controls.Add(this.cardLBL);
            this.Controls.Add(this.yearLB);
            this.Controls.Add(this.monthLB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cardNuTB);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cardNuLBL);
            this.Controls.Add(this.fullNameLBL);
            this.Controls.Add(this.headerLBL);
            this.Name = "creditIntakeFRM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Credit Information";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLBL;
        private System.Windows.Forms.Label fullNameLBL;
        private System.Windows.Forms.Label cardNuLBL;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox cardNuTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox monthLB;
        private System.Windows.Forms.ListBox yearLB;
        private System.Windows.Forms.Label cardLBL;
        private System.Windows.Forms.ListBox CardIssuerLB;
        private System.Windows.Forms.Button submitBTN;
        private System.Windows.Forms.Button closeBTN;
    }
}
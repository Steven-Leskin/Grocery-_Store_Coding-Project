namespace SitkaGroceryStore
{
    partial class deliveryIntakeFRM
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
            this.delFullNameLBL = new System.Windows.Forms.Label();
            this.address1LBL = new System.Windows.Forms.Label();
            this.address2LBL = new System.Windows.Forms.Label();
            this.cityLBL = new System.Windows.Forms.Label();
            this.stateLBL = new System.Windows.Forms.Label();
            this.zipLBL = new System.Windows.Forms.Label();
            this.delSubmitBTN = new System.Windows.Forms.Button();
            this.delCloseBTN = new System.Windows.Forms.Button();
            this.delFullNameTB = new System.Windows.Forms.TextBox();
            this.delAddress1TB = new System.Windows.Forms.TextBox();
            this.delAddress2TB = new System.Windows.Forms.TextBox();
            this.delCityTB = new System.Windows.Forms.TextBox();
            this.delStateTB = new System.Windows.Forms.TextBox();
            this.delZipTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // headerLBL
            // 
            this.headerLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLBL.ForeColor = System.Drawing.Color.ForestGreen;
            this.headerLBL.Location = new System.Drawing.Point(0, -1);
            this.headerLBL.Name = "headerLBL";
            this.headerLBL.Size = new System.Drawing.Size(407, 56);
            this.headerLBL.TabIndex = 0;
            this.headerLBL.Text = "SITKA GROCER\r\nDelivery Information";
            this.headerLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // delFullNameLBL
            // 
            this.delFullNameLBL.AutoSize = true;
            this.delFullNameLBL.Location = new System.Drawing.Point(42, 78);
            this.delFullNameLBL.Name = "delFullNameLBL";
            this.delFullNameLBL.Size = new System.Drawing.Size(71, 17);
            this.delFullNameLBL.TabIndex = 1;
            this.delFullNameLBL.Text = "Full Name";
            // 
            // address1LBL
            // 
            this.address1LBL.AutoSize = true;
            this.address1LBL.Location = new System.Drawing.Point(42, 117);
            this.address1LBL.Name = "address1LBL";
            this.address1LBL.Size = new System.Drawing.Size(72, 17);
            this.address1LBL.TabIndex = 2;
            this.address1LBL.Text = "Address 1";
            // 
            // address2LBL
            // 
            this.address2LBL.AutoSize = true;
            this.address2LBL.Location = new System.Drawing.Point(42, 155);
            this.address2LBL.Name = "address2LBL";
            this.address2LBL.Size = new System.Drawing.Size(72, 17);
            this.address2LBL.TabIndex = 3;
            this.address2LBL.Text = "Address 2";
            // 
            // cityLBL
            // 
            this.cityLBL.AutoSize = true;
            this.cityLBL.Location = new System.Drawing.Point(42, 196);
            this.cityLBL.Name = "cityLBL";
            this.cityLBL.Size = new System.Drawing.Size(31, 17);
            this.cityLBL.TabIndex = 4;
            this.cityLBL.Text = "City";
            // 
            // stateLBL
            // 
            this.stateLBL.AutoSize = true;
            this.stateLBL.Location = new System.Drawing.Point(42, 248);
            this.stateLBL.Name = "stateLBL";
            this.stateLBL.Size = new System.Drawing.Size(41, 17);
            this.stateLBL.TabIndex = 5;
            this.stateLBL.Text = "State";
            // 
            // zipLBL
            // 
            this.zipLBL.AutoSize = true;
            this.zipLBL.Location = new System.Drawing.Point(222, 243);
            this.zipLBL.Name = "zipLBL";
            this.zipLBL.Size = new System.Drawing.Size(28, 17);
            this.zipLBL.TabIndex = 6;
            this.zipLBL.Text = "Zip";
            // 
            // delSubmitBTN
            // 
            this.delSubmitBTN.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.delSubmitBTN.Location = new System.Drawing.Point(45, 302);
            this.delSubmitBTN.Name = "delSubmitBTN";
            this.delSubmitBTN.Size = new System.Drawing.Size(147, 43);
            this.delSubmitBTN.TabIndex = 7;
            this.delSubmitBTN.Text = "SUBMIT";
            this.delSubmitBTN.UseVisualStyleBackColor = true;
            this.delSubmitBTN.Click += new System.EventHandler(this.delSubmitBTN_Click);
            // 
            // delCloseBTN
            // 
            this.delCloseBTN.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.delCloseBTN.Location = new System.Drawing.Point(225, 302);
            this.delCloseBTN.Name = "delCloseBTN";
            this.delCloseBTN.Size = new System.Drawing.Size(147, 43);
            this.delCloseBTN.TabIndex = 8;
            this.delCloseBTN.Text = "CLOSE";
            this.delCloseBTN.UseVisualStyleBackColor = true;
            // 
            // delFullNameTB
            // 
            this.delFullNameTB.Location = new System.Drawing.Point(130, 72);
            this.delFullNameTB.Name = "delFullNameTB";
            this.delFullNameTB.Size = new System.Drawing.Size(242, 22);
            this.delFullNameTB.TabIndex = 9;
            // 
            // delAddress1TB
            // 
            this.delAddress1TB.Location = new System.Drawing.Point(130, 117);
            this.delAddress1TB.Name = "delAddress1TB";
            this.delAddress1TB.Size = new System.Drawing.Size(242, 22);
            this.delAddress1TB.TabIndex = 10;
            // 
            // delAddress2TB
            // 
            this.delAddress2TB.Location = new System.Drawing.Point(130, 155);
            this.delAddress2TB.Name = "delAddress2TB";
            this.delAddress2TB.Size = new System.Drawing.Size(242, 22);
            this.delAddress2TB.TabIndex = 11;
            // 
            // delCityTB
            // 
            this.delCityTB.Location = new System.Drawing.Point(130, 196);
            this.delCityTB.Name = "delCityTB";
            this.delCityTB.Size = new System.Drawing.Size(242, 22);
            this.delCityTB.TabIndex = 12;
            // 
            // delStateTB
            // 
            this.delStateTB.Location = new System.Drawing.Point(130, 243);
            this.delStateTB.Name = "delStateTB";
            this.delStateTB.Size = new System.Drawing.Size(62, 22);
            this.delStateTB.TabIndex = 13;
            // 
            // delZipTB
            // 
            this.delZipTB.Location = new System.Drawing.Point(267, 243);
            this.delZipTB.Name = "delZipTB";
            this.delZipTB.Size = new System.Drawing.Size(105, 22);
            this.delZipTB.TabIndex = 14;
            // 
            // deliveryIntakeFRM
            // 
            this.AcceptButton = this.delSubmitBTN;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.delCloseBTN;
            this.ClientSize = new System.Drawing.Size(407, 368);
            this.Controls.Add(this.delZipTB);
            this.Controls.Add(this.delStateTB);
            this.Controls.Add(this.delCityTB);
            this.Controls.Add(this.delAddress2TB);
            this.Controls.Add(this.delAddress1TB);
            this.Controls.Add(this.delFullNameTB);
            this.Controls.Add(this.delCloseBTN);
            this.Controls.Add(this.delSubmitBTN);
            this.Controls.Add(this.zipLBL);
            this.Controls.Add(this.stateLBL);
            this.Controls.Add(this.cityLBL);
            this.Controls.Add(this.address2LBL);
            this.Controls.Add(this.address1LBL);
            this.Controls.Add(this.delFullNameLBL);
            this.Controls.Add(this.headerLBL);
            this.Name = "deliveryIntakeFRM";
            this.Text = "Delivery Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLBL;
        private System.Windows.Forms.Label delFullNameLBL;
        private System.Windows.Forms.Label address1LBL;
        private System.Windows.Forms.Label address2LBL;
        private System.Windows.Forms.Label cityLBL;
        private System.Windows.Forms.Label stateLBL;
        private System.Windows.Forms.Label zipLBL;
        private System.Windows.Forms.Button delSubmitBTN;
        private System.Windows.Forms.Button delCloseBTN;
        private System.Windows.Forms.TextBox delFullNameTB;
        private System.Windows.Forms.TextBox delAddress1TB;
        private System.Windows.Forms.TextBox delAddress2TB;
        private System.Windows.Forms.TextBox delCityTB;
        private System.Windows.Forms.TextBox delStateTB;
        private System.Windows.Forms.TextBox delZipTB;
    }
}
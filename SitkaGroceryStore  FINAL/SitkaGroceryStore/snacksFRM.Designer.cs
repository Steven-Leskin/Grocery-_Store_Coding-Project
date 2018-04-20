namespace SitkaGroceryStore
{
    partial class snacksFRM
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
            this.addBTN = new System.Windows.Forms.Button();
            this.removeBTN = new System.Windows.Forms.Button();
            this.descriptionLBL = new System.Windows.Forms.Label();
            this.UOM_LB = new System.Windows.Forms.ListBox();
            this.unitPriceDisplayLBL = new System.Windows.Forms.Label();
            this.quantityNU = new System.Windows.Forms.NumericUpDown();
            this.itemSubTotalLBL = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // addBTN
            // 
            this.addBTN.Location = new System.Drawing.Point(616, 118);
            this.addBTN.Name = "addBTN";
            this.addBTN.Size = new System.Drawing.Size(113, 41);
            this.addBTN.TabIndex = 0;
            this.addBTN.Text = "PURCHASE";
            this.addBTN.UseVisualStyleBackColor = true;
            // 
            // removeBTN
            // 
            this.removeBTN.Location = new System.Drawing.Point(745, 118);
            this.removeBTN.Name = "removeBTN";
            this.removeBTN.Size = new System.Drawing.Size(113, 41);
            this.removeBTN.TabIndex = 1;
            this.removeBTN.Text = "REMOVE";
            this.removeBTN.UseVisualStyleBackColor = true;
            this.removeBTN.Click += new System.EventHandler(this.removeBTN_Click);
            // 
            // descriptionLBL
            // 
            this.descriptionLBL.Font = new System.Drawing.Font("Papyrus", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLBL.Location = new System.Drawing.Point(260, 13);
            this.descriptionLBL.Name = "descriptionLBL";
            this.descriptionLBL.Size = new System.Drawing.Size(175, 146);
            this.descriptionLBL.TabIndex = 3;
            this.descriptionLBL.Text = "Token healthy snack...";
            // 
            // UOM_LB
            // 
            this.UOM_LB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UOM_LB.FormattingEnabled = true;
            this.UOM_LB.ItemHeight = 20;
            this.UOM_LB.Items.AddRange(new object[] {
            "Small",
            "Large"});
            this.UOM_LB.Location = new System.Drawing.Point(441, 22);
            this.UOM_LB.Name = "UOM_LB";
            this.UOM_LB.Size = new System.Drawing.Size(147, 44);
            this.UOM_LB.TabIndex = 4;
            this.UOM_LB.SelectedIndexChanged += new System.EventHandler(this.UOM_LB_SelectedIndexChanged);
            // 
            // unitPriceDisplayLBL
            // 
            this.unitPriceDisplayLBL.AutoSize = true;
            this.unitPriceDisplayLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitPriceDisplayLBL.Location = new System.Drawing.Point(502, 81);
            this.unitPriceDisplayLBL.Name = "unitPriceDisplayLBL";
            this.unitPriceDisplayLBL.Size = new System.Drawing.Size(227, 25);
            this.unitPriceDisplayLBL.TabIndex = 5;
            this.unitPriceDisplayLBL.Text = "Select Size and Quantity";
            // 
            // quantityNU
            // 
            this.quantityNU.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityNU.Location = new System.Drawing.Point(616, 22);
            this.quantityNU.Name = "quantityNU";
            this.quantityNU.Size = new System.Drawing.Size(113, 22);
            this.quantityNU.TabIndex = 6;
            this.quantityNU.ValueChanged += new System.EventHandler(this.quantityNU_ValueChanged);
            // 
            // itemSubTotalLBL
            // 
            this.itemSubTotalLBL.AutoSize = true;
            this.itemSubTotalLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemSubTotalLBL.Location = new System.Drawing.Point(738, 53);
            this.itemSubTotalLBL.Name = "itemSubTotalLBL";
            this.itemSubTotalLBL.Size = new System.Drawing.Size(131, 38);
            this.itemSubTotalLBL.TabIndex = 7;
            this.itemSubTotalLBL.Text = "subtotal";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SitkaGroceryStore.Properties.Resources.Snacks;
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(241, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // snacksFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(900, 180);
            this.Controls.Add(this.itemSubTotalLBL);
            this.Controls.Add(this.quantityNU);
            this.Controls.Add(this.unitPriceDisplayLBL);
            this.Controls.Add(this.UOM_LB);
            this.Controls.Add(this.descriptionLBL);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.removeBTN);
            this.Controls.Add(this.addBTN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "snacksFRM";
            this.Text = "masterFRM";
            ((System.ComponentModel.ISupportInitialize)(this.quantityNU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addBTN;
        private System.Windows.Forms.Button removeBTN;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label descriptionLBL;
        private System.Windows.Forms.ListBox UOM_LB;
        private System.Windows.Forms.Label unitPriceDisplayLBL;
        private System.Windows.Forms.NumericUpDown quantityNU;
        private System.Windows.Forms.Label itemSubTotalLBL;
    }
}
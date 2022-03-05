namespace Product_Management_System
{
    partial class frm_Update_Product_Details
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
            this.cmb_Net_Weight = new System.Windows.Forms.ComboBox();
            this.lbl_Net_Weight = new System.Windows.Forms.Label();
            this.dtp_Expiry_Date = new System.Windows.Forms.DateTimePicker();
            this.dtp_Mfg_Date = new System.Windows.Forms.DateTimePicker();
            this.tb_MRP = new System.Windows.Forms.TextBox();
            this.lbl_MRP = new System.Windows.Forms.Label();
            this.lbl_Expiry_Date = new System.Windows.Forms.Label();
            this.lbl_Mfg_Date = new System.Windows.Forms.Label();
            this.btn_Update = new System.Windows.Forms.Button();
            this.lbl_Update_Product_Details = new System.Windows.Forms.Label();
            this.tb_Product_Name = new System.Windows.Forms.TextBox();
            this.tb_Product_Id = new System.Windows.Forms.TextBox();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_Product_Id = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmb_Net_Weight
            // 
            this.cmb_Net_Weight.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Net_Weight.Font = new System.Drawing.Font("Microsoft Uighur", 20F);
            this.cmb_Net_Weight.FormattingEnabled = true;
            this.cmb_Net_Weight.Items.AddRange(new object[] {
            "10 ml",
            "50 ml",
            "100 ml",
            "150 ml",
            "250 ml",
            "500 ml",
            "750 ml",
            "1 l"});
            this.cmb_Net_Weight.Location = new System.Drawing.Point(674, 637);
            this.cmb_Net_Weight.Name = "cmb_Net_Weight";
            this.cmb_Net_Weight.Size = new System.Drawing.Size(343, 51);
            this.cmb_Net_Weight.TabIndex = 36;
            // 
            // lbl_Net_Weight
            // 
            this.lbl_Net_Weight.AutoSize = true;
            this.lbl_Net_Weight.Font = new System.Drawing.Font("Microsoft Uighur", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Net_Weight.Location = new System.Drawing.Point(169, 626);
            this.lbl_Net_Weight.Name = "lbl_Net_Weight";
            this.lbl_Net_Weight.Size = new System.Drawing.Size(175, 52);
            this.lbl_Net_Weight.TabIndex = 35;
            this.lbl_Net_Weight.Text = "Net Weight";
            // 
            // dtp_Expiry_Date
            // 
            this.dtp_Expiry_Date.Font = new System.Drawing.Font("Microsoft Uighur", 20F);
            this.dtp_Expiry_Date.Location = new System.Drawing.Point(674, 445);
            this.dtp_Expiry_Date.Name = "dtp_Expiry_Date";
            this.dtp_Expiry_Date.Size = new System.Drawing.Size(343, 44);
            this.dtp_Expiry_Date.TabIndex = 34;
            // 
            // dtp_Mfg_Date
            // 
            this.dtp_Mfg_Date.Font = new System.Drawing.Font("Microsoft Uighur", 20F);
            this.dtp_Mfg_Date.Location = new System.Drawing.Point(674, 349);
            this.dtp_Mfg_Date.Name = "dtp_Mfg_Date";
            this.dtp_Mfg_Date.Size = new System.Drawing.Size(343, 44);
            this.dtp_Mfg_Date.TabIndex = 33;
            // 
            // tb_MRP
            // 
            this.tb_MRP.Font = new System.Drawing.Font("Microsoft Uighur", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_MRP.Location = new System.Drawing.Point(674, 542);
            this.tb_MRP.Name = "tb_MRP";
            this.tb_MRP.Size = new System.Drawing.Size(343, 44);
            this.tb_MRP.TabIndex = 32;
            // 
            // lbl_MRP
            // 
            this.lbl_MRP.AutoSize = true;
            this.lbl_MRP.Font = new System.Drawing.Font("Microsoft Uighur", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MRP.Location = new System.Drawing.Point(169, 534);
            this.lbl_MRP.Name = "lbl_MRP";
            this.lbl_MRP.Size = new System.Drawing.Size(92, 52);
            this.lbl_MRP.TabIndex = 31;
            this.lbl_MRP.Text = "MRP";
            // 
            // lbl_Expiry_Date
            // 
            this.lbl_Expiry_Date.AutoSize = true;
            this.lbl_Expiry_Date.Font = new System.Drawing.Font("Microsoft Uighur", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Expiry_Date.Location = new System.Drawing.Point(169, 445);
            this.lbl_Expiry_Date.Name = "lbl_Expiry_Date";
            this.lbl_Expiry_Date.Size = new System.Drawing.Size(182, 52);
            this.lbl_Expiry_Date.TabIndex = 30;
            this.lbl_Expiry_Date.Text = "Expiry Date";
            // 
            // lbl_Mfg_Date
            // 
            this.lbl_Mfg_Date.AutoSize = true;
            this.lbl_Mfg_Date.Font = new System.Drawing.Font("Microsoft Uighur", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mfg_Date.Location = new System.Drawing.Point(169, 349);
            this.lbl_Mfg_Date.Name = "lbl_Mfg_Date";
            this.lbl_Mfg_Date.Size = new System.Drawing.Size(147, 52);
            this.lbl_Mfg_Date.TabIndex = 29;
            this.lbl_Mfg_Date.Text = "Mfg Date";
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.Orange;
            this.btn_Update.Font = new System.Drawing.Font("Microsoft Uighur", 22F, System.Drawing.FontStyle.Bold);
            this.btn_Update.Location = new System.Drawing.Point(568, 731);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(166, 51);
            this.btn_Update.TabIndex = 27;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // lbl_Update_Product_Details
            // 
            this.lbl_Update_Product_Details.AutoSize = true;
            this.lbl_Update_Product_Details.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 55F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Update_Product_Details.Location = new System.Drawing.Point(49, 18);
            this.lbl_Update_Product_Details.Name = "lbl_Update_Product_Details";
            this.lbl_Update_Product_Details.Size = new System.Drawing.Size(1073, 92);
            this.lbl_Update_Product_Details.TabIndex = 0;
            this.lbl_Update_Product_Details.Text = "Update Product Details";
            // 
            // tb_Product_Name
            // 
            this.tb_Product_Name.Font = new System.Drawing.Font("Microsoft Uighur", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Product_Name.Location = new System.Drawing.Point(674, 258);
            this.tb_Product_Name.Name = "tb_Product_Name";
            this.tb_Product_Name.Size = new System.Drawing.Size(343, 44);
            this.tb_Product_Name.TabIndex = 26;
            // 
            // tb_Product_Id
            // 
            this.tb_Product_Id.Font = new System.Drawing.Font("Microsoft Uighur", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Product_Id.Location = new System.Drawing.Point(674, 168);
            this.tb_Product_Id.Name = "tb_Product_Id";
            this.tb_Product_Id.Size = new System.Drawing.Size(343, 44);
            this.tb_Product_Id.TabIndex = 25;
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("Microsoft Uighur", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.Location = new System.Drawing.Point(169, 250);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(213, 52);
            this.lbl_Password.TabIndex = 24;
            this.lbl_Password.Text = "Product Name";
            // 
            // lbl_Product_Id
            // 
            this.lbl_Product_Id.AutoSize = true;
            this.lbl_Product_Id.Font = new System.Drawing.Font("Microsoft Uighur", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product_Id.Location = new System.Drawing.Point(169, 160);
            this.lbl_Product_Id.Name = "lbl_Product_Id";
            this.lbl_Product_Id.Size = new System.Drawing.Size(163, 52);
            this.lbl_Product_Id.TabIndex = 23;
            this.lbl_Product_Id.Text = "Product Id";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.HotPink;
            this.panel1.Controls.Add(this.lbl_Update_Product_Details);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1221, 133);
            this.panel1.TabIndex = 28;
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.Orange;
            this.btn_Search.Font = new System.Drawing.Font("Microsoft Uighur", 22F, System.Drawing.FontStyle.Bold);
            this.btn_Search.Location = new System.Drawing.Point(266, 731);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(166, 51);
            this.btn_Search.TabIndex = 37;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.Orange;
            this.btn_Refresh.Font = new System.Drawing.Font("Microsoft Uighur", 22F, System.Drawing.FontStyle.Bold);
            this.btn_Refresh.Location = new System.Drawing.Point(851, 731);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(166, 51);
            this.btn_Refresh.TabIndex = 38;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // frm_Update_Product_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1152, 806);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.cmb_Net_Weight);
            this.Controls.Add(this.lbl_Net_Weight);
            this.Controls.Add(this.dtp_Expiry_Date);
            this.Controls.Add(this.dtp_Mfg_Date);
            this.Controls.Add(this.tb_MRP);
            this.Controls.Add(this.lbl_MRP);
            this.Controls.Add(this.lbl_Expiry_Date);
            this.Controls.Add(this.lbl_Mfg_Date);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.tb_Product_Name);
            this.Controls.Add(this.tb_Product_Id);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_Product_Id);
            this.Controls.Add(this.panel1);
            this.Name = "frm_Update_Product_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Update Product Details";
            this.Load += new System.EventHandler(this.frm_Update_Product_Details_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_Net_Weight;
        private System.Windows.Forms.Label lbl_Net_Weight;
        private System.Windows.Forms.DateTimePicker dtp_Expiry_Date;
        private System.Windows.Forms.DateTimePicker dtp_Mfg_Date;
        private System.Windows.Forms.TextBox tb_MRP;
        private System.Windows.Forms.Label lbl_MRP;
        private System.Windows.Forms.Label lbl_Expiry_Date;
        private System.Windows.Forms.Label lbl_Mfg_Date;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Label lbl_Update_Product_Details;
        private System.Windows.Forms.TextBox tb_Product_Name;
        private System.Windows.Forms.TextBox tb_Product_Id;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_Product_Id;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_Refresh;
    }
}
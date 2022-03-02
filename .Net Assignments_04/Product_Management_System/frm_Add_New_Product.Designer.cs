namespace Product_Management_System
{
    partial class frm_Add_New_Product
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
            this.btn_Save = new System.Windows.Forms.Button();
            this.tb_Product_Name = new System.Windows.Forms.TextBox();
            this.lbl_Add_New_Product = new System.Windows.Forms.Label();
            this.tb_Product_Id = new System.Windows.Forms.TextBox();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_Product_Id = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Expiry_Date = new System.Windows.Forms.Label();
            this.lbl_Mfg_Date = new System.Windows.Forms.Label();
            this.tb_MRP = new System.Windows.Forms.TextBox();
            this.lbl_MRP = new System.Windows.Forms.Label();
            this.dtp_Mfg_Date = new System.Windows.Forms.DateTimePicker();
            this.dtp_Expiry_Date = new System.Windows.Forms.DateTimePicker();
            this.lbl_Net_Weight = new System.Windows.Forms.Label();
            this.cmb_Net_Weight = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.Orange;
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Uighur", 22F, System.Drawing.FontStyle.Bold);
            this.btn_Save.Location = new System.Drawing.Point(471, 737);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(166, 51);
            this.btn_Save.TabIndex = 7;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // tb_Product_Name
            // 
            this.tb_Product_Name.Font = new System.Drawing.Font("Microsoft Uighur", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Product_Name.Location = new System.Drawing.Point(671, 259);
            this.tb_Product_Name.MaxLength = 20;
            this.tb_Product_Name.Name = "tb_Product_Name";
            this.tb_Product_Name.Size = new System.Drawing.Size(343, 44);
            this.tb_Product_Name.TabIndex = 2;
            // 
            // lbl_Add_New_Product
            // 
            this.lbl_Add_New_Product.AutoSize = true;
            this.lbl_Add_New_Product.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 55F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Add_New_Product.Location = new System.Drawing.Point(247, 17);
            this.lbl_Add_New_Product.Name = "lbl_Add_New_Product";
            this.lbl_Add_New_Product.Size = new System.Drawing.Size(744, 92);
            this.lbl_Add_New_Product.TabIndex = 0;
            this.lbl_Add_New_Product.Text = "Add New Product";
            // 
            // tb_Product_Id
            // 
            this.tb_Product_Id.Enabled = false;
            this.tb_Product_Id.Font = new System.Drawing.Font("Microsoft Uighur", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Product_Id.Location = new System.Drawing.Point(671, 169);
            this.tb_Product_Id.MaxLength = 4;
            this.tb_Product_Id.Name = "tb_Product_Id";
            this.tb_Product_Id.Size = new System.Drawing.Size(343, 44);
            this.tb_Product_Id.TabIndex = 1;
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("Microsoft Uighur", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.Location = new System.Drawing.Point(166, 251);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(213, 52);
            this.lbl_Password.TabIndex = 8;
            this.lbl_Password.Text = "Product Name";
            // 
            // lbl_Product_Id
            // 
            this.lbl_Product_Id.AutoSize = true;
            this.lbl_Product_Id.Font = new System.Drawing.Font("Microsoft Uighur", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product_Id.Location = new System.Drawing.Point(166, 161);
            this.lbl_Product_Id.Name = "lbl_Product_Id";
            this.lbl_Product_Id.Size = new System.Drawing.Size(163, 52);
            this.lbl_Product_Id.TabIndex = 7;
            this.lbl_Product_Id.Text = "Product Id";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.HotPink;
            this.panel1.Controls.Add(this.lbl_Add_New_Product);
            this.panel1.Location = new System.Drawing.Point(-3, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1221, 133);
            this.panel1.TabIndex = 12;
            // 
            // lbl_Expiry_Date
            // 
            this.lbl_Expiry_Date.AutoSize = true;
            this.lbl_Expiry_Date.Font = new System.Drawing.Font("Microsoft Uighur", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Expiry_Date.Location = new System.Drawing.Point(166, 446);
            this.lbl_Expiry_Date.Name = "lbl_Expiry_Date";
            this.lbl_Expiry_Date.Size = new System.Drawing.Size(182, 52);
            this.lbl_Expiry_Date.TabIndex = 14;
            this.lbl_Expiry_Date.Text = "Expiry Date";
            // 
            // lbl_Mfg_Date
            // 
            this.lbl_Mfg_Date.AutoSize = true;
            this.lbl_Mfg_Date.Font = new System.Drawing.Font("Microsoft Uighur", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mfg_Date.Location = new System.Drawing.Point(166, 350);
            this.lbl_Mfg_Date.Name = "lbl_Mfg_Date";
            this.lbl_Mfg_Date.Size = new System.Drawing.Size(147, 52);
            this.lbl_Mfg_Date.TabIndex = 13;
            this.lbl_Mfg_Date.Text = "Mfg Date";
            // 
            // tb_MRP
            // 
            this.tb_MRP.Font = new System.Drawing.Font("Microsoft Uighur", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_MRP.Location = new System.Drawing.Point(671, 543);
            this.tb_MRP.MaxLength = 5;
            this.tb_MRP.Name = "tb_MRP";
            this.tb_MRP.Size = new System.Drawing.Size(343, 44);
            this.tb_MRP.TabIndex = 5;
            // 
            // lbl_MRP
            // 
            this.lbl_MRP.AutoSize = true;
            this.lbl_MRP.Font = new System.Drawing.Font("Microsoft Uighur", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MRP.Location = new System.Drawing.Point(166, 535);
            this.lbl_MRP.Name = "lbl_MRP";
            this.lbl_MRP.Size = new System.Drawing.Size(92, 52);
            this.lbl_MRP.TabIndex = 17;
            this.lbl_MRP.Text = "MRP";
            // 
            // dtp_Mfg_Date
            // 
            this.dtp_Mfg_Date.Font = new System.Drawing.Font("Microsoft Uighur", 20F);
            this.dtp_Mfg_Date.Location = new System.Drawing.Point(671, 350);
            this.dtp_Mfg_Date.Name = "dtp_Mfg_Date";
            this.dtp_Mfg_Date.Size = new System.Drawing.Size(343, 44);
            this.dtp_Mfg_Date.TabIndex = 3;
            // 
            // dtp_Expiry_Date
            // 
            this.dtp_Expiry_Date.Font = new System.Drawing.Font("Microsoft Uighur", 20F);
            this.dtp_Expiry_Date.Location = new System.Drawing.Point(671, 446);
            this.dtp_Expiry_Date.Name = "dtp_Expiry_Date";
            this.dtp_Expiry_Date.Size = new System.Drawing.Size(343, 44);
            this.dtp_Expiry_Date.TabIndex = 4;
            // 
            // lbl_Net_Weight
            // 
            this.lbl_Net_Weight.AutoSize = true;
            this.lbl_Net_Weight.Font = new System.Drawing.Font("Microsoft Uighur", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Net_Weight.Location = new System.Drawing.Point(166, 627);
            this.lbl_Net_Weight.Name = "lbl_Net_Weight";
            this.lbl_Net_Weight.Size = new System.Drawing.Size(175, 52);
            this.lbl_Net_Weight.TabIndex = 21;
            this.lbl_Net_Weight.Text = "Net Weight";
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
            this.cmb_Net_Weight.Location = new System.Drawing.Point(671, 638);
            this.cmb_Net_Weight.Name = "cmb_Net_Weight";
            this.cmb_Net_Weight.Size = new System.Drawing.Size(343, 51);
            this.cmb_Net_Weight.TabIndex = 6;
            // 
            // frm_Add_New_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1152, 806);
            this.ControlBox = false;
            this.Controls.Add(this.cmb_Net_Weight);
            this.Controls.Add(this.lbl_Net_Weight);
            this.Controls.Add(this.dtp_Expiry_Date);
            this.Controls.Add(this.dtp_Mfg_Date);
            this.Controls.Add(this.tb_MRP);
            this.Controls.Add(this.lbl_MRP);
            this.Controls.Add(this.lbl_Expiry_Date);
            this.Controls.Add(this.lbl_Mfg_Date);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.tb_Product_Name);
            this.Controls.Add(this.tb_Product_Id);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_Product_Id);
            this.Controls.Add(this.panel1);
            this.Name = "frm_Add_New_Product";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = " ";
            this.Load += new System.EventHandler(this.frm_Add_New_Product_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TextBox tb_Product_Name;
        private System.Windows.Forms.Label lbl_Add_New_Product;
        private System.Windows.Forms.TextBox tb_Product_Id;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_Product_Id;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Expiry_Date;
        private System.Windows.Forms.Label lbl_Mfg_Date;
        private System.Windows.Forms.TextBox tb_MRP;
        private System.Windows.Forms.Label lbl_MRP;
        private System.Windows.Forms.DateTimePicker dtp_Mfg_Date;
        private System.Windows.Forms.DateTimePicker dtp_Expiry_Date;
        private System.Windows.Forms.Label lbl_Net_Weight;
        private System.Windows.Forms.ComboBox cmb_Net_Weight;
    }
}
namespace Staff_Management_System
{
    partial class frm_Update_Department
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
            this.tb_Department_Name = new System.Windows.Forms.TextBox();
            this.lbl_Department_Name = new System.Windows.Forms.Label();
            this.tb_Department_Id = new System.Windows.Forms.TextBox();
            this.pnl_Department = new System.Windows.Forms.Panel();
            this.btn_Update = new System.Windows.Forms.Button();
            this.lbl_Update_Department = new System.Windows.Forms.Label();
            this.pnl_Update_Department = new System.Windows.Forms.Panel();
            this.lbl_Department_Id = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.pnl_Department.SuspendLayout();
            this.pnl_Update_Department.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_Department_Name
            // 
            this.tb_Department_Name.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold);
            this.tb_Department_Name.Location = new System.Drawing.Point(854, 479);
            this.tb_Department_Name.Name = "tb_Department_Name";
            this.tb_Department_Name.Size = new System.Drawing.Size(329, 40);
            this.tb_Department_Name.TabIndex = 22;
            // 
            // lbl_Department_Name
            // 
            this.lbl_Department_Name.AutoSize = true;
            this.lbl_Department_Name.Font = new System.Drawing.Font("Microsoft Uighur", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Department_Name.Location = new System.Drawing.Point(418, 479);
            this.lbl_Department_Name.Name = "lbl_Department_Name";
            this.lbl_Department_Name.Size = new System.Drawing.Size(267, 52);
            this.lbl_Department_Name.TabIndex = 25;
            this.lbl_Department_Name.Text = "Department Name";
            // 
            // tb_Department_Id
            // 
            this.tb_Department_Id.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold);
            this.tb_Department_Id.Location = new System.Drawing.Point(854, 348);
            this.tb_Department_Id.Name = "tb_Department_Id";
            this.tb_Department_Id.Size = new System.Drawing.Size(329, 40);
            this.tb_Department_Id.TabIndex = 21;
            // 
            // pnl_Department
            // 
            this.pnl_Department.BackColor = System.Drawing.Color.Snow;
            this.pnl_Department.Controls.Add(this.btn_Search);
            this.pnl_Department.Controls.Add(this.btn_Update);
            this.pnl_Department.Location = new System.Drawing.Point(230, 217);
            this.pnl_Department.Name = "pnl_Department";
            this.pnl_Department.Size = new System.Drawing.Size(1080, 471);
            this.pnl_Department.TabIndex = 26;
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.Coral;
            this.btn_Update.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.Location = new System.Drawing.Point(633, 382);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(128, 56);
            this.btn_Update.TabIndex = 3;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // lbl_Update_Department
            // 
            this.lbl_Update_Department.AutoSize = true;
            this.lbl_Update_Department.Font = new System.Drawing.Font("Microsoft Uighur", 70F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Update_Department.Location = new System.Drawing.Point(422, -13);
            this.lbl_Update_Department.Name = "lbl_Update_Department";
            this.lbl_Update_Department.Size = new System.Drawing.Size(719, 152);
            this.lbl_Update_Department.TabIndex = 0;
            this.lbl_Update_Department.Text = "Update Department";
            // 
            // pnl_Update_Department
            // 
            this.pnl_Update_Department.BackColor = System.Drawing.Color.MistyRose;
            this.pnl_Update_Department.Controls.Add(this.lbl_Update_Department);
            this.pnl_Update_Department.Location = new System.Drawing.Point(3, 0);
            this.pnl_Update_Department.Name = "pnl_Update_Department";
            this.pnl_Update_Department.Size = new System.Drawing.Size(1508, 124);
            this.pnl_Update_Department.TabIndex = 24;
            // 
            // lbl_Department_Id
            // 
            this.lbl_Department_Id.AutoSize = true;
            this.lbl_Department_Id.Font = new System.Drawing.Font("Microsoft Uighur", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Department_Id.Location = new System.Drawing.Point(418, 348);
            this.lbl_Department_Id.Name = "lbl_Department_Id";
            this.lbl_Department_Id.Size = new System.Drawing.Size(217, 52);
            this.lbl_Department_Id.TabIndex = 23;
            this.lbl_Department_Id.Text = "Department Id";
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.Coral;
            this.btn_Search.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(327, 382);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(128, 56);
            this.btn_Search.TabIndex = 4;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // frm_Update_Department
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1504, 795);
            this.ControlBox = false;
            this.Controls.Add(this.tb_Department_Name);
            this.Controls.Add(this.lbl_Department_Name);
            this.Controls.Add(this.tb_Department_Id);
            this.Controls.Add(this.pnl_Update_Department);
            this.Controls.Add(this.lbl_Department_Id);
            this.Controls.Add(this.pnl_Department);
            this.Name = "frm_Update_Department";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Update Department";
            this.Load += new System.EventHandler(this.frm_Update_Department_Load);
            this.pnl_Department.ResumeLayout(false);
            this.pnl_Update_Department.ResumeLayout(false);
            this.pnl_Update_Department.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Department_Name;
        private System.Windows.Forms.Label lbl_Department_Name;
        private System.Windows.Forms.TextBox tb_Department_Id;
        private System.Windows.Forms.Panel pnl_Department;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Label lbl_Update_Department;
        private System.Windows.Forms.Panel pnl_Update_Department;
        private System.Windows.Forms.Label lbl_Department_Id;
        private System.Windows.Forms.Button btn_Search;
    }
}
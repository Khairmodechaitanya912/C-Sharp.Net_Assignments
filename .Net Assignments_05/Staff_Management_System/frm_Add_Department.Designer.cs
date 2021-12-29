namespace Staff_Management_System
{
    partial class frm_Add_Department
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
            this.lbl_Department_Id = new System.Windows.Forms.Label();
            this.pnl_Add_Department = new System.Windows.Forms.Panel();
            this.lbl_Add_Department = new System.Windows.Forms.Label();
            this.tb_Department_Id = new System.Windows.Forms.TextBox();
            this.tb_Department_Name = new System.Windows.Forms.TextBox();
            this.lbl_Department_Name = new System.Windows.Forms.Label();
            this.pnl_Department = new System.Windows.Forms.Panel();
            this.btn_Save = new System.Windows.Forms.Button();
            this.pnl_Add_Department.SuspendLayout();
            this.pnl_Department.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Department_Id
            // 
            this.lbl_Department_Id.AutoSize = true;
            this.lbl_Department_Id.Font = new System.Drawing.Font("Microsoft Uighur", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Department_Id.Location = new System.Drawing.Point(415, 349);
            this.lbl_Department_Id.Name = "lbl_Department_Id";
            this.lbl_Department_Id.Size = new System.Drawing.Size(217, 52);
            this.lbl_Department_Id.TabIndex = 15;
            this.lbl_Department_Id.Text = "Department Id";
            // 
            // pnl_Add_Department
            // 
            this.pnl_Add_Department.BackColor = System.Drawing.Color.MistyRose;
            this.pnl_Add_Department.Controls.Add(this.lbl_Add_Department);
            this.pnl_Add_Department.Location = new System.Drawing.Point(0, 1);
            this.pnl_Add_Department.Name = "pnl_Add_Department";
            this.pnl_Add_Department.Size = new System.Drawing.Size(1508, 124);
            this.pnl_Add_Department.TabIndex = 16;
            // 
            // lbl_Add_Department
            // 
            this.lbl_Add_Department.AutoSize = true;
            this.lbl_Add_Department.Font = new System.Drawing.Font("Microsoft Uighur", 70F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Add_Department.Location = new System.Drawing.Point(422, -13);
            this.lbl_Add_Department.Name = "lbl_Add_Department";
            this.lbl_Add_Department.Size = new System.Drawing.Size(619, 152);
            this.lbl_Add_Department.TabIndex = 0;
            this.lbl_Add_Department.Text = "Add Department";
            // 
            // tb_Department_Id
            // 
            this.tb_Department_Id.Enabled = false;
            this.tb_Department_Id.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold);
            this.tb_Department_Id.Location = new System.Drawing.Point(851, 349);
            this.tb_Department_Id.Name = "tb_Department_Id";
            this.tb_Department_Id.Size = new System.Drawing.Size(329, 40);
            this.tb_Department_Id.TabIndex = 1;
            // 
            // tb_Department_Name
            // 
            this.tb_Department_Name.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold);
            this.tb_Department_Name.Location = new System.Drawing.Point(851, 480);
            this.tb_Department_Name.Name = "tb_Department_Name";
            this.tb_Department_Name.Size = new System.Drawing.Size(329, 40);
            this.tb_Department_Name.TabIndex = 2;
            // 
            // lbl_Department_Name
            // 
            this.lbl_Department_Name.AutoSize = true;
            this.lbl_Department_Name.Font = new System.Drawing.Font("Microsoft Uighur", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Department_Name.Location = new System.Drawing.Point(415, 480);
            this.lbl_Department_Name.Name = "lbl_Department_Name";
            this.lbl_Department_Name.Size = new System.Drawing.Size(267, 52);
            this.lbl_Department_Name.TabIndex = 18;
            this.lbl_Department_Name.Text = "Department Name";
            // 
            // pnl_Department
            // 
            this.pnl_Department.BackColor = System.Drawing.Color.Snow;
            this.pnl_Department.Controls.Add(this.btn_Save);
            this.pnl_Department.Location = new System.Drawing.Point(227, 218);
            this.pnl_Department.Name = "pnl_Department";
            this.pnl_Department.Size = new System.Drawing.Size(1080, 471);
            this.pnl_Department.TabIndex = 20;
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.Coral;
            this.btn_Save.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(480, 382);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(128, 56);
            this.btn_Save.TabIndex = 3;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // frm_Add_Department
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1504, 795);
            this.ControlBox = false;
            this.Controls.Add(this.tb_Department_Name);
            this.Controls.Add(this.lbl_Department_Name);
            this.Controls.Add(this.tb_Department_Id);
            this.Controls.Add(this.pnl_Add_Department);
            this.Controls.Add(this.lbl_Department_Id);
            this.Controls.Add(this.pnl_Department);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Add_Department";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Department";
            this.Load += new System.EventHandler(this.frm_Add_Department_Load);
            this.pnl_Add_Department.ResumeLayout(false);
            this.pnl_Add_Department.PerformLayout();
            this.pnl_Department.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Department_Id;
        private System.Windows.Forms.Panel pnl_Add_Department;
        private System.Windows.Forms.Label lbl_Add_Department;
        private System.Windows.Forms.TextBox tb_Department_Id;
        private System.Windows.Forms.TextBox tb_Department_Name;
        private System.Windows.Forms.Label lbl_Department_Name;
        private System.Windows.Forms.Panel pnl_Department;
        private System.Windows.Forms.Button btn_Save;
    }
}
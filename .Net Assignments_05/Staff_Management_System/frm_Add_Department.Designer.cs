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
            this.pnl_Add_Department.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Department_Id
            // 
            this.lbl_Department_Id.AutoSize = true;
            this.lbl_Department_Id.Font = new System.Drawing.Font("Microsoft Uighur", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Department_Id.Location = new System.Drawing.Point(311, 298);
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
            this.lbl_Add_Department.Location = new System.Drawing.Point(505, -6);
            this.lbl_Add_Department.Name = "lbl_Add_Department";
            this.lbl_Add_Department.Size = new System.Drawing.Size(619, 152);
            this.lbl_Add_Department.TabIndex = 0;
            this.lbl_Add_Department.Text = "Add Department";
            // 
            // tb_Department_Id
            // 
            this.tb_Department_Id.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold);
            this.tb_Department_Id.Location = new System.Drawing.Point(616, 305);
            this.tb_Department_Id.Name = "tb_Department_Id";
            this.tb_Department_Id.Size = new System.Drawing.Size(329, 40);
            this.tb_Department_Id.TabIndex = 17;
            // 
            // frm_Add_Department
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1504, 795);
            this.ControlBox = false;
            this.Controls.Add(this.tb_Department_Id);
            this.Controls.Add(this.pnl_Add_Department);
            this.Controls.Add(this.lbl_Department_Id);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Add_Department";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Department";
            this.pnl_Add_Department.ResumeLayout(false);
            this.pnl_Add_Department.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Department_Id;
        private System.Windows.Forms.Panel pnl_Add_Department;
        private System.Windows.Forms.Label lbl_Add_Department;
        private System.Windows.Forms.TextBox tb_Department_Id;
    }
}
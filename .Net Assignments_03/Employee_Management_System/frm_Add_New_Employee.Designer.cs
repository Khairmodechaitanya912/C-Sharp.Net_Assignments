namespace Employee_Management_System
{
    partial class frm_Add_New_Employee
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
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.tb_Employee_Id = new System.Windows.Forms.TextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Emp_Id = new System.Windows.Forms.Label();
            this.lbl_Login_Form = new System.Windows.Forms.Label();
            this.tb_Mobile_No = new System.Windows.Forms.TextBox();
            this.lbl_Mobile_No = new System.Windows.Forms.Label();
            this.lbl_Date_Of_Birth = new System.Windows.Forms.Label();
            this.dtp_DOB = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_Department = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // tb_Name
            // 
            this.tb_Name.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F);
            this.tb_Name.Location = new System.Drawing.Point(721, 270);
            this.tb_Name.MaxLength = 30;
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(380, 50);
            this.tb_Name.TabIndex = 2;
            // 
            // tb_Employee_Id
            // 
            this.tb_Employee_Id.Enabled = false;
            this.tb_Employee_Id.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F);
            this.tb_Employee_Id.Location = new System.Drawing.Point(721, 179);
            this.tb_Employee_Id.MaxLength = 4;
            this.tb_Employee_Id.Name = "tb_Employee_Id";
            this.tb_Employee_Id.Size = new System.Drawing.Size(380, 50);
            this.tb_Employee_Id.TabIndex = 1;
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.IndianRed;
            this.btn_Save.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F);
            this.btn_Save.Location = new System.Drawing.Point(508, 698);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(131, 51);
            this.btn_Save.TabIndex = 6;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.BackColor = System.Drawing.Color.Lavender;
            this.lbl_Name.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(145, 273);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(118, 45);
            this.lbl_Name.TabIndex = 7;
            this.lbl_Name.Text = "Name";
            // 
            // lbl_Emp_Id
            // 
            this.lbl_Emp_Id.AutoSize = true;
            this.lbl_Emp_Id.BackColor = System.Drawing.Color.Lavender;
            this.lbl_Emp_Id.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Emp_Id.Location = new System.Drawing.Point(145, 182);
            this.lbl_Emp_Id.Name = "lbl_Emp_Id";
            this.lbl_Emp_Id.Size = new System.Drawing.Size(222, 45);
            this.lbl_Emp_Id.TabIndex = 5;
            this.lbl_Emp_Id.Text = "Employee Id";
            // 
            // lbl_Login_Form
            // 
            this.lbl_Login_Form.AutoSize = true;
            this.lbl_Login_Form.BackColor = System.Drawing.Color.MediumTurquoise;
            this.lbl_Login_Form.Font = new System.Drawing.Font("Microsoft Uighur", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Login_Form.Location = new System.Drawing.Point(394, 9);
            this.lbl_Login_Form.Name = "lbl_Login_Form";
            this.lbl_Login_Form.Size = new System.Drawing.Size(511, 109);
            this.lbl_Login_Form.TabIndex = 4;
            this.lbl_Login_Form.Text = "Add New Employee";
            // 
            // tb_Mobile_No
            // 
            this.tb_Mobile_No.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F);
            this.tb_Mobile_No.Location = new System.Drawing.Point(721, 471);
            this.tb_Mobile_No.MaxLength = 10;
            this.tb_Mobile_No.Name = "tb_Mobile_No";
            this.tb_Mobile_No.Size = new System.Drawing.Size(380, 50);
            this.tb_Mobile_No.TabIndex = 4;
            // 
            // lbl_Mobile_No
            // 
            this.lbl_Mobile_No.AutoSize = true;
            this.lbl_Mobile_No.BackColor = System.Drawing.Color.Lavender;
            this.lbl_Mobile_No.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mobile_No.Location = new System.Drawing.Point(145, 474);
            this.lbl_Mobile_No.Name = "lbl_Mobile_No";
            this.lbl_Mobile_No.Size = new System.Drawing.Size(194, 45);
            this.lbl_Mobile_No.TabIndex = 12;
            this.lbl_Mobile_No.Text = "Mobile No";
            // 
            // lbl_Date_Of_Birth
            // 
            this.lbl_Date_Of_Birth.AutoSize = true;
            this.lbl_Date_Of_Birth.BackColor = System.Drawing.Color.Lavender;
            this.lbl_Date_Of_Birth.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date_Of_Birth.Location = new System.Drawing.Point(145, 377);
            this.lbl_Date_Of_Birth.Name = "lbl_Date_Of_Birth";
            this.lbl_Date_Of_Birth.Size = new System.Drawing.Size(234, 45);
            this.lbl_Date_Of_Birth.TabIndex = 10;
            this.lbl_Date_Of_Birth.Text = "Date Of Birth";
            // 
            // dtp_DOB
            // 
            this.dtp_DOB.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F);
            this.dtp_DOB.Location = new System.Drawing.Point(721, 374);
            this.dtp_DOB.Name = "dtp_DOB";
            this.dtp_DOB.Size = new System.Drawing.Size(380, 50);
            this.dtp_DOB.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Lavender;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(145, 575);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 45);
            this.label3.TabIndex = 15;
            this.label3.Text = "Department";
            // 
            // cmb_Department
            // 
            this.cmb_Department.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Department.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F);
            this.cmb_Department.FormattingEnabled = true;
            this.cmb_Department.Items.AddRange(new object[] {
            "Hr",
            "Developer",
            "Marketing",
            "Finance ",
            "Sales"});
            this.cmb_Department.Location = new System.Drawing.Point(721, 575);
            this.cmb_Department.Name = "cmb_Department";
            this.cmb_Department.Size = new System.Drawing.Size(380, 51);
            this.cmb_Department.TabIndex = 5;
            // 
            // frm_Add_New_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1295, 761);
            this.ControlBox = false;
            this.Controls.Add(this.cmb_Department);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtp_DOB);
            this.Controls.Add(this.tb_Mobile_No);
            this.Controls.Add(this.lbl_Mobile_No);
            this.Controls.Add(this.lbl_Date_Of_Birth);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.tb_Employee_Id);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.lbl_Emp_Id);
            this.Controls.Add(this.lbl_Login_Form);
            this.Name = "frm_Add_New_Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = " Add New Employee";
            this.Load += new System.EventHandler(this.frm_Add_New_Employee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.TextBox tb_Employee_Id;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Emp_Id;
        private System.Windows.Forms.Label lbl_Login_Form;
        private System.Windows.Forms.TextBox tb_Mobile_No;
        private System.Windows.Forms.Label lbl_Mobile_No;
        private System.Windows.Forms.Label lbl_Date_Of_Birth;
        private System.Windows.Forms.DateTimePicker dtp_DOB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_Department;
    }
}
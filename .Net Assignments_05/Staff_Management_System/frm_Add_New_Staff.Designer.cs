namespace Staff_Management_System
{
    partial class frm_Add_New_Staff
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
            this.tb_Mob_No = new System.Windows.Forms.TextBox();
            this.tb_Staff_Name = new System.Windows.Forms.TextBox();
            this.cmb_Department = new System.Windows.Forms.ComboBox();
            this.lbl_Date_Of_Birth = new System.Windows.Forms.Label();
            this.lbl_Staff_NSame = new System.Windows.Forms.Label();
            this.lbl_Staff_Id = new System.Windows.Forms.Label();
            this.pnl_Add_New_Staff = new System.Windows.Forms.Panel();
            this.lbl_Add_New_Staff = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.gb_Staff_Details = new System.Windows.Forms.GroupBox();
            this.tb_Hobbies = new System.Windows.Forms.TextBox();
            this.clb_Hobbies = new System.Windows.Forms.CheckedListBox();
            this.gb_Project = new System.Windows.Forms.GroupBox();
            this.cb_G_Pay = new System.Windows.Forms.CheckBox();
            this.cb_Tata = new System.Windows.Forms.CheckBox();
            this.cb_Dmart = new System.Windows.Forms.CheckBox();
            this.gb_Shift_Timing = new System.Windows.Forms.GroupBox();
            this.rbtn_Night = new System.Windows.Forms.RadioButton();
            this.rbtn_Afternoon = new System.Windows.Forms.RadioButton();
            this.rbtn_Morning = new System.Windows.Forms.RadioButton();
            this.gb_Gender = new System.Windows.Forms.GroupBox();
            this.rbtn_Female = new System.Windows.Forms.RadioButton();
            this.rbtn_Male = new System.Windows.Forms.RadioButton();
            this.cmb_Designation = new System.Windows.Forms.ComboBox();
            this.tb_Staff_Id = new System.Windows.Forms.TextBox();
            this.dtp_Date_Of_Birth = new System.Windows.Forms.DateTimePicker();
            this.lbl_Hobbies = new System.Windows.Forms.Label();
            this.lbl_Designation = new System.Windows.Forms.Label();
            this.lbl_Mob_No = new System.Windows.Forms.Label();
            this.lbl_Project = new System.Windows.Forms.Label();
            this.lbl_Shift_Timing = new System.Windows.Forms.Label();
            this.lbl_Gender = new System.Windows.Forms.Label();
            this.lbl_Department = new System.Windows.Forms.Label();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.pnl_Add_New_Staff.SuspendLayout();
            this.gb_Staff_Details.SuspendLayout();
            this.gb_Project.SuspendLayout();
            this.gb_Shift_Timing.SuspendLayout();
            this.gb_Gender.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_Mob_No
            // 
            this.tb_Mob_No.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold);
            this.tb_Mob_No.Location = new System.Drawing.Point(317, 347);
            this.tb_Mob_No.MaxLength = 10;
            this.tb_Mob_No.Name = "tb_Mob_No";
            this.tb_Mob_No.Size = new System.Drawing.Size(320, 40);
            this.tb_Mob_No.TabIndex = 4;
            // 
            // tb_Staff_Name
            // 
            this.tb_Staff_Name.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold);
            this.tb_Staff_Name.Location = new System.Drawing.Point(317, 145);
            this.tb_Staff_Name.MaxLength = 30;
            this.tb_Staff_Name.Name = "tb_Staff_Name";
            this.tb_Staff_Name.Size = new System.Drawing.Size(320, 40);
            this.tb_Staff_Name.TabIndex = 2;
            // 
            // cmb_Department
            // 
            this.cmb_Department.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Department.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold);
            this.cmb_Department.FormattingEnabled = true;
            this.cmb_Department.Location = new System.Drawing.Point(1045, 246);
            this.cmb_Department.Name = "cmb_Department";
            this.cmb_Department.Size = new System.Drawing.Size(320, 45);
            this.cmb_Department.TabIndex = 8;
            // 
            // lbl_Date_Of_Birth
            // 
            this.lbl_Date_Of_Birth.AutoSize = true;
            this.lbl_Date_Of_Birth.Font = new System.Drawing.Font("Microsoft Uighur", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date_Of_Birth.Location = new System.Drawing.Point(17, 239);
            this.lbl_Date_Of_Birth.Name = "lbl_Date_Of_Birth";
            this.lbl_Date_Of_Birth.Size = new System.Drawing.Size(202, 52);
            this.lbl_Date_Of_Birth.TabIndex = 16;
            this.lbl_Date_Of_Birth.Text = "Date Of Birth";
            // 
            // lbl_Staff_NSame
            // 
            this.lbl_Staff_NSame.AutoSize = true;
            this.lbl_Staff_NSame.Font = new System.Drawing.Font("Microsoft Uighur", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Staff_NSame.Location = new System.Drawing.Point(17, 138);
            this.lbl_Staff_NSame.Name = "lbl_Staff_NSame";
            this.lbl_Staff_NSame.Size = new System.Drawing.Size(169, 52);
            this.lbl_Staff_NSame.TabIndex = 15;
            this.lbl_Staff_NSame.Text = "Staff Name";
            // 
            // lbl_Staff_Id
            // 
            this.lbl_Staff_Id.AutoSize = true;
            this.lbl_Staff_Id.Font = new System.Drawing.Font("Microsoft Uighur", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Staff_Id.Location = new System.Drawing.Point(17, 27);
            this.lbl_Staff_Id.Name = "lbl_Staff_Id";
            this.lbl_Staff_Id.Size = new System.Drawing.Size(119, 52);
            this.lbl_Staff_Id.TabIndex = 14;
            this.lbl_Staff_Id.Text = "Staff Id";
            // 
            // pnl_Add_New_Staff
            // 
            this.pnl_Add_New_Staff.BackColor = System.Drawing.Color.MistyRose;
            this.pnl_Add_New_Staff.Controls.Add(this.lbl_Add_New_Staff);
            this.pnl_Add_New_Staff.Location = new System.Drawing.Point(0, 0);
            this.pnl_Add_New_Staff.Name = "pnl_Add_New_Staff";
            this.pnl_Add_New_Staff.Size = new System.Drawing.Size(1508, 124);
            this.pnl_Add_New_Staff.TabIndex = 13;
            // 
            // lbl_Add_New_Staff
            // 
            this.lbl_Add_New_Staff.AutoSize = true;
            this.lbl_Add_New_Staff.Font = new System.Drawing.Font("Microsoft Uighur", 70F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Add_New_Staff.Location = new System.Drawing.Point(505, -6);
            this.lbl_Add_New_Staff.Name = "lbl_Add_New_Staff";
            this.lbl_Add_New_Staff.Size = new System.Drawing.Size(540, 152);
            this.lbl_Add_New_Staff.TabIndex = 0;
            this.lbl_Add_New_Staff.Text = "Add New Staff";
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.Coral;
            this.btn_Save.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(684, 727);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(128, 56);
            this.btn_Save.TabIndex = 12;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // gb_Staff_Details
            // 
            this.gb_Staff_Details.Controls.Add(this.tb_Hobbies);
            this.gb_Staff_Details.Controls.Add(this.clb_Hobbies);
            this.gb_Staff_Details.Controls.Add(this.gb_Project);
            this.gb_Staff_Details.Controls.Add(this.gb_Shift_Timing);
            this.gb_Staff_Details.Controls.Add(this.gb_Gender);
            this.gb_Staff_Details.Controls.Add(this.cmb_Designation);
            this.gb_Staff_Details.Controls.Add(this.tb_Staff_Id);
            this.gb_Staff_Details.Controls.Add(this.dtp_Date_Of_Birth);
            this.gb_Staff_Details.Controls.Add(this.lbl_Hobbies);
            this.gb_Staff_Details.Controls.Add(this.lbl_Designation);
            this.gb_Staff_Details.Controls.Add(this.lbl_Mob_No);
            this.gb_Staff_Details.Controls.Add(this.lbl_Project);
            this.gb_Staff_Details.Controls.Add(this.lbl_Shift_Timing);
            this.gb_Staff_Details.Controls.Add(this.lbl_Gender);
            this.gb_Staff_Details.Controls.Add(this.lbl_Department);
            this.gb_Staff_Details.Controls.Add(this.lbl_Staff_NSame);
            this.gb_Staff_Details.Controls.Add(this.tb_Mob_No);
            this.gb_Staff_Details.Controls.Add(this.lbl_Staff_Id);
            this.gb_Staff_Details.Controls.Add(this.tb_Staff_Name);
            this.gb_Staff_Details.Controls.Add(this.lbl_Date_Of_Birth);
            this.gb_Staff_Details.Controls.Add(this.cmb_Department);
            this.gb_Staff_Details.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Staff_Details.Location = new System.Drawing.Point(12, 141);
            this.gb_Staff_Details.Name = "gb_Staff_Details";
            this.gb_Staff_Details.Size = new System.Drawing.Size(1480, 560);
            this.gb_Staff_Details.TabIndex = 17;
            this.gb_Staff_Details.TabStop = false;
            this.gb_Staff_Details.Text = "Staff Details";
            // 
            // tb_Hobbies
            // 
            this.tb_Hobbies.Enabled = false;
            this.tb_Hobbies.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold);
            this.tb_Hobbies.Location = new System.Drawing.Point(1246, 449);
            this.tb_Hobbies.MaxLength = 30;
            this.tb_Hobbies.Multiline = true;
            this.tb_Hobbies.Name = "tb_Hobbies";
            this.tb_Hobbies.Size = new System.Drawing.Size(228, 83);
            this.tb_Hobbies.TabIndex = 11;
            // 
            // clb_Hobbies
            // 
            this.clb_Hobbies.FormattingEnabled = true;
            this.clb_Hobbies.Items.AddRange(new object[] {
            "Playing",
            "Reading",
            "Writing",
            "Eating",
            "Other"});
            this.clb_Hobbies.Location = new System.Drawing.Point(1045, 418);
            this.clb_Hobbies.Name = "clb_Hobbies";
            this.clb_Hobbies.Size = new System.Drawing.Size(170, 136);
            this.clb_Hobbies.TabIndex = 10;
            // 
            // gb_Project
            // 
            this.gb_Project.Controls.Add(this.cb_G_Pay);
            this.gb_Project.Controls.Add(this.cb_Tata);
            this.gb_Project.Controls.Add(this.cb_Dmart);
            this.gb_Project.Location = new System.Drawing.Point(1045, 335);
            this.gb_Project.Name = "gb_Project";
            this.gb_Project.Size = new System.Drawing.Size(376, 53);
            this.gb_Project.TabIndex = 9;
            this.gb_Project.TabStop = false;
            // 
            // cb_G_Pay
            // 
            this.cb_G_Pay.AutoSize = true;
            this.cb_G_Pay.Location = new System.Drawing.Point(253, 20);
            this.cb_G_Pay.Name = "cb_G_Pay";
            this.cb_G_Pay.Size = new System.Drawing.Size(77, 22);
            this.cb_G_Pay.TabIndex = 2;
            this.cb_G_Pay.Text = "G pay";
            this.cb_G_Pay.UseVisualStyleBackColor = true;
            // 
            // cb_Tata
            // 
            this.cb_Tata.AutoSize = true;
            this.cb_Tata.Location = new System.Drawing.Point(143, 19);
            this.cb_Tata.Name = "cb_Tata";
            this.cb_Tata.Size = new System.Drawing.Size(65, 22);
            this.cb_Tata.TabIndex = 1;
            this.cb_Tata.Text = "Tata";
            this.cb_Tata.UseVisualStyleBackColor = true;
            // 
            // cb_Dmart
            // 
            this.cb_Dmart.AutoSize = true;
            this.cb_Dmart.Location = new System.Drawing.Point(17, 20);
            this.cb_Dmart.Name = "cb_Dmart";
            this.cb_Dmart.Size = new System.Drawing.Size(79, 22);
            this.cb_Dmart.TabIndex = 0;
            this.cb_Dmart.Text = "Dmart";
            this.cb_Dmart.UseVisualStyleBackColor = true;
            // 
            // gb_Shift_Timing
            // 
            this.gb_Shift_Timing.Controls.Add(this.rbtn_Night);
            this.gb_Shift_Timing.Controls.Add(this.rbtn_Afternoon);
            this.gb_Shift_Timing.Controls.Add(this.rbtn_Morning);
            this.gb_Shift_Timing.Location = new System.Drawing.Point(1045, 133);
            this.gb_Shift_Timing.Name = "gb_Shift_Timing";
            this.gb_Shift_Timing.Size = new System.Drawing.Size(376, 53);
            this.gb_Shift_Timing.TabIndex = 7;
            this.gb_Shift_Timing.TabStop = false;
            // 
            // rbtn_Night
            // 
            this.rbtn_Night.AutoSize = true;
            this.rbtn_Night.Location = new System.Drawing.Point(276, 19);
            this.rbtn_Night.Name = "rbtn_Night";
            this.rbtn_Night.Size = new System.Drawing.Size(74, 22);
            this.rbtn_Night.TabIndex = 4;
            this.rbtn_Night.TabStop = true;
            this.rbtn_Night.Text = "Night";
            this.rbtn_Night.UseVisualStyleBackColor = true;
            // 
            // rbtn_Afternoon
            // 
            this.rbtn_Afternoon.AutoSize = true;
            this.rbtn_Afternoon.Location = new System.Drawing.Point(143, 19);
            this.rbtn_Afternoon.Name = "rbtn_Afternoon";
            this.rbtn_Afternoon.Size = new System.Drawing.Size(111, 22);
            this.rbtn_Afternoon.TabIndex = 3;
            this.rbtn_Afternoon.TabStop = true;
            this.rbtn_Afternoon.Text = "Afternoon";
            this.rbtn_Afternoon.UseVisualStyleBackColor = true;
            // 
            // rbtn_Morning
            // 
            this.rbtn_Morning.AutoSize = true;
            this.rbtn_Morning.Location = new System.Drawing.Point(17, 19);
            this.rbtn_Morning.Name = "rbtn_Morning";
            this.rbtn_Morning.Size = new System.Drawing.Size(98, 22);
            this.rbtn_Morning.TabIndex = 2;
            this.rbtn_Morning.TabStop = true;
            this.rbtn_Morning.Text = "Morning";
            this.rbtn_Morning.UseVisualStyleBackColor = true;
            // 
            // gb_Gender
            // 
            this.gb_Gender.Controls.Add(this.rbtn_Female);
            this.gb_Gender.Controls.Add(this.rbtn_Male);
            this.gb_Gender.Location = new System.Drawing.Point(1045, 26);
            this.gb_Gender.Name = "gb_Gender";
            this.gb_Gender.Size = new System.Drawing.Size(286, 53);
            this.gb_Gender.TabIndex = 6;
            this.gb_Gender.TabStop = false;
            // 
            // rbtn_Female
            // 
            this.rbtn_Female.AutoSize = true;
            this.rbtn_Female.Location = new System.Drawing.Point(168, 19);
            this.rbtn_Female.Name = "rbtn_Female";
            this.rbtn_Female.Size = new System.Drawing.Size(86, 22);
            this.rbtn_Female.TabIndex = 1;
            this.rbtn_Female.TabStop = true;
            this.rbtn_Female.Text = "Female";
            this.rbtn_Female.UseVisualStyleBackColor = true;
            // 
            // rbtn_Male
            // 
            this.rbtn_Male.AutoSize = true;
            this.rbtn_Male.Location = new System.Drawing.Point(30, 19);
            this.rbtn_Male.Name = "rbtn_Male";
            this.rbtn_Male.Size = new System.Drawing.Size(69, 22);
            this.rbtn_Male.TabIndex = 0;
            this.rbtn_Male.TabStop = true;
            this.rbtn_Male.Text = "Male";
            this.rbtn_Male.UseVisualStyleBackColor = true;
            // 
            // cmb_Designation
            // 
            this.cmb_Designation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Designation.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold);
            this.cmb_Designation.FormattingEnabled = true;
            this.cmb_Designation.Items.AddRange(new object[] {
            "Hr",
            "Co"});
            this.cmb_Designation.Location = new System.Drawing.Point(317, 449);
            this.cmb_Designation.Name = "cmb_Designation";
            this.cmb_Designation.Size = new System.Drawing.Size(320, 45);
            this.cmb_Designation.TabIndex = 5;
            // 
            // tb_Staff_Id
            // 
            this.tb_Staff_Id.Enabled = false;
            this.tb_Staff_Id.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold);
            this.tb_Staff_Id.Location = new System.Drawing.Point(317, 34);
            this.tb_Staff_Id.MaxLength = 5;
            this.tb_Staff_Id.Name = "tb_Staff_Id";
            this.tb_Staff_Id.Size = new System.Drawing.Size(320, 40);
            this.tb_Staff_Id.TabIndex = 1;
            // 
            // dtp_Date_Of_Birth
            // 
            this.dtp_Date_Of_Birth.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Date_Of_Birth.Location = new System.Drawing.Point(317, 246);
            this.dtp_Date_Of_Birth.Name = "dtp_Date_Of_Birth";
            this.dtp_Date_Of_Birth.Size = new System.Drawing.Size(320, 42);
            this.dtp_Date_Of_Birth.TabIndex = 3;
            // 
            // lbl_Hobbies
            // 
            this.lbl_Hobbies.AutoSize = true;
            this.lbl_Hobbies.Font = new System.Drawing.Font("Microsoft Uighur", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Hobbies.Location = new System.Drawing.Point(826, 449);
            this.lbl_Hobbies.Name = "lbl_Hobbies";
            this.lbl_Hobbies.Size = new System.Drawing.Size(132, 52);
            this.lbl_Hobbies.TabIndex = 23;
            this.lbl_Hobbies.Text = "Hobbies";
            // 
            // lbl_Designation
            // 
            this.lbl_Designation.AutoSize = true;
            this.lbl_Designation.Font = new System.Drawing.Font("Microsoft Uighur", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Designation.Location = new System.Drawing.Point(25, 449);
            this.lbl_Designation.Name = "lbl_Designation";
            this.lbl_Designation.Size = new System.Drawing.Size(183, 52);
            this.lbl_Designation.TabIndex = 21;
            this.lbl_Designation.Text = "Designation";
            // 
            // lbl_Mob_No
            // 
            this.lbl_Mob_No.AutoSize = true;
            this.lbl_Mob_No.Font = new System.Drawing.Font("Microsoft Uighur", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mob_No.Location = new System.Drawing.Point(25, 340);
            this.lbl_Mob_No.Name = "lbl_Mob_No";
            this.lbl_Mob_No.Size = new System.Drawing.Size(131, 52);
            this.lbl_Mob_No.TabIndex = 20;
            this.lbl_Mob_No.Text = "Mob No";
            // 
            // lbl_Project
            // 
            this.lbl_Project.AutoSize = true;
            this.lbl_Project.Font = new System.Drawing.Font("Microsoft Uighur", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Project.Location = new System.Drawing.Point(826, 335);
            this.lbl_Project.Name = "lbl_Project";
            this.lbl_Project.Size = new System.Drawing.Size(116, 52);
            this.lbl_Project.TabIndex = 22;
            this.lbl_Project.Text = "Project";
            // 
            // lbl_Shift_Timing
            // 
            this.lbl_Shift_Timing.AutoSize = true;
            this.lbl_Shift_Timing.Font = new System.Drawing.Font("Microsoft Uighur", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Shift_Timing.Location = new System.Drawing.Point(824, 133);
            this.lbl_Shift_Timing.Name = "lbl_Shift_Timing";
            this.lbl_Shift_Timing.Size = new System.Drawing.Size(192, 52);
            this.lbl_Shift_Timing.TabIndex = 18;
            this.lbl_Shift_Timing.Text = "Shift Timing";
            // 
            // lbl_Gender
            // 
            this.lbl_Gender.AutoSize = true;
            this.lbl_Gender.Font = new System.Drawing.Font("Microsoft Uighur", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Gender.Location = new System.Drawing.Point(824, 34);
            this.lbl_Gender.Name = "lbl_Gender";
            this.lbl_Gender.Size = new System.Drawing.Size(122, 52);
            this.lbl_Gender.TabIndex = 17;
            this.lbl_Gender.Text = "Gender";
            // 
            // lbl_Department
            // 
            this.lbl_Department.AutoSize = true;
            this.lbl_Department.Font = new System.Drawing.Font("Microsoft Uighur", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Department.Location = new System.Drawing.Point(824, 239);
            this.lbl_Department.Name = "lbl_Department";
            this.lbl_Department.Size = new System.Drawing.Size(183, 52);
            this.lbl_Department.TabIndex = 19;
            this.lbl_Department.Text = "Department";
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.Coral;
            this.btn_Close.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.Location = new System.Drawing.Point(1099, 727);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(128, 56);
            this.btn_Close.TabIndex = 14;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.Coral;
            this.btn_Refresh.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.Location = new System.Drawing.Point(246, 727);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(142, 56);
            this.btn_Refresh.TabIndex = 13;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // frm_Add_New_Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1504, 795);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.gb_Staff_Details);
            this.Controls.Add(this.pnl_Add_New_Staff);
            this.Controls.Add(this.btn_Save);
            this.Name = "frm_Add_New_Staff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add New Staff";
            this.Load += new System.EventHandler(this.frm_Add_New_Staff_Load);
            this.pnl_Add_New_Staff.ResumeLayout(false);
            this.pnl_Add_New_Staff.PerformLayout();
            this.gb_Staff_Details.ResumeLayout(false);
            this.gb_Staff_Details.PerformLayout();
            this.gb_Project.ResumeLayout(false);
            this.gb_Project.PerformLayout();
            this.gb_Shift_Timing.ResumeLayout(false);
            this.gb_Shift_Timing.PerformLayout();
            this.gb_Gender.ResumeLayout(false);
            this.gb_Gender.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Mob_No;
        private System.Windows.Forms.TextBox tb_Staff_Name;
        private System.Windows.Forms.ComboBox cmb_Department;
        private System.Windows.Forms.Label lbl_Date_Of_Birth;
        private System.Windows.Forms.Label lbl_Staff_NSame;
        private System.Windows.Forms.Label lbl_Staff_Id;
        private System.Windows.Forms.Panel pnl_Add_New_Staff;
        private System.Windows.Forms.Label lbl_Add_New_Staff;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.GroupBox gb_Staff_Details;
        private System.Windows.Forms.Label lbl_Hobbies;
        private System.Windows.Forms.Label lbl_Designation;
        private System.Windows.Forms.Label lbl_Mob_No;
        private System.Windows.Forms.Label lbl_Project;
        private System.Windows.Forms.Label lbl_Shift_Timing;
        private System.Windows.Forms.Label lbl_Gender;
        private System.Windows.Forms.Label lbl_Department;
        private System.Windows.Forms.TextBox tb_Hobbies;
        private System.Windows.Forms.CheckedListBox clb_Hobbies;
        private System.Windows.Forms.GroupBox gb_Project;
        private System.Windows.Forms.CheckBox cb_G_Pay;
        private System.Windows.Forms.CheckBox cb_Tata;
        private System.Windows.Forms.CheckBox cb_Dmart;
        private System.Windows.Forms.GroupBox gb_Shift_Timing;
        private System.Windows.Forms.RadioButton rbtn_Night;
        private System.Windows.Forms.RadioButton rbtn_Afternoon;
        private System.Windows.Forms.RadioButton rbtn_Morning;
        private System.Windows.Forms.GroupBox gb_Gender;
        private System.Windows.Forms.RadioButton rbtn_Female;
        private System.Windows.Forms.RadioButton rbtn_Male;
        private System.Windows.Forms.ComboBox cmb_Designation;
        private System.Windows.Forms.TextBox tb_Staff_Id;
        private System.Windows.Forms.DateTimePicker dtp_Date_Of_Birth;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_Refresh;
    }
}
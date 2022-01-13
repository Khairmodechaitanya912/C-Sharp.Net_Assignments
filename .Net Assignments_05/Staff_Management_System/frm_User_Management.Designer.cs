namespace Staff_Management_System
{
    partial class frm_User_Management
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
            this.pnl_User_Management = new System.Windows.Forms.Panel();
            this.lbl_User_Management = new System.Windows.Forms.Label();
            this.tb_User_Management = new System.Windows.Forms.TabControl();
            this.tp_Add_New_User = new System.Windows.Forms.TabPage();
            this.btn_Save = new System.Windows.Forms.Button();
            this.tb_Confirm_Password_A = new System.Windows.Forms.TextBox();
            this.lbl_Confirm_Password_A = new System.Windows.Forms.Label();
            this.lbl_Add_New_User = new System.Windows.Forms.Label();
            this.tb_Password_A = new System.Windows.Forms.TextBox();
            this.tb_Username_A = new System.Windows.Forms.TextBox();
            this.cmb_User_Role_A = new System.Windows.Forms.ComboBox();
            this.lbl_Password_A = new System.Windows.Forms.Label();
            this.lbl_Username_A = new System.Windows.Forms.Label();
            this.lbl_User_Role_A = new System.Windows.Forms.Label();
            this.tp_Update_User = new System.Windows.Forms.TabPage();
            this.btn_Update = new System.Windows.Forms.Button();
            this.tb_Confirm_Password_U = new System.Windows.Forms.TextBox();
            this.lbl_Confirm_Password_U = new System.Windows.Forms.Label();
            this.lbl_Update_User = new System.Windows.Forms.Label();
            this.tb_Password_U = new System.Windows.Forms.TextBox();
            this.cmb_Username_U = new System.Windows.Forms.ComboBox();
            this.cmb_User_Role_U = new System.Windows.Forms.ComboBox();
            this.lbl_Password_U = new System.Windows.Forms.Label();
            this.lbl_Username_U = new System.Windows.Forms.Label();
            this.lbl_User_Role_U = new System.Windows.Forms.Label();
            this.tp_Delete_User = new System.Windows.Forms.TabPage();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.lbl_Delete_User = new System.Windows.Forms.Label();
            this.tb_Admin_Password_D = new System.Windows.Forms.TextBox();
            this.cmb_Username_D = new System.Windows.Forms.ComboBox();
            this.cmb_User_Role_D = new System.Windows.Forms.ComboBox();
            this.lbl_Admin_Password_D = new System.Windows.Forms.Label();
            this.lbl_Username_D = new System.Windows.Forms.Label();
            this.lbl_User_Role_D = new System.Windows.Forms.Label();
            this.pnl_User_Management.SuspendLayout();
            this.tb_User_Management.SuspendLayout();
            this.tp_Add_New_User.SuspendLayout();
            this.tp_Update_User.SuspendLayout();
            this.tp_Delete_User.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_User_Management
            // 
            this.pnl_User_Management.BackColor = System.Drawing.Color.MistyRose;
            this.pnl_User_Management.Controls.Add(this.lbl_User_Management);
            this.pnl_User_Management.Location = new System.Drawing.Point(3, 3);
            this.pnl_User_Management.Name = "pnl_User_Management";
            this.pnl_User_Management.Size = new System.Drawing.Size(1508, 124);
            this.pnl_User_Management.TabIndex = 14;
            // 
            // lbl_User_Management
            // 
            this.lbl_User_Management.AutoSize = true;
            this.lbl_User_Management.Font = new System.Drawing.Font("Microsoft Uighur", 70F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_User_Management.Location = new System.Drawing.Point(505, -6);
            this.lbl_User_Management.Name = "lbl_User_Management";
            this.lbl_User_Management.Size = new System.Drawing.Size(667, 152);
            this.lbl_User_Management.TabIndex = 0;
            this.lbl_User_Management.Text = "User Management";
            // 
            // tb_User_Management
            // 
            this.tb_User_Management.Controls.Add(this.tp_Add_New_User);
            this.tb_User_Management.Controls.Add(this.tp_Update_User);
            this.tb_User_Management.Controls.Add(this.tp_Delete_User);
            this.tb_User_Management.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tb_User_Management.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_User_Management.Location = new System.Drawing.Point(0, 152);
            this.tb_User_Management.Name = "tb_User_Management";
            this.tb_User_Management.SelectedIndex = 0;
            this.tb_User_Management.Size = new System.Drawing.Size(1504, 643);
            this.tb_User_Management.TabIndex = 15;
            // 
            // tp_Add_New_User
            // 
            this.tp_Add_New_User.Controls.Add(this.btn_Save);
            this.tp_Add_New_User.Controls.Add(this.tb_Confirm_Password_A);
            this.tp_Add_New_User.Controls.Add(this.lbl_Confirm_Password_A);
            this.tp_Add_New_User.Controls.Add(this.lbl_Add_New_User);
            this.tp_Add_New_User.Controls.Add(this.tb_Password_A);
            this.tp_Add_New_User.Controls.Add(this.tb_Username_A);
            this.tp_Add_New_User.Controls.Add(this.cmb_User_Role_A);
            this.tp_Add_New_User.Controls.Add(this.lbl_Password_A);
            this.tp_Add_New_User.Controls.Add(this.lbl_Username_A);
            this.tp_Add_New_User.Controls.Add(this.lbl_User_Role_A);
            this.tp_Add_New_User.Location = new System.Drawing.Point(4, 33);
            this.tp_Add_New_User.Name = "tp_Add_New_User";
            this.tp_Add_New_User.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Add_New_User.Size = new System.Drawing.Size(1496, 606);
            this.tp_Add_New_User.TabIndex = 0;
            this.tp_Add_New_User.Text = "Add New User";
            this.tp_Add_New_User.UseVisualStyleBackColor = true;
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.Coral;
            this.btn_Save.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(632, 532);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(128, 56);
            this.btn_Save.TabIndex = 18;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            // 
            // tb_Confirm_Password_A
            // 
            this.tb_Confirm_Password_A.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold);
            this.tb_Confirm_Password_A.Location = new System.Drawing.Point(798, 451);
            this.tb_Confirm_Password_A.MaxLength = 10;
            this.tb_Confirm_Password_A.Name = "tb_Confirm_Password_A";
            this.tb_Confirm_Password_A.PasswordChar = '*';
            this.tb_Confirm_Password_A.Size = new System.Drawing.Size(320, 40);
            this.tb_Confirm_Password_A.TabIndex = 16;
            // 
            // lbl_Confirm_Password_A
            // 
            this.lbl_Confirm_Password_A.AutoSize = true;
            this.lbl_Confirm_Password_A.Font = new System.Drawing.Font("Microsoft Uighur", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Confirm_Password_A.Location = new System.Drawing.Point(381, 439);
            this.lbl_Confirm_Password_A.Name = "lbl_Confirm_Password_A";
            this.lbl_Confirm_Password_A.Size = new System.Drawing.Size(268, 52);
            this.lbl_Confirm_Password_A.TabIndex = 17;
            this.lbl_Confirm_Password_A.Text = "Confirm Password";
            // 
            // lbl_Add_New_User
            // 
            this.lbl_Add_New_User.AutoSize = true;
            this.lbl_Add_New_User.BackColor = System.Drawing.Color.Wheat;
            this.lbl_Add_New_User.Font = new System.Drawing.Font("Microsoft Uighur", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Add_New_User.Location = new System.Drawing.Point(524, 23);
            this.lbl_Add_New_User.Name = "lbl_Add_New_User";
            this.lbl_Add_New_User.Size = new System.Drawing.Size(390, 109);
            this.lbl_Add_New_User.TabIndex = 0;
            this.lbl_Add_New_User.Text = "Add New User";
            // 
            // tb_Password_A
            // 
            this.tb_Password_A.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold);
            this.tb_Password_A.Location = new System.Drawing.Point(798, 358);
            this.tb_Password_A.MaxLength = 10;
            this.tb_Password_A.Name = "tb_Password_A";
            this.tb_Password_A.PasswordChar = '*';
            this.tb_Password_A.Size = new System.Drawing.Size(320, 40);
            this.tb_Password_A.TabIndex = 11;
            // 
            // tb_Username_A
            // 
            this.tb_Username_A.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold);
            this.tb_Username_A.Location = new System.Drawing.Point(798, 268);
            this.tb_Username_A.MaxLength = 10;
            this.tb_Username_A.Name = "tb_Username_A";
            this.tb_Username_A.Size = new System.Drawing.Size(320, 40);
            this.tb_Username_A.TabIndex = 10;
            // 
            // cmb_User_Role_A
            // 
            this.cmb_User_Role_A.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_User_Role_A.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold);
            this.cmb_User_Role_A.FormattingEnabled = true;
            this.cmb_User_Role_A.Items.AddRange(new object[] {
            "Admin",
            "Manager",
            "Cashier",
            "Staff"});
            this.cmb_User_Role_A.Location = new System.Drawing.Point(798, 174);
            this.cmb_User_Role_A.Name = "cmb_User_Role_A";
            this.cmb_User_Role_A.Size = new System.Drawing.Size(320, 45);
            this.cmb_User_Role_A.TabIndex = 9;
            // 
            // lbl_Password_A
            // 
            this.lbl_Password_A.AutoSize = true;
            this.lbl_Password_A.Font = new System.Drawing.Font("Microsoft Uighur", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password_A.Location = new System.Drawing.Point(381, 358);
            this.lbl_Password_A.Name = "lbl_Password_A";
            this.lbl_Password_A.Size = new System.Drawing.Size(149, 52);
            this.lbl_Password_A.TabIndex = 15;
            this.lbl_Password_A.Text = "Password";
            // 
            // lbl_Username_A
            // 
            this.lbl_Username_A.AutoSize = true;
            this.lbl_Username_A.Font = new System.Drawing.Font("Microsoft Uighur", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Username_A.Location = new System.Drawing.Point(381, 268);
            this.lbl_Username_A.Name = "lbl_Username_A";
            this.lbl_Username_A.Size = new System.Drawing.Size(157, 52);
            this.lbl_Username_A.TabIndex = 14;
            this.lbl_Username_A.Text = "Username";
            // 
            // lbl_User_Role_A
            // 
            this.lbl_User_Role_A.AutoSize = true;
            this.lbl_User_Role_A.Font = new System.Drawing.Font("Microsoft Uighur", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_User_Role_A.Location = new System.Drawing.Point(381, 174);
            this.lbl_User_Role_A.Name = "lbl_User_Role_A";
            this.lbl_User_Role_A.Size = new System.Drawing.Size(151, 52);
            this.lbl_User_Role_A.TabIndex = 13;
            this.lbl_User_Role_A.Text = "User Role";
            // 
            // tp_Update_User
            // 
            this.tp_Update_User.Controls.Add(this.btn_Update);
            this.tp_Update_User.Controls.Add(this.tb_Confirm_Password_U);
            this.tp_Update_User.Controls.Add(this.lbl_Confirm_Password_U);
            this.tp_Update_User.Controls.Add(this.lbl_Update_User);
            this.tp_Update_User.Controls.Add(this.tb_Password_U);
            this.tp_Update_User.Controls.Add(this.cmb_Username_U);
            this.tp_Update_User.Controls.Add(this.cmb_User_Role_U);
            this.tp_Update_User.Controls.Add(this.lbl_Password_U);
            this.tp_Update_User.Controls.Add(this.lbl_Username_U);
            this.tp_Update_User.Controls.Add(this.lbl_User_Role_U);
            this.tp_Update_User.Location = new System.Drawing.Point(4, 33);
            this.tp_Update_User.Name = "tp_Update_User";
            this.tp_Update_User.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Update_User.Size = new System.Drawing.Size(1496, 606);
            this.tp_Update_User.TabIndex = 1;
            this.tp_Update_User.Text = "Update User";
            this.tp_Update_User.UseVisualStyleBackColor = true;
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.Coral;
            this.btn_Update.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.Location = new System.Drawing.Point(631, 530);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(128, 56);
            this.btn_Update.TabIndex = 28;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = false;
            // 
            // tb_Confirm_Password_U
            // 
            this.tb_Confirm_Password_U.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold);
            this.tb_Confirm_Password_U.Location = new System.Drawing.Point(797, 449);
            this.tb_Confirm_Password_U.MaxLength = 10;
            this.tb_Confirm_Password_U.Name = "tb_Confirm_Password_U";
            this.tb_Confirm_Password_U.PasswordChar = '*';
            this.tb_Confirm_Password_U.Size = new System.Drawing.Size(320, 40);
            this.tb_Confirm_Password_U.TabIndex = 26;
            // 
            // lbl_Confirm_Password_U
            // 
            this.lbl_Confirm_Password_U.AutoSize = true;
            this.lbl_Confirm_Password_U.Font = new System.Drawing.Font("Microsoft Uighur", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Confirm_Password_U.Location = new System.Drawing.Point(380, 437);
            this.lbl_Confirm_Password_U.Name = "lbl_Confirm_Password_U";
            this.lbl_Confirm_Password_U.Size = new System.Drawing.Size(268, 52);
            this.lbl_Confirm_Password_U.TabIndex = 27;
            this.lbl_Confirm_Password_U.Text = "Confirm Password";
            // 
            // lbl_Update_User
            // 
            this.lbl_Update_User.AutoSize = true;
            this.lbl_Update_User.BackColor = System.Drawing.Color.Wheat;
            this.lbl_Update_User.Font = new System.Drawing.Font("Microsoft Uighur", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Update_User.Location = new System.Drawing.Point(523, 21);
            this.lbl_Update_User.Name = "lbl_Update_User";
            this.lbl_Update_User.Size = new System.Drawing.Size(340, 109);
            this.lbl_Update_User.TabIndex = 19;
            this.lbl_Update_User.Text = "Update User";
            // 
            // tb_Password_U
            // 
            this.tb_Password_U.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold);
            this.tb_Password_U.Location = new System.Drawing.Point(797, 356);
            this.tb_Password_U.MaxLength = 10;
            this.tb_Password_U.Name = "tb_Password_U";
            this.tb_Password_U.PasswordChar = '*';
            this.tb_Password_U.Size = new System.Drawing.Size(320, 40);
            this.tb_Password_U.TabIndex = 22;
            // 
            // cmb_Username_U
            // 
            this.cmb_Username_U.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Username_U.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold);
            this.cmb_Username_U.FormattingEnabled = true;
            this.cmb_Username_U.Items.AddRange(new object[] {
            "Admin",
            "Manager",
            "Cashier",
            "Staff"});
            this.cmb_Username_U.Location = new System.Drawing.Point(797, 266);
            this.cmb_Username_U.Name = "cmb_Username_U";
            this.cmb_Username_U.Size = new System.Drawing.Size(320, 45);
            this.cmb_Username_U.TabIndex = 20;
            // 
            // cmb_User_Role_U
            // 
            this.cmb_User_Role_U.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_User_Role_U.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold);
            this.cmb_User_Role_U.FormattingEnabled = true;
            this.cmb_User_Role_U.Items.AddRange(new object[] {
            "Admin",
            "Manager",
            "Cashier",
            "Staff"});
            this.cmb_User_Role_U.Location = new System.Drawing.Point(797, 172);
            this.cmb_User_Role_U.Name = "cmb_User_Role_U";
            this.cmb_User_Role_U.Size = new System.Drawing.Size(320, 45);
            this.cmb_User_Role_U.TabIndex = 20;
            // 
            // lbl_Password_U
            // 
            this.lbl_Password_U.AutoSize = true;
            this.lbl_Password_U.Font = new System.Drawing.Font("Microsoft Uighur", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password_U.Location = new System.Drawing.Point(380, 356);
            this.lbl_Password_U.Name = "lbl_Password_U";
            this.lbl_Password_U.Size = new System.Drawing.Size(149, 52);
            this.lbl_Password_U.TabIndex = 25;
            this.lbl_Password_U.Text = "Password";
            // 
            // lbl_Username_U
            // 
            this.lbl_Username_U.AutoSize = true;
            this.lbl_Username_U.Font = new System.Drawing.Font("Microsoft Uighur", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Username_U.Location = new System.Drawing.Point(380, 266);
            this.lbl_Username_U.Name = "lbl_Username_U";
            this.lbl_Username_U.Size = new System.Drawing.Size(157, 52);
            this.lbl_Username_U.TabIndex = 24;
            this.lbl_Username_U.Text = "Username";
            // 
            // lbl_User_Role_U
            // 
            this.lbl_User_Role_U.AutoSize = true;
            this.lbl_User_Role_U.Font = new System.Drawing.Font("Microsoft Uighur", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_User_Role_U.Location = new System.Drawing.Point(380, 172);
            this.lbl_User_Role_U.Name = "lbl_User_Role_U";
            this.lbl_User_Role_U.Size = new System.Drawing.Size(151, 52);
            this.lbl_User_Role_U.TabIndex = 23;
            this.lbl_User_Role_U.Text = "User Role";
            // 
            // tp_Delete_User
            // 
            this.tp_Delete_User.Controls.Add(this.btn_Delete);
            this.tp_Delete_User.Controls.Add(this.lbl_Delete_User);
            this.tp_Delete_User.Controls.Add(this.tb_Admin_Password_D);
            this.tp_Delete_User.Controls.Add(this.cmb_Username_D);
            this.tp_Delete_User.Controls.Add(this.cmb_User_Role_D);
            this.tp_Delete_User.Controls.Add(this.lbl_Admin_Password_D);
            this.tp_Delete_User.Controls.Add(this.lbl_Username_D);
            this.tp_Delete_User.Controls.Add(this.lbl_User_Role_D);
            this.tp_Delete_User.Location = new System.Drawing.Point(4, 33);
            this.tp_Delete_User.Name = "tp_Delete_User";
            this.tp_Delete_User.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Delete_User.Size = new System.Drawing.Size(1496, 606);
            this.tp_Delete_User.TabIndex = 2;
            this.tp_Delete_User.Text = "Delete User";
            this.tp_Delete_User.UseVisualStyleBackColor = true;
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.Coral;
            this.btn_Delete.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.Location = new System.Drawing.Point(586, 490);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(128, 56);
            this.btn_Delete.TabIndex = 36;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = false;
            // 
            // lbl_Delete_User
            // 
            this.lbl_Delete_User.AutoSize = true;
            this.lbl_Delete_User.BackColor = System.Drawing.Color.Wheat;
            this.lbl_Delete_User.Font = new System.Drawing.Font("Microsoft Uighur", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Delete_User.Location = new System.Drawing.Point(511, 29);
            this.lbl_Delete_User.Name = "lbl_Delete_User";
            this.lbl_Delete_User.Size = new System.Drawing.Size(321, 109);
            this.lbl_Delete_User.TabIndex = 29;
            this.lbl_Delete_User.Text = "Delete User";
            // 
            // tb_Admin_Password_D
            // 
            this.tb_Admin_Password_D.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold);
            this.tb_Admin_Password_D.Location = new System.Drawing.Point(775, 380);
            this.tb_Admin_Password_D.MaxLength = 10;
            this.tb_Admin_Password_D.Name = "tb_Admin_Password_D";
            this.tb_Admin_Password_D.PasswordChar = '*';
            this.tb_Admin_Password_D.Size = new System.Drawing.Size(320, 40);
            this.tb_Admin_Password_D.TabIndex = 32;
            // 
            // cmb_Username_D
            // 
            this.cmb_Username_D.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Username_D.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold);
            this.cmb_Username_D.FormattingEnabled = true;
            this.cmb_Username_D.Items.AddRange(new object[] {
            "Admin",
            "Manager",
            "Cashier",
            "Staff"});
            this.cmb_Username_D.Location = new System.Drawing.Point(775, 290);
            this.cmb_Username_D.Name = "cmb_Username_D";
            this.cmb_Username_D.Size = new System.Drawing.Size(320, 45);
            this.cmb_Username_D.TabIndex = 31;
            // 
            // cmb_User_Role_D
            // 
            this.cmb_User_Role_D.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_User_Role_D.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold);
            this.cmb_User_Role_D.FormattingEnabled = true;
            this.cmb_User_Role_D.Items.AddRange(new object[] {
            "Admin",
            "Manager",
            "Cashier",
            "Staff"});
            this.cmb_User_Role_D.Location = new System.Drawing.Point(775, 196);
            this.cmb_User_Role_D.Name = "cmb_User_Role_D";
            this.cmb_User_Role_D.Size = new System.Drawing.Size(320, 45);
            this.cmb_User_Role_D.TabIndex = 30;
            // 
            // lbl_Admin_Password_D
            // 
            this.lbl_Admin_Password_D.AutoSize = true;
            this.lbl_Admin_Password_D.Font = new System.Drawing.Font("Microsoft Uighur", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Admin_Password_D.Location = new System.Drawing.Point(358, 380);
            this.lbl_Admin_Password_D.Name = "lbl_Admin_Password_D";
            this.lbl_Admin_Password_D.Size = new System.Drawing.Size(149, 52);
            this.lbl_Admin_Password_D.TabIndex = 35;
            this.lbl_Admin_Password_D.Text = "Password";
            // 
            // lbl_Username_D
            // 
            this.lbl_Username_D.AutoSize = true;
            this.lbl_Username_D.Font = new System.Drawing.Font("Microsoft Uighur", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Username_D.Location = new System.Drawing.Point(358, 290);
            this.lbl_Username_D.Name = "lbl_Username_D";
            this.lbl_Username_D.Size = new System.Drawing.Size(157, 52);
            this.lbl_Username_D.TabIndex = 34;
            this.lbl_Username_D.Text = "Username";
            // 
            // lbl_User_Role_D
            // 
            this.lbl_User_Role_D.AutoSize = true;
            this.lbl_User_Role_D.Font = new System.Drawing.Font("Microsoft Uighur", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_User_Role_D.Location = new System.Drawing.Point(358, 196);
            this.lbl_User_Role_D.Name = "lbl_User_Role_D";
            this.lbl_User_Role_D.Size = new System.Drawing.Size(151, 52);
            this.lbl_User_Role_D.TabIndex = 33;
            this.lbl_User_Role_D.Text = "User Role";
            // 
            // frm_User_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1504, 795);
            this.ControlBox = false;
            this.Controls.Add(this.tb_User_Management);
            this.Controls.Add(this.pnl_User_Management);
            this.Name = "frm_User_Management";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "User Management";
            this.pnl_User_Management.ResumeLayout(false);
            this.pnl_User_Management.PerformLayout();
            this.tb_User_Management.ResumeLayout(false);
            this.tp_Add_New_User.ResumeLayout(false);
            this.tp_Add_New_User.PerformLayout();
            this.tp_Update_User.ResumeLayout(false);
            this.tp_Update_User.PerformLayout();
            this.tp_Delete_User.ResumeLayout(false);
            this.tp_Delete_User.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_User_Management;
        private System.Windows.Forms.Label lbl_User_Management;
        private System.Windows.Forms.TabControl tb_User_Management;
        private System.Windows.Forms.TabPage tp_Add_New_User;
        private System.Windows.Forms.TabPage tp_Update_User;
        private System.Windows.Forms.TabPage tp_Delete_User;
        private System.Windows.Forms.TextBox tb_Password_A;
        private System.Windows.Forms.TextBox tb_Username_A;
        private System.Windows.Forms.ComboBox cmb_User_Role_A;
        private System.Windows.Forms.Label lbl_Password_A;
        private System.Windows.Forms.Label lbl_Username_A;
        private System.Windows.Forms.Label lbl_User_Role_A;
        private System.Windows.Forms.TextBox tb_Confirm_Password_A;
        private System.Windows.Forms.Label lbl_Confirm_Password_A;
        private System.Windows.Forms.Label lbl_Add_New_User;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.TextBox tb_Confirm_Password_U;
        private System.Windows.Forms.Label lbl_Confirm_Password_U;
        private System.Windows.Forms.Label lbl_Update_User;
        private System.Windows.Forms.TextBox tb_Password_U;
        private System.Windows.Forms.ComboBox cmb_User_Role_U;
        private System.Windows.Forms.Label lbl_Password_U;
        private System.Windows.Forms.Label lbl_Username_U;
        private System.Windows.Forms.Label lbl_User_Role_U;
        private System.Windows.Forms.ComboBox cmb_Username_U;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Label lbl_Delete_User;
        private System.Windows.Forms.TextBox tb_Admin_Password_D;
        private System.Windows.Forms.ComboBox cmb_Username_D;
        private System.Windows.Forms.ComboBox cmb_User_Role_D;
        private System.Windows.Forms.Label lbl_Admin_Password_D;
        private System.Windows.Forms.Label lbl_Username_D;
        private System.Windows.Forms.Label lbl_User_Role_D;
    }
}
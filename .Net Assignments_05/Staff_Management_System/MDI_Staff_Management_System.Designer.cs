namespace Staff_Management_System
{
    partial class MDI_Staff_Management_System
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.staffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewStaffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.upToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staffListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDepartmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateDepartmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_Logged_User = new System.Windows.Forms.Label();
            this.btn_Log_Out = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.AutoSize = false;
            this.menuStrip.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.staffToolStripMenuItem,
            this.departmentToolStripMenuItem,
            this.userManagementToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(1504, 38);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // staffToolStripMenuItem
            // 
            this.staffToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewStaffToolStripMenuItem,
            this.upToolStripMenuItem,
            this.staffListToolStripMenuItem});
            this.staffToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffToolStripMenuItem.Name = "staffToolStripMenuItem";
            this.staffToolStripMenuItem.Size = new System.Drawing.Size(64, 34);
            this.staffToolStripMenuItem.Text = "Staff";
            // 
            // addNewStaffToolStripMenuItem
            // 
            this.addNewStaffToolStripMenuItem.Name = "addNewStaffToolStripMenuItem";
            this.addNewStaffToolStripMenuItem.Size = new System.Drawing.Size(204, 28);
            this.addNewStaffToolStripMenuItem.Text = "Add New Staff";
            this.addNewStaffToolStripMenuItem.Click += new System.EventHandler(this.addNewStaffToolStripMenuItem_Click);
            // 
            // upToolStripMenuItem
            // 
            this.upToolStripMenuItem.Name = "upToolStripMenuItem";
            this.upToolStripMenuItem.Size = new System.Drawing.Size(204, 28);
            this.upToolStripMenuItem.Text = "Update Staff";
            // 
            // staffListToolStripMenuItem
            // 
            this.staffListToolStripMenuItem.Name = "staffListToolStripMenuItem";
            this.staffListToolStripMenuItem.Size = new System.Drawing.Size(204, 28);
            this.staffListToolStripMenuItem.Text = "Staff List";
            // 
            // departmentToolStripMenuItem
            // 
            this.departmentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDepartmentToolStripMenuItem,
            this.updateDepartmentToolStripMenuItem});
            this.departmentToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.departmentToolStripMenuItem.Name = "departmentToolStripMenuItem";
            this.departmentToolStripMenuItem.Size = new System.Drawing.Size(123, 34);
            this.departmentToolStripMenuItem.Text = "Department";
            // 
            // addDepartmentToolStripMenuItem
            // 
            this.addDepartmentToolStripMenuItem.Name = "addDepartmentToolStripMenuItem";
            this.addDepartmentToolStripMenuItem.Size = new System.Drawing.Size(247, 28);
            this.addDepartmentToolStripMenuItem.Text = "Add Department";
            // 
            // updateDepartmentToolStripMenuItem
            // 
            this.updateDepartmentToolStripMenuItem.Name = "updateDepartmentToolStripMenuItem";
            this.updateDepartmentToolStripMenuItem.Size = new System.Drawing.Size(247, 28);
            this.updateDepartmentToolStripMenuItem.Text = "Update Department";
            // 
            // userManagementToolStripMenuItem
            // 
            this.userManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUserToolStripMenuItem});
            this.userManagementToolStripMenuItem.Name = "userManagementToolStripMenuItem";
            this.userManagementToolStripMenuItem.Size = new System.Drawing.Size(177, 34);
            this.userManagementToolStripMenuItem.Text = "User Management";
            // 
            // addUserToolStripMenuItem
            // 
            this.addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            this.addUserToolStripMenuItem.Size = new System.Drawing.Size(159, 28);
            this.addUserToolStripMenuItem.Text = "Add User";
            // 
            // lbl_Logged_User
            // 
            this.lbl_Logged_User.AutoSize = true;
            this.lbl_Logged_User.Font = new System.Drawing.Font("Microsoft Uighur", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Logged_User.Location = new System.Drawing.Point(1089, -3);
            this.lbl_Logged_User.Name = "lbl_Logged_User";
            this.lbl_Logged_User.Size = new System.Drawing.Size(145, 41);
            this.lbl_Logged_User.TabIndex = 15;
            this.lbl_Logged_User.Text = "Logged User";
            // 
            // btn_Log_Out
            // 
            this.btn_Log_Out.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Log_Out.BackColor = System.Drawing.Color.Coral;
            this.btn_Log_Out.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Log_Out.Location = new System.Drawing.Point(1376, -1);
            this.btn_Log_Out.Name = "btn_Log_Out";
            this.btn_Log_Out.Size = new System.Drawing.Size(128, 39);
            this.btn_Log_Out.TabIndex = 16;
            this.btn_Log_Out.Text = "Log Out";
            this.btn_Log_Out.UseVisualStyleBackColor = false;
            this.btn_Log_Out.Click += new System.EventHandler(this.btn_Log_Out_Click);
            // 
            // MDI_Staff_Management_System
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1504, 833);
            this.Controls.Add(this.btn_Log_Out);
            this.Controls.Add(this.lbl_Logged_User);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MDI_Staff_Management_System";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Staff Management System";
            this.Load += new System.EventHandler(this.MDI_Staff_Management_System_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem staffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewStaffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem upToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staffListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDepartmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateDepartmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem;
        private System.Windows.Forms.Label lbl_Logged_User;
        private System.Windows.Forms.Button btn_Log_Out;
    }
}




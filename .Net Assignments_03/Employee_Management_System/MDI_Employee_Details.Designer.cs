namespace Employee_Management_System
{
    partial class MDI_Employee_Details
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDepartmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewByDepartmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notePadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btn_Log_Out = new System.Windows.Forms.Button();
            this.lbl_User_Loged_In = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.AutoSize = false;
            this.menuStrip.Font = new System.Drawing.Font("Microsoft Uighur", 18F);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeToolStripMenuItem,
            this.departmentsToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(1308, 46);
            this.menuStrip.TabIndex = 0;
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewEmployeeToolStripMenuItem,
            this.searchEmployeeToolStripMenuItem});
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(112, 42);
            this.employeeToolStripMenuItem.Text = "Employee";
            // 
            // addNewEmployeeToolStripMenuItem
            // 
            this.addNewEmployeeToolStripMenuItem.Name = "addNewEmployeeToolStripMenuItem";
            this.addNewEmployeeToolStripMenuItem.Size = new System.Drawing.Size(260, 44);
            this.addNewEmployeeToolStripMenuItem.Text = "Add New Employee";
            this.addNewEmployeeToolStripMenuItem.Click += new System.EventHandler(this.addNewEmployeeToolStripMenuItem_Click);
            // 
            // searchEmployeeToolStripMenuItem
            // 
            this.searchEmployeeToolStripMenuItem.Name = "searchEmployeeToolStripMenuItem";
            this.searchEmployeeToolStripMenuItem.Size = new System.Drawing.Size(260, 44);
            this.searchEmployeeToolStripMenuItem.Text = "Search Employee";
            this.searchEmployeeToolStripMenuItem.Click += new System.EventHandler(this.searchEmployeeToolStripMenuItem_Click);
            // 
            // departmentsToolStripMenuItem
            // 
            this.departmentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDepartmentsToolStripMenuItem,
            this.viewByDepartmentsToolStripMenuItem});
            this.departmentsToolStripMenuItem.Name = "departmentsToolStripMenuItem";
            this.departmentsToolStripMenuItem.Size = new System.Drawing.Size(159, 42);
            this.departmentsToolStripMenuItem.Text = "View Employee";
            // 
            // addDepartmentsToolStripMenuItem
            // 
            this.addDepartmentsToolStripMenuItem.Name = "addDepartmentsToolStripMenuItem";
            this.addDepartmentsToolStripMenuItem.Size = new System.Drawing.Size(277, 44);
            this.addDepartmentsToolStripMenuItem.Text = "View All Employee";
            this.addDepartmentsToolStripMenuItem.Click += new System.EventHandler(this.addDepartmentsToolStripMenuItem_Click);
            // 
            // viewByDepartmentsToolStripMenuItem
            // 
            this.viewByDepartmentsToolStripMenuItem.Name = "viewByDepartmentsToolStripMenuItem";
            this.viewByDepartmentsToolStripMenuItem.Size = new System.Drawing.Size(277, 44);
            this.viewByDepartmentsToolStripMenuItem.Text = "View By Departments";
            this.viewByDepartmentsToolStripMenuItem.Click += new System.EventHandler(this.viewByDepartmentsToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.notePadToolStripMenuItem,
            this.calculatorToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(75, 42);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // notePadToolStripMenuItem
            // 
            this.notePadToolStripMenuItem.Name = "notePadToolStripMenuItem";
            this.notePadToolStripMenuItem.Size = new System.Drawing.Size(181, 44);
            this.notePadToolStripMenuItem.Text = "NotePad";
            this.notePadToolStripMenuItem.Click += new System.EventHandler(this.notePadToolStripMenuItem_Click);
            // 
            // calculatorToolStripMenuItem
            // 
            this.calculatorToolStripMenuItem.Name = "calculatorToolStripMenuItem";
            this.calculatorToolStripMenuItem.Size = new System.Drawing.Size(181, 44);
            this.calculatorToolStripMenuItem.Text = "Calculator";
            this.calculatorToolStripMenuItem.Click += new System.EventHandler(this.calculatorToolStripMenuItem_Click);
            // 
            // btn_Log_Out
            // 
            this.btn_Log_Out.BackColor = System.Drawing.Color.IndianRed;
            this.btn_Log_Out.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F);
            this.btn_Log_Out.Location = new System.Drawing.Point(1169, 0);
            this.btn_Log_Out.Name = "btn_Log_Out";
            this.btn_Log_Out.Size = new System.Drawing.Size(139, 46);
            this.btn_Log_Out.TabIndex = 8;
            this.btn_Log_Out.Text = "Log Out";
            this.btn_Log_Out.UseVisualStyleBackColor = false;
            this.btn_Log_Out.Click += new System.EventHandler(this.btn_Log_Out_Click);
            // 
            // lbl_User_Loged_In
            // 
            this.lbl_User_Loged_In.AutoSize = true;
            this.lbl_User_Loged_In.Font = new System.Drawing.Font("Microsoft Uighur", 16F);
            this.lbl_User_Loged_In.Location = new System.Drawing.Point(945, 10);
            this.lbl_User_Loged_In.Name = "lbl_User_Loged_In";
            this.lbl_User_Loged_In.Size = new System.Drawing.Size(99, 36);
            this.lbl_User_Loged_In.TabIndex = 9;
            this.lbl_User_Loged_In.Text = "User LogIn";
            // 
            // MDI_Employee_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 826);
            this.Controls.Add(this.lbl_User_Loged_In);
            this.Controls.Add(this.btn_Log_Out);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MDI_Employee_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MDI_Employee_Details";
            this.Load += new System.EventHandler(this.MDI_Employee_Details_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDepartmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewByDepartmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notePadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculatorToolStripMenuItem;
        private System.Windows.Forms.Button btn_Log_Out;
        private System.Windows.Forms.Label lbl_User_Loged_In;
    }
}




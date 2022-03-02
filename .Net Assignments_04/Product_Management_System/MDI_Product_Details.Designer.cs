namespace Product_Management_System
{
    partial class MDI_Product_Details
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
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewByToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notePadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btn_Logout = new System.Windows.Forms.Button();
            this.lbl_Logged_In_User = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.AutoSize = false;
            this.menuStrip.Font = new System.Drawing.Font("Microsoft Uighur", 20F);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productToolStripMenuItem,
            this.viewProductToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.reportToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(1245, 46);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewProductToolStripMenuItem,
            this.searchProductToolStripMenuItem,
            this.updateProductToolStripMenuItem});
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(108, 42);
            this.productToolStripMenuItem.Text = "Product";
            // 
            // addNewProductToolStripMenuItem
            // 
            this.addNewProductToolStripMenuItem.Name = "addNewProductToolStripMenuItem";
            this.addNewProductToolStripMenuItem.Size = new System.Drawing.Size(270, 50);
            this.addNewProductToolStripMenuItem.Text = "Add New Product";
            this.addNewProductToolStripMenuItem.Click += new System.EventHandler(this.addNewProductToolStripMenuItem_Click);
            // 
            // searchProductToolStripMenuItem
            // 
            this.searchProductToolStripMenuItem.Name = "searchProductToolStripMenuItem";
            this.searchProductToolStripMenuItem.Size = new System.Drawing.Size(270, 50);
            this.searchProductToolStripMenuItem.Text = "Search Product";
            this.searchProductToolStripMenuItem.Click += new System.EventHandler(this.searchProductToolStripMenuItem_Click);
            // 
            // updateProductToolStripMenuItem
            // 
            this.updateProductToolStripMenuItem.Name = "updateProductToolStripMenuItem";
            this.updateProductToolStripMenuItem.Size = new System.Drawing.Size(270, 50);
            this.updateProductToolStripMenuItem.Text = "Update Product";
            this.updateProductToolStripMenuItem.Click += new System.EventHandler(this.updateProductToolStripMenuItem_Click);
            // 
            // viewProductToolStripMenuItem
            // 
            this.viewProductToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewAllProductToolStripMenuItem,
            this.viewByToolStripMenuItem});
            this.viewProductToolStripMenuItem.Name = "viewProductToolStripMenuItem";
            this.viewProductToolStripMenuItem.Size = new System.Drawing.Size(161, 42);
            this.viewProductToolStripMenuItem.Text = "View Product";
            // 
            // viewAllProductToolStripMenuItem
            // 
            this.viewAllProductToolStripMenuItem.Name = "viewAllProductToolStripMenuItem";
            this.viewAllProductToolStripMenuItem.Size = new System.Drawing.Size(293, 50);
            this.viewAllProductToolStripMenuItem.Text = "View All Product";
            this.viewAllProductToolStripMenuItem.Click += new System.EventHandler(this.viewAllProductToolStripMenuItem_Click);
            // 
            // viewByToolStripMenuItem
            // 
            this.viewByToolStripMenuItem.Name = "viewByToolStripMenuItem";
            this.viewByToolStripMenuItem.Size = new System.Drawing.Size(293, 50);
            this.viewByToolStripMenuItem.Text = "View By Net Weight";
            this.viewByToolStripMenuItem.Click += new System.EventHandler(this.viewByToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.notePadToolStripMenuItem,
            this.calculatorToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(86, 42);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // notePadToolStripMenuItem
            // 
            this.notePadToolStripMenuItem.Name = "notePadToolStripMenuItem";
            this.notePadToolStripMenuItem.Size = new System.Drawing.Size(200, 50);
            this.notePadToolStripMenuItem.Text = "NotePad";
            this.notePadToolStripMenuItem.Click += new System.EventHandler(this.notePadToolStripMenuItem_Click);
            // 
            // calculatorToolStripMenuItem
            // 
            this.calculatorToolStripMenuItem.Name = "calculatorToolStripMenuItem";
            this.calculatorToolStripMenuItem.Size = new System.Drawing.Size(200, 50);
            this.calculatorToolStripMenuItem.Text = "Calculator";
            this.calculatorToolStripMenuItem.Click += new System.EventHandler(this.calculatorToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(97, 42);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // btn_Logout
            // 
            this.btn_Logout.BackColor = System.Drawing.Color.GreenYellow;
            this.btn_Logout.Font = new System.Drawing.Font("Microsoft Uighur", 20F, System.Drawing.FontStyle.Bold);
            this.btn_Logout.Location = new System.Drawing.Point(1069, 0);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(176, 46);
            this.btn_Logout.TabIndex = 12;
            this.btn_Logout.Text = "Log Out";
            this.btn_Logout.UseVisualStyleBackColor = false;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // lbl_Logged_In_User
            // 
            this.lbl_Logged_In_User.AutoSize = true;
            this.lbl_Logged_In_User.Font = new System.Drawing.Font("Microsoft Uighur", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Logged_In_User.Location = new System.Drawing.Point(795, 4);
            this.lbl_Logged_In_User.Name = "lbl_Logged_In_User";
            this.lbl_Logged_In_User.Size = new System.Drawing.Size(172, 41);
            this.lbl_Logged_In_User.TabIndex = 13;
            this.lbl_Logged_In_User.Text = "Logged In User";
            // 
            // MDI_Product_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 896);
            this.Controls.Add(this.lbl_Logged_In_User);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MDI_Product_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Details";
            this.Load += new System.EventHandler(this.MDI_Product_Details_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAllProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewByToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notePadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Label lbl_Logged_In_User;
    }
}




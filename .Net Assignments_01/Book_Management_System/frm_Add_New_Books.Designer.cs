namespace Book_Management_System
{
    partial class frm_Add_New_Books
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
            this.tb_Book_Name = new System.Windows.Forms.TextBox();
            this.tb_Book_Id = new System.Windows.Forms.TextBox();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_Book_Id = new System.Windows.Forms.Label();
            this.lbl_Add_New_Books = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Log_Out = new System.Windows.Forms.Button();
            this.lbl_Category = new System.Windows.Forms.Label();
            this.lbl_Published_Date = new System.Windows.Forms.Label();
            this.tb_Author_Name = new System.Windows.Forms.TextBox();
            this.lbl_Author_Name = new System.Windows.Forms.Label();
            this.dtp_Published_Date = new System.Windows.Forms.DateTimePicker();
            this.cmb_Category = new System.Windows.Forms.ComboBox();
            this.btn_View_All_Books = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_Book_Name
            // 
            this.tb_Book_Name.Font = new System.Drawing.Font("Comic Sans MS", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Book_Name.Location = new System.Drawing.Point(774, 323);
            this.tb_Book_Name.Name = "tb_Book_Name";
            this.tb_Book_Name.Size = new System.Drawing.Size(401, 56);
            this.tb_Book_Name.TabIndex = 2;
            // 
            // tb_Book_Id
            // 
            this.tb_Book_Id.Font = new System.Drawing.Font("Comic Sans MS", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Book_Id.Location = new System.Drawing.Point(774, 216);
            this.tb_Book_Id.Name = "tb_Book_Id";
            this.tb_Book_Id.Size = new System.Drawing.Size(401, 56);
            this.tb_Book_Id.TabIndex = 1;
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.BackColor = System.Drawing.Color.SpringGreen;
            this.lbl_Password.Font = new System.Drawing.Font("Comic Sans MS", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.ForeColor = System.Drawing.Color.Indigo;
            this.lbl_Password.Location = new System.Drawing.Point(159, 328);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(208, 49);
            this.lbl_Password.TabIndex = 10;
            this.lbl_Password.Text = "Book Name";
            // 
            // lbl_Book_Id
            // 
            this.lbl_Book_Id.AutoSize = true;
            this.lbl_Book_Id.BackColor = System.Drawing.Color.SpringGreen;
            this.lbl_Book_Id.Font = new System.Drawing.Font("Comic Sans MS", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Book_Id.ForeColor = System.Drawing.Color.Indigo;
            this.lbl_Book_Id.Location = new System.Drawing.Point(159, 219);
            this.lbl_Book_Id.Name = "lbl_Book_Id";
            this.lbl_Book_Id.Size = new System.Drawing.Size(154, 49);
            this.lbl_Book_Id.TabIndex = 8;
            this.lbl_Book_Id.Text = "Book Id";
           
            // 
            // lbl_Add_New_Books
            // 
            this.lbl_Add_New_Books.AutoSize = true;
            this.lbl_Add_New_Books.Font = new System.Drawing.Font("Sitka Banner", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Add_New_Books.ForeColor = System.Drawing.Color.Red;
            this.lbl_Add_New_Books.Location = new System.Drawing.Point(399, 24);
            this.lbl_Add_New_Books.Name = "lbl_Add_New_Books";
            this.lbl_Add_New_Books.Size = new System.Drawing.Size(465, 97);
            this.lbl_Add_New_Books.TabIndex = 6;
            this.lbl_Add_New_Books.Text = "Add New Books";
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.Yellow;
            this.btn_Save.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(382, 737);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(144, 50);
            this.btn_Save.TabIndex = 6;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Log_Out
            // 
            this.btn_Log_Out.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Log_Out.BackColor = System.Drawing.Color.Yellow;
            this.btn_Log_Out.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Log_Out.Location = new System.Drawing.Point(1144, 2);
            this.btn_Log_Out.Name = "btn_Log_Out";
            this.btn_Log_Out.Size = new System.Drawing.Size(122, 38);
            this.btn_Log_Out.TabIndex = 7;
            this.btn_Log_Out.Text = "Log Out";
            this.btn_Log_Out.UseVisualStyleBackColor = false;
            this.btn_Log_Out.Click += new System.EventHandler(this.btn_Log_Out_Click);
            // 
            // lbl_Category
            // 
            this.lbl_Category.AutoSize = true;
            this.lbl_Category.BackColor = System.Drawing.Color.SpringGreen;
            this.lbl_Category.Font = new System.Drawing.Font("Comic Sans MS", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Category.ForeColor = System.Drawing.Color.Indigo;
            this.lbl_Category.Location = new System.Drawing.Point(159, 535);
            this.lbl_Category.Name = "lbl_Category";
            this.lbl_Category.Size = new System.Drawing.Size(172, 49);
            this.lbl_Category.TabIndex = 15;
            this.lbl_Category.Text = "Category";
            // 
            // lbl_Published_Date
            // 
            this.lbl_Published_Date.AutoSize = true;
            this.lbl_Published_Date.BackColor = System.Drawing.Color.SpringGreen;
            this.lbl_Published_Date.Font = new System.Drawing.Font("Comic Sans MS", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Published_Date.ForeColor = System.Drawing.Color.Indigo;
            this.lbl_Published_Date.Location = new System.Drawing.Point(159, 426);
            this.lbl_Published_Date.Name = "lbl_Published_Date";
            this.lbl_Published_Date.Size = new System.Drawing.Size(273, 49);
            this.lbl_Published_Date.TabIndex = 14;
            this.lbl_Published_Date.Text = "Published Date";
            // 
            // tb_Author_Name
            // 
            this.tb_Author_Name.Font = new System.Drawing.Font("Comic Sans MS", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Author_Name.Location = new System.Drawing.Point(774, 633);
            this.tb_Author_Name.Name = "tb_Author_Name";
            this.tb_Author_Name.Size = new System.Drawing.Size(401, 56);
            this.tb_Author_Name.TabIndex = 5;
            // 
            // lbl_Author_Name
            // 
            this.lbl_Author_Name.AutoSize = true;
            this.lbl_Author_Name.BackColor = System.Drawing.Color.SpringGreen;
            this.lbl_Author_Name.Font = new System.Drawing.Font("Comic Sans MS", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Author_Name.ForeColor = System.Drawing.Color.Indigo;
            this.lbl_Author_Name.Location = new System.Drawing.Point(159, 640);
            this.lbl_Author_Name.Name = "lbl_Author_Name";
            this.lbl_Author_Name.Size = new System.Drawing.Size(246, 49);
            this.lbl_Author_Name.TabIndex = 17;
            this.lbl_Author_Name.Text = "Author Name";
            // 
            // dtp_Published_Date
            // 
            this.dtp_Published_Date.Font = new System.Drawing.Font("Comic Sans MS", 21F, System.Drawing.FontStyle.Bold);
            this.dtp_Published_Date.Location = new System.Drawing.Point(774, 420);
            this.dtp_Published_Date.Name = "dtp_Published_Date";
            this.dtp_Published_Date.Size = new System.Drawing.Size(401, 56);
            this.dtp_Published_Date.TabIndex = 3;
            // 
            // cmb_Category
            // 
            this.cmb_Category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Category.Font = new System.Drawing.Font("Comic Sans MS", 21F, System.Drawing.FontStyle.Bold);
            this.cmb_Category.FormattingEnabled = true;
            this.cmb_Category.Items.AddRange(new object[] {
            "Novel",
            "Love Story",
            "Historical Fiction",
            "Horror",
            "Short Stories",
            "Biographies"});
            this.cmb_Category.Location = new System.Drawing.Point(774, 527);
            this.cmb_Category.Name = "cmb_Category";
            this.cmb_Category.Size = new System.Drawing.Size(401, 57);
            this.cmb_Category.TabIndex = 4;
            // 
            // btn_View_All_Books
            // 
            this.btn_View_All_Books.BackColor = System.Drawing.Color.Yellow;
            this.btn_View_All_Books.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_View_All_Books.Location = new System.Drawing.Point(715, 737);
            this.btn_View_All_Books.Name = "btn_View_All_Books";
            this.btn_View_All_Books.Size = new System.Drawing.Size(227, 50);
            this.btn_View_All_Books.TabIndex = 18;
            this.btn_View_All_Books.Text = "View All Books";
            this.btn_View_All_Books.UseVisualStyleBackColor = false;
            this.btn_View_All_Books.Click += new System.EventHandler(this.btn_View_All_Books_Click);
            // 
            // frm_Add_New_Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1269, 799);
            this.Controls.Add(this.btn_View_All_Books);
            this.Controls.Add(this.cmb_Category);
            this.Controls.Add(this.dtp_Published_Date);
            this.Controls.Add(this.tb_Author_Name);
            this.Controls.Add(this.lbl_Author_Name);
            this.Controls.Add(this.lbl_Category);
            this.Controls.Add(this.lbl_Published_Date);
            this.Controls.Add(this.btn_Log_Out);
            this.Controls.Add(this.tb_Book_Name);
            this.Controls.Add(this.tb_Book_Id);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_Book_Id);
            this.Controls.Add(this.lbl_Add_New_Books);
            this.Controls.Add(this.btn_Save);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Add_New_Books";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Add_New_Books";
            this.Load += new System.EventHandler(this.frm_Add_New_Books_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Book_Name;
        private System.Windows.Forms.TextBox tb_Book_Id;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_Book_Id;
        private System.Windows.Forms.Label lbl_Add_New_Books;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Log_Out;
        private System.Windows.Forms.Label lbl_Category;
        private System.Windows.Forms.Label lbl_Published_Date;
        private System.Windows.Forms.TextBox tb_Author_Name;
        private System.Windows.Forms.Label lbl_Author_Name;
        private System.Windows.Forms.DateTimePicker dtp_Published_Date;
        private System.Windows.Forms.ComboBox cmb_Category;
        private System.Windows.Forms.Button btn_View_All_Books;
    }
}
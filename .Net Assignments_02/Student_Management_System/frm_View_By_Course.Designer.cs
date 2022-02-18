namespace Student_Management_System
{
    partial class frm_View_By_Course
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
            this.dgv_View_By_Course = new System.Windows.Forms.DataGridView();
            this.studentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_Student_Management_SystemDataSet1 = new Student_Management_System.DB_Student_Management_SystemDataSet1();
            this.btn_View_All_Students = new System.Windows.Forms.Button();
            this.btn_Add_New_Student = new System.Windows.Forms.Button();
            this.btn_Search_Student_Details = new System.Windows.Forms.Button();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.lbl_View_By_Course = new System.Windows.Forms.Label();
            this.cmb_Course = new System.Windows.Forms.ComboBox();
            this.lbl_Course = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.student_DetailsTableAdapter = new Student_Management_System.DB_Student_Management_SystemDataSet1TableAdapters.Student_DetailsTableAdapter();
            this.btn_Refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_By_Course)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_Student_Management_SystemDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_View_By_Course
            // 
            this.dgv_View_By_Course.AllowUserToAddRows = false;
            this.dgv_View_By_Course.AllowUserToDeleteRows = false;
            this.dgv_View_By_Course.AutoGenerateColumns = false;
            this.dgv_View_By_Course.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_View_By_Course.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_View_By_Course.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.dOBDataGridViewTextBoxColumn,
            this.mobileNoDataGridViewTextBoxColumn,
            this.courseDataGridViewTextBoxColumn});
            this.dgv_View_By_Course.DataSource = this.studentDetailsBindingSource;
            this.dgv_View_By_Course.Location = new System.Drawing.Point(27, 240);
            this.dgv_View_By_Course.Name = "dgv_View_By_Course";
            this.dgv_View_By_Course.ReadOnly = true;
            this.dgv_View_By_Course.RowTemplate.Height = 24;
            this.dgv_View_By_Course.Size = new System.Drawing.Size(1205, 433);
            this.dgv_View_By_Course.TabIndex = 32;
            // 
            // studentIdDataGridViewTextBoxColumn
            // 
            this.studentIdDataGridViewTextBoxColumn.DataPropertyName = "Student_Id";
            this.studentIdDataGridViewTextBoxColumn.HeaderText = "Student_Id";
            this.studentIdDataGridViewTextBoxColumn.Name = "studentIdDataGridViewTextBoxColumn";
            this.studentIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dOBDataGridViewTextBoxColumn
            // 
            this.dOBDataGridViewTextBoxColumn.DataPropertyName = "DOB";
            this.dOBDataGridViewTextBoxColumn.HeaderText = "DOB";
            this.dOBDataGridViewTextBoxColumn.Name = "dOBDataGridViewTextBoxColumn";
            this.dOBDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mobileNoDataGridViewTextBoxColumn
            // 
            this.mobileNoDataGridViewTextBoxColumn.DataPropertyName = "Mobile_No";
            this.mobileNoDataGridViewTextBoxColumn.HeaderText = "Mobile_No";
            this.mobileNoDataGridViewTextBoxColumn.Name = "mobileNoDataGridViewTextBoxColumn";
            this.mobileNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // courseDataGridViewTextBoxColumn
            // 
            this.courseDataGridViewTextBoxColumn.DataPropertyName = "Course";
            this.courseDataGridViewTextBoxColumn.HeaderText = "Course";
            this.courseDataGridViewTextBoxColumn.Name = "courseDataGridViewTextBoxColumn";
            this.courseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentDetailsBindingSource
            // 
            this.studentDetailsBindingSource.DataMember = "Student_Details";
            this.studentDetailsBindingSource.DataSource = this.dB_Student_Management_SystemDataSet1;
            // 
            // dB_Student_Management_SystemDataSet1
            // 
            this.dB_Student_Management_SystemDataSet1.DataSetName = "DB_Student_Management_SystemDataSet1";
            this.dB_Student_Management_SystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_View_All_Students
            // 
            this.btn_View_All_Students.BackColor = System.Drawing.Color.GreenYellow;
            this.btn_View_All_Students.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F);
            this.btn_View_All_Students.Location = new System.Drawing.Point(870, 699);
            this.btn_View_All_Students.Name = "btn_View_All_Students";
            this.btn_View_All_Students.Size = new System.Drawing.Size(283, 51);
            this.btn_View_All_Students.TabIndex = 31;
            this.btn_View_All_Students.Text = "View All Students";
            this.btn_View_All_Students.UseVisualStyleBackColor = false;
            this.btn_View_All_Students.Click += new System.EventHandler(this.btn_View_All_Students_Click);
            // 
            // btn_Add_New_Student
            // 
            this.btn_Add_New_Student.BackColor = System.Drawing.Color.GreenYellow;
            this.btn_Add_New_Student.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F);
            this.btn_Add_New_Student.Location = new System.Drawing.Point(86, 699);
            this.btn_Add_New_Student.Name = "btn_Add_New_Student";
            this.btn_Add_New_Student.Size = new System.Drawing.Size(266, 51);
            this.btn_Add_New_Student.TabIndex = 30;
            this.btn_Add_New_Student.Text = "Add New Student";
            this.btn_Add_New_Student.UseVisualStyleBackColor = false;
            this.btn_Add_New_Student.Click += new System.EventHandler(this.btn_Add_New_Student_Click);
            // 
            // btn_Search_Student_Details
            // 
            this.btn_Search_Student_Details.BackColor = System.Drawing.Color.GreenYellow;
            this.btn_Search_Student_Details.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F);
            this.btn_Search_Student_Details.Location = new System.Drawing.Point(429, 699);
            this.btn_Search_Student_Details.Name = "btn_Search_Student_Details";
            this.btn_Search_Student_Details.Size = new System.Drawing.Size(366, 51);
            this.btn_Search_Student_Details.TabIndex = 29;
            this.btn_Search_Student_Details.Text = "Search Student Details";
            this.btn_Search_Student_Details.UseVisualStyleBackColor = false;
            this.btn_Search_Student_Details.Click += new System.EventHandler(this.btn_Search_Student_Details_Click);
            // 
            // btn_Logout
            // 
            this.btn_Logout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Logout.BackColor = System.Drawing.Color.HotPink;
            this.btn_Logout.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.btn_Logout.Location = new System.Drawing.Point(1122, 2);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(134, 42);
            this.btn_Logout.TabIndex = 27;
            this.btn_Logout.Text = "Logout";
            this.btn_Logout.UseVisualStyleBackColor = false;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // lbl_View_By_Course
            // 
            this.lbl_View_By_Course.AutoSize = true;
            this.lbl_View_By_Course.BackColor = System.Drawing.Color.Pink;
            this.lbl_View_By_Course.Font = new System.Drawing.Font("Microsoft YaHei UI", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_View_By_Course.Location = new System.Drawing.Point(306, 42);
            this.lbl_View_By_Course.Name = "lbl_View_By_Course";
            this.lbl_View_By_Course.Size = new System.Drawing.Size(649, 70);
            this.lbl_View_By_Course.TabIndex = 28;
            this.lbl_View_By_Course.Text = "View Student By Course";
            // 
            // cmb_Course
            // 
            this.cmb_Course.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Course.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F);
            this.cmb_Course.FormattingEnabled = true;
            this.cmb_Course.Items.AddRange(new object[] {
            "C Language",
            "C++ ",
            "Java",
            ".Net C#",
            ".Net ASP",
            "HTML",
            "CSS",
            "JS"});
            this.cmb_Course.Location = new System.Drawing.Point(392, 168);
            this.cmb_Course.MaxLength = 20;
            this.cmb_Course.Name = "cmb_Course";
            this.cmb_Course.Size = new System.Drawing.Size(308, 43);
            this.cmb_Course.TabIndex = 33;
            // 
            // lbl_Course
            // 
            this.lbl_Course.AutoSize = true;
            this.lbl_Course.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Course.Location = new System.Drawing.Point(205, 171);
            this.lbl_Course.Name = "lbl_Course";
            this.lbl_Course.Size = new System.Drawing.Size(105, 35);
            this.lbl_Course.TabIndex = 34;
            this.lbl_Course.Text = "Course";
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.GreenYellow;
            this.btn_Search.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F);
            this.btn_Search.Location = new System.Drawing.Point(809, 163);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(146, 51);
            this.btn_Search.TabIndex = 35;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // student_DetailsTableAdapter
            // 
            this.student_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.GreenYellow;
            this.btn_Refresh.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F);
            this.btn_Refresh.Location = new System.Drawing.Point(1029, 163);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(146, 51);
            this.btn_Refresh.TabIndex = 36;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // frm_View_By_Course
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1257, 775);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.cmb_Course);
            this.Controls.Add(this.lbl_Course);
            this.Controls.Add(this.dgv_View_By_Course);
            this.Controls.Add(this.btn_View_All_Students);
            this.Controls.Add(this.btn_Add_New_Student);
            this.Controls.Add(this.btn_Search_Student_Details);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.lbl_View_By_Course);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_View_By_Course";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_View_By_Course";
            this.Load += new System.EventHandler(this.frm_View_By_Course_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_By_Course)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_Student_Management_SystemDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_View_By_Course;
        private System.Windows.Forms.Button btn_View_All_Students;
        private System.Windows.Forms.Button btn_Add_New_Student;
        private System.Windows.Forms.Button btn_Search_Student_Details;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Label lbl_View_By_Course;
        private System.Windows.Forms.ComboBox cmb_Course;
        private System.Windows.Forms.Label lbl_Course;
        private System.Windows.Forms.Button btn_Search;
        private DB_Student_Management_SystemDataSet1 dB_Student_Management_SystemDataSet1;
        private System.Windows.Forms.BindingSource studentDetailsBindingSource;
        private DB_Student_Management_SystemDataSet1TableAdapters.Student_DetailsTableAdapter student_DetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_Refresh;
    }
}
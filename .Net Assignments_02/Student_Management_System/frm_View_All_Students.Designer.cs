namespace Student_Management_System
{
    partial class frm_View_All_Students
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
            this.btn_Logout = new System.Windows.Forms.Button();
            this.lbl_View_All_Student = new System.Windows.Forms.Label();
            this.btn_View_By_Course = new System.Windows.Forms.Button();
            this.btn_Add_New_Student = new System.Windows.Forms.Button();
            this.btn_Search_Student_Details = new System.Windows.Forms.Button();
            this.dgv_View_All_Students = new System.Windows.Forms.DataGridView();
            this.studentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_Student_Management_SystemDataSet = new Student_Management_System.DB_Student_Management_SystemDataSet();
            this.student_DetailsTableAdapter = new Student_Management_System.DB_Student_Management_SystemDataSetTableAdapters.Student_DetailsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_All_Students)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_Student_Management_SystemDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Logout
            // 
            this.btn_Logout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Logout.BackColor = System.Drawing.Color.HotPink;
            this.btn_Logout.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.btn_Logout.Location = new System.Drawing.Point(1120, 2);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(134, 42);
            this.btn_Logout.TabIndex = 21;
            this.btn_Logout.Text = "Logout";
            this.btn_Logout.UseVisualStyleBackColor = false;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // lbl_View_All_Student
            // 
            this.lbl_View_All_Student.AutoSize = true;
            this.lbl_View_All_Student.BackColor = System.Drawing.Color.Pink;
            this.lbl_View_All_Student.Font = new System.Drawing.Font("Microsoft YaHei UI", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_View_All_Student.Location = new System.Drawing.Point(310, 24);
            this.lbl_View_All_Student.Name = "lbl_View_All_Student";
            this.lbl_View_All_Student.Size = new System.Drawing.Size(647, 70);
            this.lbl_View_All_Student.TabIndex = 22;
            this.lbl_View_All_Student.Text = "View All Student Details";
            // 
            // btn_View_By_Course
            // 
            this.btn_View_By_Course.BackColor = System.Drawing.Color.GreenYellow;
            this.btn_View_By_Course.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F);
            this.btn_View_By_Course.Location = new System.Drawing.Point(868, 699);
            this.btn_View_By_Course.Name = "btn_View_By_Course";
            this.btn_View_By_Course.Size = new System.Drawing.Size(283, 51);
            this.btn_View_By_Course.TabIndex = 25;
            this.btn_View_By_Course.Text = "View By Course ";
            this.btn_View_By_Course.UseVisualStyleBackColor = false;
            this.btn_View_By_Course.Click += new System.EventHandler(this.btn_View_By_Course_Click);
            // 
            // btn_Add_New_Student
            // 
            this.btn_Add_New_Student.BackColor = System.Drawing.Color.GreenYellow;
            this.btn_Add_New_Student.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F);
            this.btn_Add_New_Student.Location = new System.Drawing.Point(84, 699);
            this.btn_Add_New_Student.Name = "btn_Add_New_Student";
            this.btn_Add_New_Student.Size = new System.Drawing.Size(266, 51);
            this.btn_Add_New_Student.TabIndex = 24;
            this.btn_Add_New_Student.Text = "Add New Student";
            this.btn_Add_New_Student.UseVisualStyleBackColor = false;
            this.btn_Add_New_Student.Click += new System.EventHandler(this.btn_Add_New_Student_Click);
            // 
            // btn_Search_Student_Details
            // 
            this.btn_Search_Student_Details.BackColor = System.Drawing.Color.GreenYellow;
            this.btn_Search_Student_Details.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F);
            this.btn_Search_Student_Details.Location = new System.Drawing.Point(427, 699);
            this.btn_Search_Student_Details.Name = "btn_Search_Student_Details";
            this.btn_Search_Student_Details.Size = new System.Drawing.Size(366, 51);
            this.btn_Search_Student_Details.TabIndex = 23;
            this.btn_Search_Student_Details.Text = "Search Student Details";
            this.btn_Search_Student_Details.UseVisualStyleBackColor = false;
            this.btn_Search_Student_Details.Click += new System.EventHandler(this.btn_Search_Student_Details_Click);
            // 
            // dgv_View_All_Students
            // 
            this.dgv_View_All_Students.AllowUserToAddRows = false;
            this.dgv_View_All_Students.AllowUserToDeleteRows = false;
            this.dgv_View_All_Students.AutoGenerateColumns = false;
            this.dgv_View_All_Students.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_View_All_Students.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_View_All_Students.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.dOBDataGridViewTextBoxColumn,
            this.mobileNoDataGridViewTextBoxColumn,
            this.courseDataGridViewTextBoxColumn});
            this.dgv_View_All_Students.DataSource = this.studentDetailsBindingSource;
            this.dgv_View_All_Students.Location = new System.Drawing.Point(25, 130);
            this.dgv_View_All_Students.Name = "dgv_View_All_Students";
            this.dgv_View_All_Students.ReadOnly = true;
            this.dgv_View_All_Students.RowTemplate.Height = 24;
            this.dgv_View_All_Students.Size = new System.Drawing.Size(1205, 543);
            this.dgv_View_All_Students.TabIndex = 26;
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
            this.studentDetailsBindingSource.DataSource = this.dB_Student_Management_SystemDataSet;
            // 
            // dB_Student_Management_SystemDataSet
            // 
            this.dB_Student_Management_SystemDataSet.DataSetName = "DB_Student_Management_SystemDataSet";
            this.dB_Student_Management_SystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // student_DetailsTableAdapter
            // 
            this.student_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // frm_View_All_Students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1257, 775);
            this.Controls.Add(this.dgv_View_All_Students);
            this.Controls.Add(this.btn_View_By_Course);
            this.Controls.Add(this.btn_Add_New_Student);
            this.Controls.Add(this.btn_Search_Student_Details);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.lbl_View_All_Student);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_View_All_Students";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_View_All_Students";
            this.Load += new System.EventHandler(this.frm_View_All_Students_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_All_Students)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_Student_Management_SystemDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Label lbl_View_All_Student;
        private System.Windows.Forms.Button btn_View_By_Course;
        private System.Windows.Forms.Button btn_Add_New_Student;
        private System.Windows.Forms.Button btn_Search_Student_Details;
        private System.Windows.Forms.DataGridView dgv_View_All_Students;
        private DB_Student_Management_SystemDataSet dB_Student_Management_SystemDataSet;
        private System.Windows.Forms.BindingSource studentDetailsBindingSource;
        private DB_Student_Management_SystemDataSetTableAdapters.Student_DetailsTableAdapter student_DetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseDataGridViewTextBoxColumn;
    }
}
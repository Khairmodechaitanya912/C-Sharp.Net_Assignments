namespace Employee_Management_System
{
    partial class frm_View_By_Departments
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
            this.dgv_View_By_Employee = new System.Windows.Forms.DataGridView();
            this.employeeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_Employee_Managements_SystemDataSet1 = new Employee_Management_System.DB_Employee_Managements_SystemDataSet1();
            this.lbl_View_By_Employee = new System.Windows.Forms.Label();
            this.cmb_Department = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.employee_DetailsTableAdapter = new Employee_Management_System.DB_Employee_Managements_SystemDataSet1TableAdapters.Employee_DetailsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_By_Employee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_Employee_Managements_SystemDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_View_By_Employee
            // 
            this.dgv_View_By_Employee.AllowUserToAddRows = false;
            this.dgv_View_By_Employee.AllowUserToDeleteRows = false;
            this.dgv_View_By_Employee.AutoGenerateColumns = false;
            this.dgv_View_By_Employee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_View_By_Employee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_View_By_Employee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.dOBDataGridViewTextBoxColumn,
            this.mobileNoDataGridViewTextBoxColumn,
            this.departmentDataGridViewTextBoxColumn});
            this.dgv_View_By_Employee.DataSource = this.employeeDetailsBindingSource;
            this.dgv_View_By_Employee.Location = new System.Drawing.Point(29, 276);
            this.dgv_View_By_Employee.Name = "dgv_View_By_Employee";
            this.dgv_View_By_Employee.ReadOnly = true;
            this.dgv_View_By_Employee.RowTemplate.Height = 24;
            this.dgv_View_By_Employee.Size = new System.Drawing.Size(1236, 457);
            this.dgv_View_By_Employee.TabIndex = 21;
            // 
            // employeeIdDataGridViewTextBoxColumn
            // 
            this.employeeIdDataGridViewTextBoxColumn.DataPropertyName = "Employee_Id";
            this.employeeIdDataGridViewTextBoxColumn.HeaderText = "Employee_Id";
            this.employeeIdDataGridViewTextBoxColumn.Name = "employeeIdDataGridViewTextBoxColumn";
            this.employeeIdDataGridViewTextBoxColumn.ReadOnly = true;
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
            // departmentDataGridViewTextBoxColumn
            // 
            this.departmentDataGridViewTextBoxColumn.DataPropertyName = "Department";
            this.departmentDataGridViewTextBoxColumn.HeaderText = "Department";
            this.departmentDataGridViewTextBoxColumn.Name = "departmentDataGridViewTextBoxColumn";
            this.departmentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeeDetailsBindingSource
            // 
            this.employeeDetailsBindingSource.DataMember = "Employee_Details";
            this.employeeDetailsBindingSource.DataSource = this.dB_Employee_Managements_SystemDataSet1;
            // 
            // dB_Employee_Managements_SystemDataSet1
            // 
            this.dB_Employee_Managements_SystemDataSet1.DataSetName = "DB_Employee_Managements_SystemDataSet1";
            this.dB_Employee_Managements_SystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbl_View_By_Employee
            // 
            this.lbl_View_By_Employee.AutoSize = true;
            this.lbl_View_By_Employee.BackColor = System.Drawing.Color.MediumTurquoise;
            this.lbl_View_By_Employee.Font = new System.Drawing.Font("Microsoft Uighur", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_View_By_Employee.Location = new System.Drawing.Point(420, 27);
            this.lbl_View_By_Employee.Name = "lbl_View_By_Employee";
            this.lbl_View_By_Employee.Size = new System.Drawing.Size(483, 109);
            this.lbl_View_By_Employee.TabIndex = 20;
            this.lbl_View_By_Employee.Text = "View By Employee";
            // 
            // cmb_Department
            // 
            this.cmb_Department.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Department.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F);
            this.cmb_Department.FormattingEnabled = true;
            this.cmb_Department.Items.AddRange(new object[] {
            "Hr",
            "Developer",
            "Marketing",
            "Finance ",
            "Sales"});
            this.cmb_Department.Location = new System.Drawing.Point(397, 189);
            this.cmb_Department.Name = "cmb_Department";
            this.cmb_Department.Size = new System.Drawing.Size(322, 43);
            this.cmb_Department.TabIndex = 23;
            this.cmb_Department.SelectedIndexChanged += new System.EventHandler(this.cmb_Department_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Lavender;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(135, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 35);
            this.label3.TabIndex = 22;
            this.label3.Text = "Department";
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.IndianRed;
            this.btn_Refresh.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F);
            this.btn_Refresh.Location = new System.Drawing.Point(900, 189);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(153, 51);
            this.btn_Refresh.TabIndex = 25;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // employee_DetailsTableAdapter
            // 
            this.employee_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // frm_View_By_Departments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1295, 761);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.cmb_Department);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgv_View_By_Employee);
            this.Controls.Add(this.lbl_View_By_Employee);
            this.Name = "frm_View_By_Departments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "View By Departments";
            this.Load += new System.EventHandler(this.frm_View_By_Departments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_By_Employee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_Employee_Managements_SystemDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_View_By_Employee;
        private System.Windows.Forms.Label lbl_View_By_Employee;
        private System.Windows.Forms.ComboBox cmb_Department;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Refresh;
        private DB_Employee_Managements_SystemDataSet1 dB_Employee_Managements_SystemDataSet1;
        private System.Windows.Forms.BindingSource employeeDetailsBindingSource;
        private DB_Employee_Managements_SystemDataSet1TableAdapters.Employee_DetailsTableAdapter employee_DetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentDataGridViewTextBoxColumn;
    }
}
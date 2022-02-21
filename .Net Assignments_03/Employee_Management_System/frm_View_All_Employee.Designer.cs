namespace Employee_Management_System
{
    partial class frm_View_All_Employee
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
            this.lbl_View_All_Employee = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dB_Employee_Managements_SystemDataSet = new Employee_Management_System.DB_Employee_Managements_SystemDataSet();
            this.employeeDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employee_DetailsTableAdapter = new Employee_Management_System.DB_Employee_Managements_SystemDataSetTableAdapters.Employee_DetailsTableAdapter();
            this.employeeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_Employee_Managements_SystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_View_All_Employee
            // 
            this.lbl_View_All_Employee.AutoSize = true;
            this.lbl_View_All_Employee.BackColor = System.Drawing.Color.MediumTurquoise;
            this.lbl_View_All_Employee.Font = new System.Drawing.Font("Microsoft Uighur", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_View_All_Employee.Location = new System.Drawing.Point(421, 21);
            this.lbl_View_All_Employee.Name = "lbl_View_All_Employee";
            this.lbl_View_All_Employee.Size = new System.Drawing.Size(490, 109);
            this.lbl_View_All_Employee.TabIndex = 18;
            this.lbl_View_All_Employee.Text = "View All Employee";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.dOBDataGridViewTextBoxColumn,
            this.mobileNoDataGridViewTextBoxColumn,
            this.departmentDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.employeeDetailsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(30, 191);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1236, 536);
            this.dataGridView1.TabIndex = 19;
            // 
            // dB_Employee_Managements_SystemDataSet
            // 
            this.dB_Employee_Managements_SystemDataSet.DataSetName = "DB_Employee_Managements_SystemDataSet";
            this.dB_Employee_Managements_SystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeDetailsBindingSource
            // 
            this.employeeDetailsBindingSource.DataMember = "Employee_Details";
            this.employeeDetailsBindingSource.DataSource = this.dB_Employee_Managements_SystemDataSet;
            // 
            // employee_DetailsTableAdapter
            // 
            this.employee_DetailsTableAdapter.ClearBeforeFill = true;
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
            // frm_View_All_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1295, 761);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl_View_All_Employee);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_View_All_Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "View All Employee";
            this.Load += new System.EventHandler(this.frm_View_All_Employee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_Employee_Managements_SystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_View_All_Employee;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DB_Employee_Managements_SystemDataSet dB_Employee_Managements_SystemDataSet;
        private System.Windows.Forms.BindingSource employeeDetailsBindingSource;
        private DB_Employee_Managements_SystemDataSetTableAdapters.Employee_DetailsTableAdapter employee_DetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentDataGridViewTextBoxColumn;
    }
}
namespace Staff_Management_System
{
    partial class frm_Staff_List
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
            this.pnl_Add_New_Staff = new System.Windows.Forms.Panel();
            this.lbl_Add_New_Staff = new System.Windows.Forms.Label();
            this.dgv_All_Staff_List = new System.Windows.Forms.DataGridView();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.dB_Staff_Management_SystemDataSet = new Staff_Management_System.DB_Staff_Management_SystemDataSet();
            this.staffDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.staff_DetailsTableAdapter = new Staff_Management_System.DB_Staff_Management_SystemDataSetTableAdapters.Staff_DetailsTableAdapter();
            this.staffIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.designationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.shiftTimingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hobbiesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_Department = new System.Windows.Forms.Label();
            this.cmb_Department = new System.Windows.Forms.ComboBox();
            this.pnl_Add_New_Staff.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_All_Staff_List)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_Staff_Management_SystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Add_New_Staff
            // 
            this.pnl_Add_New_Staff.BackColor = System.Drawing.Color.MistyRose;
            this.pnl_Add_New_Staff.Controls.Add(this.lbl_Add_New_Staff);
            this.pnl_Add_New_Staff.Location = new System.Drawing.Point(1, 2);
            this.pnl_Add_New_Staff.Name = "pnl_Add_New_Staff";
            this.pnl_Add_New_Staff.Size = new System.Drawing.Size(1508, 124);
            this.pnl_Add_New_Staff.TabIndex = 14;
            // 
            // lbl_Add_New_Staff
            // 
            this.lbl_Add_New_Staff.AutoSize = true;
            this.lbl_Add_New_Staff.Font = new System.Drawing.Font("Microsoft Uighur", 70F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Add_New_Staff.Location = new System.Drawing.Point(535, -11);
            this.lbl_Add_New_Staff.Name = "lbl_Add_New_Staff";
            this.lbl_Add_New_Staff.Size = new System.Drawing.Size(465, 152);
            this.lbl_Add_New_Staff.TabIndex = 0;
            this.lbl_Add_New_Staff.Text = "All Staff List";
            // 
            // dgv_All_Staff_List
            // 
            this.dgv_All_Staff_List.AllowUserToAddRows = false;
            this.dgv_All_Staff_List.AllowUserToDeleteRows = false;
            this.dgv_All_Staff_List.AutoGenerateColumns = false;
            this.dgv_All_Staff_List.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_All_Staff_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_All_Staff_List.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.staffIdDataGridViewTextBoxColumn,
            this.staffNameDataGridViewTextBoxColumn,
            this.dateOfBirthDataGridViewTextBoxColumn,
            this.mobileNoDataGridViewTextBoxColumn,
            this.designationDataGridViewTextBoxColumn,
            this.genderDataGridViewCheckBoxColumn,
            this.shiftTimingDataGridViewTextBoxColumn,
            this.departmentDataGridViewTextBoxColumn,
            this.projectDataGridViewTextBoxColumn,
            this.hobbiesDataGridViewTextBoxColumn,
            this.userIdDataGridViewTextBoxColumn});
            this.dgv_All_Staff_List.DataSource = this.staffDetailsBindingSource;
            this.dgv_All_Staff_List.Location = new System.Drawing.Point(38, 271);
            this.dgv_All_Staff_List.Name = "dgv_All_Staff_List";
            this.dgv_All_Staff_List.ReadOnly = true;
            this.dgv_All_Staff_List.RowTemplate.Height = 24;
            this.dgv_All_Staff_List.Size = new System.Drawing.Size(1431, 493);
            this.dgv_All_Staff_List.TabIndex = 15;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.Coral;
            this.btn_Refresh.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.Location = new System.Drawing.Point(994, 181);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(142, 56);
            this.btn_Refresh.TabIndex = 19;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.Coral;
            this.btn_Close.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.Location = new System.Drawing.Point(1269, 181);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(128, 56);
            this.btn_Close.TabIndex = 20;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.Coral;
            this.btn_Search.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(734, 176);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(128, 56);
            this.btn_Search.TabIndex = 18;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            // 
            // dB_Staff_Management_SystemDataSet
            // 
            this.dB_Staff_Management_SystemDataSet.DataSetName = "DB_Staff_Management_SystemDataSet";
            this.dB_Staff_Management_SystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // staffDetailsBindingSource
            // 
            this.staffDetailsBindingSource.DataMember = "Staff_Details";
            this.staffDetailsBindingSource.DataSource = this.dB_Staff_Management_SystemDataSet;
            // 
            // staff_DetailsTableAdapter
            // 
            this.staff_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // staffIdDataGridViewTextBoxColumn
            // 
            this.staffIdDataGridViewTextBoxColumn.DataPropertyName = "Staff_Id";
            this.staffIdDataGridViewTextBoxColumn.HeaderText = "Staff_Id";
            this.staffIdDataGridViewTextBoxColumn.Name = "staffIdDataGridViewTextBoxColumn";
            this.staffIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // staffNameDataGridViewTextBoxColumn
            // 
            this.staffNameDataGridViewTextBoxColumn.DataPropertyName = "Staff_Name";
            this.staffNameDataGridViewTextBoxColumn.HeaderText = "Staff_Name";
            this.staffNameDataGridViewTextBoxColumn.Name = "staffNameDataGridViewTextBoxColumn";
            this.staffNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateOfBirthDataGridViewTextBoxColumn
            // 
            this.dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "Date_Of_Birth";
            this.dateOfBirthDataGridViewTextBoxColumn.HeaderText = "Date_Of_Birth";
            this.dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
            this.dateOfBirthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mobileNoDataGridViewTextBoxColumn
            // 
            this.mobileNoDataGridViewTextBoxColumn.DataPropertyName = "Mobile_No";
            this.mobileNoDataGridViewTextBoxColumn.HeaderText = "Mobile_No";
            this.mobileNoDataGridViewTextBoxColumn.Name = "mobileNoDataGridViewTextBoxColumn";
            this.mobileNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // designationDataGridViewTextBoxColumn
            // 
            this.designationDataGridViewTextBoxColumn.DataPropertyName = "Designation";
            this.designationDataGridViewTextBoxColumn.HeaderText = "Designation";
            this.designationDataGridViewTextBoxColumn.Name = "designationDataGridViewTextBoxColumn";
            this.designationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // genderDataGridViewCheckBoxColumn
            // 
            this.genderDataGridViewCheckBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewCheckBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewCheckBoxColumn.Name = "genderDataGridViewCheckBoxColumn";
            this.genderDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // shiftTimingDataGridViewTextBoxColumn
            // 
            this.shiftTimingDataGridViewTextBoxColumn.DataPropertyName = "Shift_Timing";
            this.shiftTimingDataGridViewTextBoxColumn.HeaderText = "Shift_Timing";
            this.shiftTimingDataGridViewTextBoxColumn.Name = "shiftTimingDataGridViewTextBoxColumn";
            this.shiftTimingDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // departmentDataGridViewTextBoxColumn
            // 
            this.departmentDataGridViewTextBoxColumn.DataPropertyName = "Department";
            this.departmentDataGridViewTextBoxColumn.HeaderText = "Department";
            this.departmentDataGridViewTextBoxColumn.Name = "departmentDataGridViewTextBoxColumn";
            this.departmentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // projectDataGridViewTextBoxColumn
            // 
            this.projectDataGridViewTextBoxColumn.DataPropertyName = "Project";
            this.projectDataGridViewTextBoxColumn.HeaderText = "Project";
            this.projectDataGridViewTextBoxColumn.Name = "projectDataGridViewTextBoxColumn";
            this.projectDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hobbiesDataGridViewTextBoxColumn
            // 
            this.hobbiesDataGridViewTextBoxColumn.DataPropertyName = "Hobbies";
            this.hobbiesDataGridViewTextBoxColumn.HeaderText = "Hobbies";
            this.hobbiesDataGridViewTextBoxColumn.Name = "hobbiesDataGridViewTextBoxColumn";
            this.hobbiesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            this.userIdDataGridViewTextBoxColumn.DataPropertyName = "User_Id";
            this.userIdDataGridViewTextBoxColumn.HeaderText = "User_Id";
            this.userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            this.userIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lbl_Department
            // 
            this.lbl_Department.AutoSize = true;
            this.lbl_Department.Font = new System.Drawing.Font("Microsoft Uighur", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Department.Location = new System.Drawing.Point(104, 176);
            this.lbl_Department.Name = "lbl_Department";
            this.lbl_Department.Size = new System.Drawing.Size(183, 52);
            this.lbl_Department.TabIndex = 22;
            this.lbl_Department.Text = "Department";
            // 
            // cmb_Department
            // 
            this.cmb_Department.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Department.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold);
            this.cmb_Department.FormattingEnabled = true;
            this.cmb_Department.Location = new System.Drawing.Point(325, 183);
            this.cmb_Department.Name = "cmb_Department";
            this.cmb_Department.Size = new System.Drawing.Size(320, 45);
            this.cmb_Department.TabIndex = 21;
            // 
            // frm_Staff_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1504, 795);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_Department);
            this.Controls.Add(this.cmb_Department);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.dgv_All_Staff_List);
            this.Controls.Add(this.pnl_Add_New_Staff);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Staff_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frm_Staff_List";
            this.Load += new System.EventHandler(this.frm_Staff_List_Load);
            this.pnl_Add_New_Staff.ResumeLayout(false);
            this.pnl_Add_New_Staff.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_All_Staff_List)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_Staff_Management_SystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Add_New_Staff;
        private System.Windows.Forms.Label lbl_Add_New_Staff;
        private System.Windows.Forms.DataGridView dgv_All_Staff_List;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_Search;
        private DB_Staff_Management_SystemDataSet dB_Staff_Management_SystemDataSet;
        private System.Windows.Forms.BindingSource staffDetailsBindingSource;
        private DB_Staff_Management_SystemDataSetTableAdapters.Staff_DetailsTableAdapter staff_DetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn designationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn genderDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shiftTimingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hobbiesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lbl_Department;
        private System.Windows.Forms.ComboBox cmb_Department;
    }
}
namespace Book_Management_System
{
    partial class frm_View_All_Books
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_View_All_Books = new System.Windows.Forms.Label();
            this.btn_Log_Out = new System.Windows.Forms.Button();
            this.btn_Add_New_Books = new System.Windows.Forms.Button();
            this.dgv_View_All_Books = new System.Windows.Forms.DataGridView();
            this.bookIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publishedDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_Books_Managements_SystemDataSet = new Book_Management_System.DB_Books_Managements_SystemDataSet();
            this.book_DetailsTableAdapter = new Book_Management_System.DB_Books_Managements_SystemDataSetTableAdapters.Book_DetailsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_All_Books)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_Books_Managements_SystemDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_View_All_Books
            // 
            this.lbl_View_All_Books.AutoSize = true;
            this.lbl_View_All_Books.Font = new System.Drawing.Font("Sitka Banner", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_View_All_Books.ForeColor = System.Drawing.Color.Red;
            this.lbl_View_All_Books.Location = new System.Drawing.Point(397, 9);
            this.lbl_View_All_Books.Name = "lbl_View_All_Books";
            this.lbl_View_All_Books.Size = new System.Drawing.Size(445, 97);
            this.lbl_View_All_Books.TabIndex = 7;
            this.lbl_View_All_Books.Text = "View All Books";
            // 
            // btn_Log_Out
            // 
            this.btn_Log_Out.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Log_Out.BackColor = System.Drawing.Color.Yellow;
            this.btn_Log_Out.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Log_Out.Location = new System.Drawing.Point(1145, 2);
            this.btn_Log_Out.Name = "btn_Log_Out";
            this.btn_Log_Out.Size = new System.Drawing.Size(122, 38);
            this.btn_Log_Out.TabIndex = 3;
            this.btn_Log_Out.Text = "Log Out";
            this.btn_Log_Out.UseVisualStyleBackColor = false;
            this.btn_Log_Out.Click += new System.EventHandler(this.btn_Log_Out_Click);
            // 
            // btn_Add_New_Books
            // 
            this.btn_Add_New_Books.BackColor = System.Drawing.Color.Yellow;
            this.btn_Add_New_Books.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_New_Books.Location = new System.Drawing.Point(491, 726);
            this.btn_Add_New_Books.Name = "btn_Add_New_Books";
            this.btn_Add_New_Books.Size = new System.Drawing.Size(268, 50);
            this.btn_Add_New_Books.TabIndex = 2;
            this.btn_Add_New_Books.Text = "Add New Books";
            this.btn_Add_New_Books.UseVisualStyleBackColor = false;
            this.btn_Add_New_Books.Click += new System.EventHandler(this.btn_Add_New_Books_Click);
            // 
            // dgv_View_All_Books
            // 
            this.dgv_View_All_Books.AutoGenerateColumns = false;
            this.dgv_View_All_Books.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_View_All_Books.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_View_All_Books.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_View_All_Books.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookIdDataGridViewTextBoxColumn,
            this.bookNameDataGridViewTextBoxColumn,
            this.publishedDateDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.authorNameDataGridViewTextBoxColumn});
            this.dgv_View_All_Books.DataSource = this.bookDetailsBindingSource;
            this.dgv_View_All_Books.Location = new System.Drawing.Point(12, 122);
            this.dgv_View_All_Books.Name = "dgv_View_All_Books";
            this.dgv_View_All_Books.RowTemplate.Height = 24;
            this.dgv_View_All_Books.Size = new System.Drawing.Size(1220, 583);
            this.dgv_View_All_Books.TabIndex = 11;
            // 
            // bookIdDataGridViewTextBoxColumn
            // 
            this.bookIdDataGridViewTextBoxColumn.DataPropertyName = "Book_Id";
            this.bookIdDataGridViewTextBoxColumn.HeaderText = "Book_Id";
            this.bookIdDataGridViewTextBoxColumn.Name = "bookIdDataGridViewTextBoxColumn";
            // 
            // bookNameDataGridViewTextBoxColumn
            // 
            this.bookNameDataGridViewTextBoxColumn.DataPropertyName = "Book_Name";
            this.bookNameDataGridViewTextBoxColumn.HeaderText = "Book_Name";
            this.bookNameDataGridViewTextBoxColumn.Name = "bookNameDataGridViewTextBoxColumn";
            // 
            // publishedDateDataGridViewTextBoxColumn
            // 
            this.publishedDateDataGridViewTextBoxColumn.DataPropertyName = "Published_Date";
            this.publishedDateDataGridViewTextBoxColumn.HeaderText = "Published_Date";
            this.publishedDateDataGridViewTextBoxColumn.Name = "publishedDateDataGridViewTextBoxColumn";
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            // 
            // authorNameDataGridViewTextBoxColumn
            // 
            this.authorNameDataGridViewTextBoxColumn.DataPropertyName = "Author_Name";
            this.authorNameDataGridViewTextBoxColumn.HeaderText = "Author_Name";
            this.authorNameDataGridViewTextBoxColumn.Name = "authorNameDataGridViewTextBoxColumn";
            // 
            // bookDetailsBindingSource
            // 
            this.bookDetailsBindingSource.DataMember = "Book_Details";
            this.bookDetailsBindingSource.DataSource = this.dB_Books_Managements_SystemDataSet;
            // 
            // dB_Books_Managements_SystemDataSet
            // 
            this.dB_Books_Managements_SystemDataSet.DataSetName = "DB_Books_Managements_SystemDataSet";
            this.dB_Books_Managements_SystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // book_DetailsTableAdapter
            // 
            this.book_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // frm_View_All_Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1269, 799);
            this.Controls.Add(this.dgv_View_All_Books);
            this.Controls.Add(this.btn_Add_New_Books);
            this.Controls.Add(this.btn_Log_Out);
            this.Controls.Add(this.lbl_View_All_Books);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_View_All_Books";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_View_All_Books";
            this.Load += new System.EventHandler(this.frm_View_All_Books_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_All_Books)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_Books_Managements_SystemDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_View_All_Books;
        private System.Windows.Forms.Button btn_Log_Out;
        private System.Windows.Forms.Button btn_Add_New_Books;
        private System.Windows.Forms.DataGridView dgv_View_All_Books;
        private DB_Books_Managements_SystemDataSet dB_Books_Managements_SystemDataSet;
        private System.Windows.Forms.BindingSource bookDetailsBindingSource;
        private DB_Books_Managements_SystemDataSetTableAdapters.Book_DetailsTableAdapter book_DetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publishedDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorNameDataGridViewTextBoxColumn;
    }
}
namespace Product_Management_System
{
    partial class frm_View_All_Product
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_View_All_Product = new System.Windows.Forms.Label();
            this.dgv_View_All_Product = new System.Windows.Forms.DataGridView();
            this.dB_Product_Management_SystemDataSet = new Product_Management_System.DB_Product_Management_SystemDataSet();
            this.productDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.product_DetailsTableAdapter = new Product_Management_System.DB_Product_Management_SystemDataSetTableAdapters.Product_DetailsTableAdapter();
            this.productIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mfgDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expiryDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mRPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.netWeightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_All_Product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_Product_Management_SystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.HotPink;
            this.panel1.Controls.Add(this.lbl_View_All_Product);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1221, 133);
            this.panel1.TabIndex = 29;
            // 
            // lbl_View_All_Product
            // 
            this.lbl_View_All_Product.AutoSize = true;
            this.lbl_View_All_Product.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 55F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_View_All_Product.Location = new System.Drawing.Point(190, 20);
            this.lbl_View_All_Product.Name = "lbl_View_All_Product";
            this.lbl_View_All_Product.Size = new System.Drawing.Size(791, 92);
            this.lbl_View_All_Product.TabIndex = 0;
            this.lbl_View_All_Product.Text = "View All Product";
            // 
            // dgv_View_All_Product
            // 
            this.dgv_View_All_Product.AllowUserToAddRows = false;
            this.dgv_View_All_Product.AllowUserToDeleteRows = false;
            this.dgv_View_All_Product.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_View_All_Product.AutoGenerateColumns = false;
            this.dgv_View_All_Product.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_View_All_Product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_View_All_Product.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIdDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.mfgDateDataGridViewTextBoxColumn,
            this.expiryDateDataGridViewTextBoxColumn,
            this.mRPDataGridViewTextBoxColumn,
            this.netWeightDataGridViewTextBoxColumn});
            this.dgv_View_All_Product.DataSource = this.productDetailsBindingSource;
            this.dgv_View_All_Product.Location = new System.Drawing.Point(24, 201);
            this.dgv_View_All_Product.Name = "dgv_View_All_Product";
            this.dgv_View_All_Product.ReadOnly = true;
            this.dgv_View_All_Product.RowTemplate.Height = 24;
            this.dgv_View_All_Product.Size = new System.Drawing.Size(1097, 581);
            this.dgv_View_All_Product.TabIndex = 30;
            // 
            // dB_Product_Management_SystemDataSet
            // 
            this.dB_Product_Management_SystemDataSet.DataSetName = "DB_Product_Management_SystemDataSet";
            this.dB_Product_Management_SystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productDetailsBindingSource
            // 
            this.productDetailsBindingSource.DataMember = "Product_Details";
            this.productDetailsBindingSource.DataSource = this.dB_Product_Management_SystemDataSet;
            // 
            // product_DetailsTableAdapter
            // 
            this.product_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // productIdDataGridViewTextBoxColumn
            // 
            this.productIdDataGridViewTextBoxColumn.DataPropertyName = "Product_Id";
            this.productIdDataGridViewTextBoxColumn.HeaderText = "Product_Id";
            this.productIdDataGridViewTextBoxColumn.Name = "productIdDataGridViewTextBoxColumn";
            this.productIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "Product_Name";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "Product_Name";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mfgDateDataGridViewTextBoxColumn
            // 
            this.mfgDateDataGridViewTextBoxColumn.DataPropertyName = "Mfg_Date";
            this.mfgDateDataGridViewTextBoxColumn.HeaderText = "Mfg_Date";
            this.mfgDateDataGridViewTextBoxColumn.Name = "mfgDateDataGridViewTextBoxColumn";
            this.mfgDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // expiryDateDataGridViewTextBoxColumn
            // 
            this.expiryDateDataGridViewTextBoxColumn.DataPropertyName = "Expiry_Date";
            this.expiryDateDataGridViewTextBoxColumn.HeaderText = "Expiry_Date";
            this.expiryDateDataGridViewTextBoxColumn.Name = "expiryDateDataGridViewTextBoxColumn";
            this.expiryDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mRPDataGridViewTextBoxColumn
            // 
            this.mRPDataGridViewTextBoxColumn.DataPropertyName = "MRP";
            this.mRPDataGridViewTextBoxColumn.HeaderText = "MRP";
            this.mRPDataGridViewTextBoxColumn.Name = "mRPDataGridViewTextBoxColumn";
            this.mRPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // netWeightDataGridViewTextBoxColumn
            // 
            this.netWeightDataGridViewTextBoxColumn.DataPropertyName = "Net_Weight";
            this.netWeightDataGridViewTextBoxColumn.HeaderText = "Net_Weight";
            this.netWeightDataGridViewTextBoxColumn.Name = "netWeightDataGridViewTextBoxColumn";
            this.netWeightDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frm_View_All_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1152, 806);
            this.ControlBox = false;
            this.Controls.Add(this.dgv_View_All_Product);
            this.Controls.Add(this.panel1);
            this.Name = "frm_View_All_Product";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "View All Product";
            this.Load += new System.EventHandler(this.frm_View_All_Product_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_All_Product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_Product_Management_SystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_View_All_Product;
        private System.Windows.Forms.DataGridView dgv_View_All_Product;
        private DB_Product_Management_SystemDataSet dB_Product_Management_SystemDataSet;
        private System.Windows.Forms.BindingSource productDetailsBindingSource;
        private DB_Product_Management_SystemDataSetTableAdapters.Product_DetailsTableAdapter product_DetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mfgDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expiryDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mRPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn netWeightDataGridViewTextBoxColumn;
    }
}
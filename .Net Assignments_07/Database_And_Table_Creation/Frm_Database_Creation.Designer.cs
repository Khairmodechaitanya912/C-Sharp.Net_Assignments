namespace Database_And_Table_Creation
{
    partial class Frm_Database_Creation
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.tb_Table_Name = new System.Windows.Forms.TextBox();
            this.tb_Database_Name = new System.Windows.Forms.TextBox();
            this.lbl_Table_Name = new System.Windows.Forms.Label();
            this.lbl_Database_Name = new System.Windows.Forms.Label();
            this.btn_Create = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.lbl_Title);
            this.panel1.Location = new System.Drawing.Point(-8, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1052, 114);
            this.panel1.TabIndex = 7;
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Mongolian Baiti", 46F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(59, 16);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(948, 82);
            this.lbl_Title.TabIndex = 1;
            this.lbl_Title.Text = "Database And Table Creation";
            // 
            // tb_Table_Name
            // 
            this.tb_Table_Name.Font = new System.Drawing.Font("Mongolian Baiti", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Table_Name.Location = new System.Drawing.Point(575, 348);
            this.tb_Table_Name.Name = "tb_Table_Name";
            this.tb_Table_Name.Size = new System.Drawing.Size(312, 46);
            this.tb_Table_Name.TabIndex = 12;
            // 
            // tb_Database_Name
            // 
            this.tb_Database_Name.Font = new System.Drawing.Font("Mongolian Baiti", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Database_Name.Location = new System.Drawing.Point(575, 189);
            this.tb_Database_Name.Name = "tb_Database_Name";
            this.tb_Database_Name.Size = new System.Drawing.Size(312, 46);
            this.tb_Database_Name.TabIndex = 11;
            // 
            // lbl_Table_Name
            // 
            this.lbl_Table_Name.AutoSize = true;
            this.lbl_Table_Name.Font = new System.Drawing.Font("Mongolian Baiti", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Table_Name.Location = new System.Drawing.Point(151, 358);
            this.lbl_Table_Name.Name = "lbl_Table_Name";
            this.lbl_Table_Name.Size = new System.Drawing.Size(182, 36);
            this.lbl_Table_Name.TabIndex = 10;
            this.lbl_Table_Name.Text = "Table Name";
            // 
            // lbl_Database_Name
            // 
            this.lbl_Database_Name.AutoSize = true;
            this.lbl_Database_Name.Font = new System.Drawing.Font("Mongolian Baiti", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Database_Name.Location = new System.Drawing.Point(151, 199);
            this.lbl_Database_Name.Name = "lbl_Database_Name";
            this.lbl_Database_Name.Size = new System.Drawing.Size(229, 36);
            this.lbl_Database_Name.TabIndex = 9;
            this.lbl_Database_Name.Text = "Database Name";
            // 
            // btn_Create
            // 
            this.btn_Create.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_Create.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Create.Location = new System.Drawing.Point(404, 518);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(153, 54);
            this.btn_Create.TabIndex = 8;
            this.btn_Create.Text = "Create";
            this.btn_Create.UseVisualStyleBackColor = false;
            this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click);
            // 
            // Frm_Database_Creation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1041, 668);
            this.Controls.Add(this.tb_Table_Name);
            this.Controls.Add(this.tb_Database_Name);
            this.Controls.Add(this.lbl_Table_Name);
            this.Controls.Add(this.lbl_Database_Name);
            this.Controls.Add(this.btn_Create);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Database_Creation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Database Creation";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.TextBox tb_Table_Name;
        private System.Windows.Forms.TextBox tb_Database_Name;
        private System.Windows.Forms.Label lbl_Table_Name;
        private System.Windows.Forms.Label lbl_Database_Name;
        private System.Windows.Forms.Button btn_Create;
    }
}
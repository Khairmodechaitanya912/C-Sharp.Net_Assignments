using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Product_Management_System
{
    public partial class frm_Search_Product : Form
    {
        public frm_Search_Product()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=DB_Product_Management_System;Integrated Security=True");

        void Con_Open()
        {
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
        }

        void Con_Close()
        {
            if (Con.State == ConnectionState.Open)
            {
                Con.Close();
            }
        }

        void Clear_Controls()
        {
            tb_Product_Id.Clear();
            tb_Product_Name.Clear();
            tb_MRP.Clear();
            dtp_Expiry_Date.ResetText();
            dtp_Mfg_Date.ResetText();
            cmb_Net_Weight.SelectedIndex = -1;

            tb_Product_Name.Focus();
        }
        private void frm_Search_Product_Load(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Con_Open();

            if (tb_Product_Id.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = Con;
                Cmd.CommandText = "Select ";
            }
            Con_Close();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }
    }
}

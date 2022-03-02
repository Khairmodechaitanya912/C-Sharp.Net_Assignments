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
    public partial class frm_Add_New_Product : Form
    {
        public frm_Add_New_Product()
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
            tb_Product_Id.Text = Convert.ToString(Auto_Increament_Id());
            tb_Product_Name.Clear();
            tb_MRP.Clear();
            dtp_Expiry_Date.ResetText();
            dtp_Mfg_Date.ResetText();
            cmb_Net_Weight.SelectedIndex = -1;

            tb_Product_Name.Focus();
        }

        int Auto_Increament_Id()
        {
            Con_Open();

            int Cnt = -1;

            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = Con;
            Cmd.CommandText = "Select Count(*) from Product_Details ";

            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            Cmd.Dispose();

            if (Cnt > 0)
            {
                Cmd.Connection = Con;
                Cmd.CommandText = "Select Max(Product_Id) from Product_Details";

                Cnt = Convert.ToInt32(Cmd.ExecuteScalar()) + 1;

            }

            else
            {
                Cnt = 101;
            }

            Con_Close();
            return Cnt;

        }
        private void frm_Add_New_Product_Load(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Con_Open();

            if (tb_Product_Id.Text != "" && tb_Product_Name.Text != "" && tb_MRP.Text != "")
            {

                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = Con;
                Cmd.CommandText = "Insert Into Product_Details (Product_Id, Product_Name, Mfg_Date, Expiry_Date, MRP, Net_Weight) Values (@ID, @Name, @MFG, @EXP, @MRP, @NET)";

                Cmd.Parameters.Add("ID", SqlDbType.Int).Value = tb_Product_Id.Text;
                Cmd.Parameters.Add("Name", SqlDbType.NVarChar).Value = tb_Product_Name.Text;
                Cmd.Parameters.Add("MFG", SqlDbType.Date).Value = dtp_Mfg_Date.Value.Date;
                Cmd.Parameters.Add("EXP", SqlDbType.Date).Value = dtp_Expiry_Date.Value.Date;
                Cmd.Parameters.Add("MRP", SqlDbType.Money).Value = tb_MRP.Text;
                Cmd.Parameters.Add("NET", SqlDbType.NVarChar).Value = cmb_Net_Weight.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Product Details Saved Successfully....!!", "Saving", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear_Controls();
            }

            else
            {
                MessageBox.Show("Plz Fill all Information..!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Con_Close();
        }
    }
}

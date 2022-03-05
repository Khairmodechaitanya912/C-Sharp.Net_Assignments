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
    public partial class frm_Update_Product_Details : Form
    {
        public frm_Update_Product_Details()
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

            tb_Product_Id.Focus();
        }

        private void frm_Update_Product_Details_Load(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            Con_Open();

            if (tb_Product_Id.Text != "" && tb_Product_Name.Text != "" && tb_MRP.Text != "")
            {

                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = Con;
                Cmd.CommandText = "Update Product_Details Set Product_Name = @Name , Mfg_Date = @MFG, Expiry_Date = @EXP, MRP = @MRP, Net_Weight = @NET Where Product_Id = @ID";

                Cmd.Parameters.Add("ID", SqlDbType.Int).Value = tb_Product_Id.Text;
                Cmd.Parameters.Add("Name", SqlDbType.NVarChar).Value = tb_Product_Name.Text;
                Cmd.Parameters.Add("MFG", SqlDbType.Date).Value = dtp_Mfg_Date.Value.Date;
                Cmd.Parameters.Add("EXP", SqlDbType.Date).Value = dtp_Expiry_Date.Value.Date;
                Cmd.Parameters.Add("MRP", SqlDbType.Money).Value = tb_MRP.Text;
                Cmd.Parameters.Add("NET", SqlDbType.NVarChar).Value = cmb_Net_Weight.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Product Details Updated Successfully....!!", "Updating", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear_Controls();
            }

            else
            {
                MessageBox.Show("Plz Fill all Information..!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Con_Close();

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Con_Open();

            if (tb_Product_Id.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = Con;
                Cmd.CommandText = "Select * from Product_Details Where Product_Id = " + tb_Product_Id.Text + "";

                var Obj = Cmd.ExecuteReader();

                if (Obj.Read())
                {
                    tb_Product_Name.Text = Obj.GetString(Obj.GetOrdinal("Product_Name"));
                    dtp_Mfg_Date.Text = (Obj["Mfg_Date"].ToString());
                    dtp_Expiry_Date.Text = (Obj["Expiry_Date"].ToString());
                    tb_MRP.Text = (Obj["MRP"].ToString());
                    cmb_Net_Weight.Text = Obj.GetString(Obj.GetOrdinal("Net_Weight"));

                }

                else
                {
                    MessageBox.Show("Information is Not Available Which You Are Searching", "No Record Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Clear_Controls();
                }
            }

            Con_Close();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }
    }
}

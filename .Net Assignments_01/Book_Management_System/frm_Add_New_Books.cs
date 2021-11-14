using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Book_Management_System
{
    public partial class frm_Add_New_Books : Form
    {
        public frm_Add_New_Books()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=DB_Books_Managements_System;Integrated Security=True");
        
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

      void Clear_Control()
      {

          tb_Book_Id.Clear();
          tb_Book_Name.Clear();
          dtp_Published_Date.ResetText();
          cmb_Category.SelectedIndex = -1;
          tb_Author_Name.Clear();

          tb_Book_Id.Focus();

      }

        private void btn_View_All_Books_Click(object sender, EventArgs e)
        {
            frm_View_All_Books Obj = new frm_View_All_Books();

            Obj.Show();

            this.Hide();
        }

        private void btn_Log_Out_Click(object sender, EventArgs e)
        {
           DialogResult Res = MessageBox.Show(" Are You Sure....!!!", "LogOut",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
           if (Res == DialogResult.Yes)
           {
               frm_Login Obj = new frm_Login();

               Obj.Show();

               this.Hide();
           }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (tb_Book_Id.Text != "" && tb_Book_Name.Text != "" && tb_Author_Name.Text != "" && cmb_Category.Text != "")
            {
                Con_Open();

                SqlCommand cmd = new SqlCommand();

                cmd.Connection = Con;

                cmd.CommandText = " Insert into Book_Details (Book_Id,Book_Name,Published_Date,Category,Author_Name) Values(@BID,@BNAME,@BPD,@BC,@BAN)";

                cmd.Parameters.Add("BID", SqlDbType.NVarChar).Value = tb_Book_Id.Text;
                cmd.Parameters.Add("BNAME", SqlDbType.NVarChar).Value = tb_Book_Name.Text;
                cmd.Parameters.Add("BPD", SqlDbType.Date).Value = dtp_Published_Date.Value.Date;
                cmd.Parameters.Add("BC", SqlDbType.NVarChar).Value = cmb_Category.Text;
                cmd.Parameters.Add("BAN", SqlDbType.VarChar).Value = tb_Author_Name.Text;


                cmd.ExecuteNonQuery();

                MessageBox.Show("Details Saved Successfully....!! ", "Saving", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            else
            {
                MessageBox.Show("Plz Fill All Information.....!!!");
            }

            Con_Close();

            Clear_Control();

        }

        private void frm_Add_New_Books_Load(object sender, EventArgs e)
        {
            Clear_Control();

        }

  

    }
}

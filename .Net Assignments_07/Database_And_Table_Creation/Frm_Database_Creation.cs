using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Database_And_Table_Creation
{
    public partial class Frm_Database_Creation : Form
    {
        public Frm_Database_Creation()
        {
            InitializeComponent();
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {

            if (tb_Database_Name.Text != "" && tb_Table_Name.Text != "")
            {
                try
                {
                    String ConString = @"Data Source=.\SQLEXPRESS;Initial Catalog= ;Integrated Security=True";

                    SqlConnection Con = new SqlConnection(ConString);

                    Con.Open();
                    SqlCommand Cmd = new SqlCommand();
                    Cmd.Connection = Con;
                    Cmd.CommandText = "Create Database " + tb_Database_Name.Text + "";
                    Cmd.ExecuteNonQuery();

                    MessageBox.Show("Create Database.....!!!!!!");

                    Cmd.Dispose();
                    Con.ChangeDatabase(tb_Database_Name.Text);
                    // SqlCommand Cmd = new SqlCommand();
                    Cmd.Connection = Con;
                    Cmd.CommandText = "Create Table " + tb_Table_Name.Text + " (ID int,Name nvarchar)";
                    Cmd.ExecuteNonQuery();
                    // Cmd1.Dispose();

                    MessageBox.Show("Create Table.....!!!!!!");

                    tb_Database_Name.Clear();
                    tb_Table_Name.Clear();

                    Con.Close();

                }
                catch (Exception)
                {

                    throw;
                }

            }
            else
            {
                MessageBox.Show("First Fill All Information.....!!!!");
            }
        }
    }
}

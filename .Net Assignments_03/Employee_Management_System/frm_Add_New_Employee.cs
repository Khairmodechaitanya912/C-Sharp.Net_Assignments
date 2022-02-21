using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Employee_Management_System
{
    public partial class frm_Add_New_Employee : Form
    {
        public frm_Add_New_Employee()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=DB_Employee_Managements_System;Integrated Security=True");

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

        int Auto_Increaments_Id()
        {
            Con_Open();

            int Cnt = -1;

            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Con;

            Cmd.CommandText = "Select Count(*) from Employee_Details";

            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            Cmd.Dispose();

            if (Cnt > 0)
            {

                Cmd.Connection = Con;
                Cmd.CommandText = "Select Max(Employee_Id) from Employee_Details";

                Cnt = Convert.ToInt32(Cmd.ExecuteScalar()) + 1;

            }

            else
            {

                Cnt = 1001;

            }

            Con_Close();

            return Cnt;
        }
        void Clear_Controls()
        {
            tb_Employee_Id.Text = Convert.ToString(Auto_Increaments_Id());

            tb_Name.Clear();
            tb_Mobile_No.Clear();
            dtp_DOB.ResetText();
            cmb_Department.SelectedIndex = -1;

        }
        private void frm_Add_New_Employee_Load(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Con_Open();

            if (tb_Employee_Id.Text != "" && tb_Mobile_No.Text != "" && tb_Name.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;
                Cmd.CommandText = "Insert into Employee_Details (Employee_Id, Name, DOB, Mobile_No, Department) Values (@Id, @Name, @DOB, @Mob, @Dep)";

                Cmd.Parameters.Add("Id", SqlDbType.Int).Value = tb_Employee_Id.Text;
                Cmd.Parameters.Add("Name", SqlDbType.NVarChar).Value = tb_Name.Text;
                Cmd.Parameters.Add("DOB", SqlDbType.Date).Value = dtp_DOB.Value.Date;
                Cmd.Parameters.Add("Mob", SqlDbType.Decimal).Value = tb_Mobile_No.Text;
                Cmd.Parameters.Add("Dep", SqlDbType.NVarChar).Value = cmb_Department.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Employee Details Saved Sucessfully...!!", "Saving", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Incomplete Information Plzz Fill All Details...!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Clear_Controls();
            Con_Close();
        }
    }
}

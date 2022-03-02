using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Product_Management_System
{
    public partial class frm_View_By_Net_Weight : Form
    {
        public frm_View_By_Net_Weight()
        {
            InitializeComponent();
        }

        private void frm_View_By_Net_Weight_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_Product_Management_SystemDataSet1.Product_Details' table. You can move, or remove it, as needed.
            this.product_DetailsTableAdapter.Fill(this.dB_Product_Management_SystemDataSet1.Product_Details);

        }
    }
}

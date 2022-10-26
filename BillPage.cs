using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace billpage
{
    public partial class BillPage : Form
    {
        public BillPage()
        {
            InitializeComponent();
        }

        private void lbl_invoice_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Quantity_Click(object sender, EventArgs e)
        {

        }

        private void lbl_transactionid_Click(object sender, EventArgs e)
        {

        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=INBAWN166940\\SQLEXPRESS;Initial Catalog=Fooddelivery;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[bill]
           (
           [Order_Id]
           ,[transaction_Id]
           ,[Items]
           ,[Quantity]
           ,[Tax]
           ,[Total _price])
     VALUES
           ('" + orderid.Text + "','" + transactionid.Text + "','" + items.Text + "','" + quantity.Text + "','" + tax.Text + "','" + totalprice.Text + "')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Billing completed");
        }
    }
}

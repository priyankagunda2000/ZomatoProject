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

namespace RestaurantRegistration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=INBAWN170255\\SQLEXPRESS;Initial Catalog=Fooddelivery;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(@" INSERT INTO [dbo].[RestaurantRegistrationInfo]
           ([Restaurant Name]
           ,[Owner Name]
           ,[Mobile No]
           ,[Email-Id]
           ,[Address]
           ,[Password])
 
     VALUES
             ('" + restaurantname.Text + "','" + ownername.Text + ",'" +mobileno.Text + "','"+emailid.Text+"','" + address.Text+ "', '"+password.Text +"' )", conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Registeration Successfull!!");
        }
    }
}

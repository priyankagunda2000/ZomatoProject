using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace FoodieZone_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button_register_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=INPHWN123679;Initial Catalog=Fooddelivery;Integrated Security=True");
         
            SqlCommand cmd = new SqlCommand(@" INSERT INTO [dbo].[user_register]
           ([User_name]
           ,[User_email]
           ,[User_phone]
           ,[User_address]
           ,[User_password])
     VALUES
           ('"+username.Text+"','" + email.Text + "','" + phone.Text + "','" + address.Text + "','" + password.Text + "')", conn);


            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Registeration Successfull!!");

        }
    }
}

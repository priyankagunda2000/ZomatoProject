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

namespace FoodieZone
{
    public partial class frm_feedback : Form
    {
        public frm_feedback()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void chk_v1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lbl_desc1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_commnet_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=INBAWN166940\\SQLEXPRESS;Initial Catalog=Fooddelivery;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[Feedback]
           ([user_name]
           ,[order_id]
           ,[restuarant_name]
           ,[variety5]
           ,[variety4]
           ,[variety3]
           ,[variety2]
           ,[variety1]
           ,[quality5]
           ,[quality4]
           ,[quality3]
           ,[quality2]
           ,[quality1]
           ,[money5]
           ,[money4]
           ,[money3]
           ,[money2]
           ,[money1]
           ,[taste5]
           ,[taste4]
           ,[taste3]
           ,[taste2]
           ,[taste1]
           ,[speed5]
           ,[speed4]
           ,[speed3]
           ,[speed2]
           ,[speed1]
           ,[comment])
     VALUES
           ('" + txt_username.Text+"','"+txt_orderid.Text+"','"+ cmb_restaurant.SelectedItem.ToString()+ "','" + (short)chk_v5.CheckState + "','" + (short)chk_v4.CheckState + "','" + (short)chk_v3.CheckState + "','" + (short)chk_v2.CheckState + "','" + (short)chk_v1.CheckState + "','" + (short)chk_q5.CheckState + "','" + (short)chk_q4.CheckState + "','" + (short)chk_q3.CheckState + "','" + (short)chk_q2.CheckState + "','" + (short)chk_q1.CheckState + "','" + (short)chk_m5.CheckState + "','" + (short)chk_m4.CheckState + "','" + (short)chk_m3.CheckState + "','" + (short)chk_m2.CheckState + "','" + (short)chk_m1.CheckState + "','" + (short)chk_t5.CheckState + "','" + (short)chk_t4.CheckState + "','" + (short)chk_t3.CheckState + "','" + (short)chk_t2.CheckState + "','" + (short)chk_t1.CheckState + "','" + (short)chk_s5.CheckState + "','" + (short)chk_s4.CheckState + "','" + (short)chk_s3.CheckState + "','" + (short)chk_s2.CheckState + "','" + (short)chk_s1.CheckState + "','" + txt_commnet.Text+"')",con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            DialogResult isubmit;
            isubmit= MessageBox.Show("Thank you for submitting Feedback");
            Application.Exit(); 
           
        }
    }
}

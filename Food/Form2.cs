using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Food
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (Form3 f3 = new Form3())
            {
                this.Hide();

                DialogResult result = f3.ShowDialog();
                if (result == DialogResult.OK)
                {
                    this.Show();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (Form1 f1 = new Form1())
            {
                this.Hide();

                DialogResult result = f1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    this.Show();
                }
            }
        }
    }
}

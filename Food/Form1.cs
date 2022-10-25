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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (Form2 f2 = new Form2())
            {
                this.Hide();



                DialogResult result = f2.ShowDialog();
                if (result == DialogResult.OK)
                {
                    this.Show();
                }
            }
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

        private void button4_Click(object sender, EventArgs e)
        {
            using (Form4 f4 = new Form4())
            {
                this.Hide();

                DialogResult result = f4.ShowDialog();
                if (result == DialogResult.OK)
                {
                    this.Show();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (Form2 f2 = new Form2())
            {
                this.Hide();



                DialogResult result = f2.ShowDialog();
                if (result == DialogResult.OK)
                {
                    this.Show();
                }
            }
        }
    }
}

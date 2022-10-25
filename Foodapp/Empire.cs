using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foodapp
{
    public partial class Empire : Form
    {
       
        public Empire()
        {
            InitializeComponent();
        }

        private void Starters_Click(object sender, EventArgs e)
        {
            if (!panel3.Controls.Contains(Starters_empire.Instance))
            {
                panel3.Controls.Add(Starters_empire.Instance);
                Starters_empire.Instance.Dock = DockStyle.Fill;
                Starters_empire.Instance.BringToFront();

            }
            else
                Starters_empire.Instance.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!panel3.Controls.Contains(biriyani_empire.Instance))
            {
                panel3.Controls.Add(biriyani_empire.Instance);
                biriyani_empire.Instance.Dock = DockStyle.Fill;
                biriyani_empire.Instance.BringToFront();

            }
            else
                biriyani_empire.Instance.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!panel3.Controls.Contains(salads_empire.Instance))
            {
                panel3.Controls.Add(salads_empire.Instance);
                salads_empire.Instance.Dock = DockStyle.Fill;
                salads_empire.Instance.BringToFront();

            }
            else
                salads_empire.Instance.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!panel3.Controls.Contains(Drinks_empire.Instance))
            {
                panel3.Controls.Add(Drinks_empire.Instance);
                Drinks_empire.Instance.Dock = DockStyle.Fill;
                Drinks_empire.Instance.BringToFront();

            }
            else
                Drinks_empire.Instance.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!panel3.Controls.Contains(Desserts_empire.Instance))
            {
                panel3.Controls.Add(Desserts_empire.Instance);
                Desserts_empire.Instance.Dock = DockStyle.Fill;
                Desserts_empire.Instance.BringToFront();

            }
            else
                Desserts_empire.Instance.BringToFront();
        }
    }
}

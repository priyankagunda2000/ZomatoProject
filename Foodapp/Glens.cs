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
    public partial class Glens : Form
    {
        private static Glens _obj;
        public static Glens Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new Glens();
                }
                return _obj;

            }
        }
        public Glens()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!panel3.Controls.Contains(breakfast_gb.Instance))
            {
                panel3.Controls.Add(breakfast_gb.Instance);
                breakfast_gb.Instance.Dock = DockStyle.Fill;
                breakfast_gb.Instance.BringToFront();

            }
            else
                breakfast_gb.Instance.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!panel3.Controls.Contains(pizza_gb.Instance))
            {
                panel3.Controls.Add(pizza_gb.Instance);
                pizza_gb.Instance.Dock = DockStyle.Fill;
                pizza_gb.Instance.BringToFront();

            }
            else
                pizza_gb.Instance.BringToFront();

        }

        private void Starters_Click(object sender, EventArgs e)
        {
            if (!panel3.Controls.Contains(burger_gb.Instance))
            {
                panel3.Controls.Add(burger_gb.Instance);
                burger_gb.Instance.Dock = DockStyle.Fill;
                burger_gb.Instance.BringToFront();

            }
            else
                burger_gb.Instance.BringToFront();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!panel3.Controls.Contains(cake_gb.Instance))
            {
                panel3.Controls.Add(cake_gb.Instance);
                cake_gb.Instance.Dock = DockStyle.Fill;
                cake_gb.Instance.BringToFront();

            }
            else
                cake_gb.Instance.BringToFront();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!panel3.Controls.Contains(coldbeverages_gb.Instance))
            {
                panel3.Controls.Add(coldbeverages_gb.Instance);
                coldbeverages_gb.Instance.Dock = DockStyle.Fill;
                coldbeverages_gb.Instance.BringToFront();

            }
            else
                coldbeverages_gb.Instance.BringToFront();
        }
    }
}

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
    public partial class Elchico : Form
    {
        private static Elchico _obj;
        public static Elchico Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new Elchico();
                }
                return _obj;

            }
        }
        public Elchico()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!panel3.Controls.Contains(Appetizers_el.Instance))
            {
                panel3.Controls.Add(Appetizers_el.Instance);
                Appetizers_el.Instance.Dock = DockStyle.Fill;
                Appetizers_el.Instance.BringToFront();

            }
            else
                Appetizers_el.Instance.BringToFront();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!panel3.Controls.Contains(pasta_el.Instance))
            {
                panel3.Controls.Add(pasta_el.Instance);
                pasta_el.Instance.Dock = DockStyle.Fill;
                pasta_el.Instance.BringToFront();

            }
            else
                pasta_el.Instance.BringToFront();

        }

        private void Starters_Click(object sender, EventArgs e)
        {
            if (!panel3.Controls.Contains(continental_el.Instance))
            {
                panel3.Controls.Add(continental_el.Instance);
                continental_el.Instance.Dock = DockStyle.Fill;
                continental_el.Instance.BringToFront();

            }
            else
                continental_el.Instance.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!panel3.Controls.Contains(icecream_el.Instance))
            {
                panel3.Controls.Add(icecream_el.Instance);
                icecream_el.Instance.Dock = DockStyle.Fill;
                icecream_el.Instance.BringToFront();

            }
            else
                icecream_el.Instance.BringToFront();
        }
    }
}

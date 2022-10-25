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
    public partial class meghanafoods : Form
    {
        private static meghanafoods _obj;
        public static meghanafoods Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new meghanafoods();
                }
                return _obj;

            }
        }
        public meghanafoods()
        {
            InitializeComponent();
        }

        private void meghanafoods_Load(object sender, EventArgs e)
        {

        }

        private void Starters_Click(object sender, EventArgs e)
        {
            if (!panel3.Controls.Contains(veg_starters_mf.Instance))
            {
                panel3.Controls.Add(veg_starters_mf.Instance);
                veg_starters_mf.Instance.Dock = DockStyle.Fill;
                veg_starters_mf.Instance.BringToFront();

            }
            else
                veg_starters_mf.Instance.BringToFront();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!panel3.Controls.Contains(nonveg_starters_mf.Instance))
            {
                panel3.Controls.Add(nonveg_starters_mf.Instance);
                nonveg_starters_mf.Instance.Dock = DockStyle.Fill;
                nonveg_starters_mf.Instance.BringToFront();

            }
            else
                nonveg_starters_mf.Instance.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!panel3.Controls.Contains(mbiriyani_mf.Instance))
            {
                panel3.Controls.Add(mbiriyani_mf.Instance);
                mbiriyani_mf.Instance.Dock = DockStyle.Fill;
                mbiriyani_mf.Instance.BringToFront();

            }
            else
               mbiriyani_mf.Instance.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!panel3.Controls.Contains(beverages_mf.Instance))
            {
                panel3.Controls.Add(beverages_mf.Instance);
                beverages_mf.Instance.Dock = DockStyle.Fill;
                beverages_mf.Instance.BringToFront();

            }
            else
                beverages_mf.Instance.BringToFront();
        }
    }
}

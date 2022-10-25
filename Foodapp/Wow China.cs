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
    public partial class Wow_China : Form
    {
        private static Wow_China _obj;
        public static Wow_China Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new Wow_China();
                }
                return _obj;

            }
        }
        public Wow_China()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!panel3.Controls.Contains(soups_wc.Instance))
            {
                panel3.Controls.Add(soups_wc.Instance);
                soups_wc.Instance.Dock = DockStyle.Fill;
                soups_wc.Instance.BringToFront();

            }
            else
                soups_wc.Instance.BringToFront();
        }

        private void Starters_Click(object sender, EventArgs e)
        {
            if (!panel3.Controls.Contains(starter_wc.Instance))
            {
                panel3.Controls.Add(starter_wc.Instance);
                starter_wc.Instance.Dock = DockStyle.Fill;
                starter_wc.Instance.BringToFront();

            }
            else
                starter_wc.Instance.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!panel3.Controls.Contains(noodles_Wc.Instance))
            {
                panel3.Controls.Add(noodles_Wc.Instance);
                noodles_Wc.Instance.Dock = DockStyle.Fill;
                noodles_Wc.Instance.BringToFront();

            }
            else
                noodles_Wc.Instance.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!panel3.Controls.Contains(khaosuey.Instance))
            {
                panel3.Controls.Add(khaosuey.Instance);
                khaosuey.Instance.Dock = DockStyle.Fill;
                khaosuey.Instance.BringToFront();

            }
            else
                khaosuey.Instance.BringToFront();
        }
    }
}

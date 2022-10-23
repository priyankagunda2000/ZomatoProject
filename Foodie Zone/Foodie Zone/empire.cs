using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foodie_Zone
{
    public partial class empire : Form
    {
        public empire()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       

        private void Starters_Click_1(object sender, EventArgs e)
        {
            Starters_empire starters_UC = new Starters_empire();
            starters_UC.BringToFront();
            starters_UC.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Salads_empire salads_UC = new Salads_empire();
            salads_UC.BringToFront();
            salads_UC.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Drinks_empire drinks_UC = new Drinks_empire();
            drinks_UC.BringToFront();
            drinks_UC.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Deserts_empire deserts_UC = new Deserts_empire();
            deserts_UC.BringToFront();
            deserts_UC.Show();
        }
    }
}

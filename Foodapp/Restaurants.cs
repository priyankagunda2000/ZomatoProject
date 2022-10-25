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
    public partial class Restaurants : Form
    {
        public static Restaurants Instance;
        public Restaurants()
        {
            InitializeComponent();
            Instance = this;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Empire empire = new Empire();
            empire.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Glens glens = new Glens();
            glens.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
          Wow_China china = new Wow_China();
            china.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Elchico elchico = new Elchico();
                elchico.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            meghanafoods meghanafoods = new meghanafoods(); 
                meghanafoods.Show();
        }
    }
}

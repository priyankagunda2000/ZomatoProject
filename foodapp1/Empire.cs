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
            Starters_empire starters_Empire = new Starters_empire();    
            starters_Empire.Visible=true;
        }
    }
}

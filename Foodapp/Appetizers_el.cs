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
    public partial class Appetizers_el : UserControl
    {
        private static Appetizers_el _obj;

        public static Appetizers_el Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new Appetizers_el();
                }
                return _obj;

            }
        }
        public Appetizers_el()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

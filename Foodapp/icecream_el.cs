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
    public partial class icecream_el : UserControl
    {
        private static icecream_el _obj;

        public static icecream_el Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new icecream_el();
                }
                return _obj;

            }
        }
        public icecream_el()
        {
            InitializeComponent();
        }
    }
}

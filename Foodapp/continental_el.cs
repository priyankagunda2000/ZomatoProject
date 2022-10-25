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
    public partial class continental_el : UserControl
    {
        private static continental_el _obj;

        public static continental_el Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new continental_el();
                }
                return _obj;

            }
        }
        public continental_el()
        {
            InitializeComponent();
        }
    }
}

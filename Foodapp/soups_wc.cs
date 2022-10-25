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
    public partial class soups_wc : UserControl
    {
        private static soups_wc _obj;

        public static soups_wc Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new soups_wc();
                }
                return _obj;

            }
        }
        public soups_wc()
        {
            InitializeComponent();
        }
    }
}

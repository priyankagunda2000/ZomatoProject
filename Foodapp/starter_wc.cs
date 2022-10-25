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
    public partial class starter_wc : UserControl
    {
        private static starter_wc _obj;

        public static starter_wc Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new starter_wc();
                }
                return _obj;

            }
        }
        public starter_wc()
        {
            InitializeComponent();
        }
    }
}

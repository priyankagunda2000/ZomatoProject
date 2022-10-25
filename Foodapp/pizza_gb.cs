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
    public partial class pizza_gb : UserControl
    {

        private static pizza_gb _obj;

        public static pizza_gb Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new pizza_gb();
                }
                return _obj;

            }
        }
        public pizza_gb()
        {
            InitializeComponent();
        }
    }
}

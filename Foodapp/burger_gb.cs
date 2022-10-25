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
    public partial class burger_gb : UserControl
    {

        private static burger_gb _obj;

        public static burger_gb Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new burger_gb();
                }
                return _obj;

            }
        }
        public burger_gb()
        {
            InitializeComponent();
        }
    }
}

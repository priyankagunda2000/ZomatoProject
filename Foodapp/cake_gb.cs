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
    public partial class cake_gb : UserControl
    {

        private static cake_gb _obj;

        public static cake_gb Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new cake_gb();
                }
                return _obj;

            }
        }
        public cake_gb()
        {
            InitializeComponent();
        }
    }
}

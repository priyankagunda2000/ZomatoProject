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
    public partial class veg_starters_mf : UserControl
    {
        private static veg_starters_mf _obj;

        public static veg_starters_mf Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new veg_starters_mf();
                }
                return _obj;
            }

        }
        public veg_starters_mf()
        {
            InitializeComponent();
        }
    }
}

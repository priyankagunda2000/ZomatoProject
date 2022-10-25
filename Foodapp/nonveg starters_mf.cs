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
    public partial class nonveg_starters_mf : UserControl
    {
        private static nonveg_starters_mf _obj;

        public static nonveg_starters_mf Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new nonveg_starters_mf();
                }
                return _obj;
            }

        }
        public nonveg_starters_mf()
        {
            InitializeComponent();
        }
    }
}

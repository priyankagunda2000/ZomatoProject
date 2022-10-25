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
    public partial class beverages_mf : UserControl
    {
        private static beverages_mf _obj;

        public static beverages_mf Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new beverages_mf();
                }
                return _obj;
            }

        }
        public beverages_mf()
        {
            InitializeComponent();
        }
    }
}

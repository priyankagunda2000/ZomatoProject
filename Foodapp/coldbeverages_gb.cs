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
    public partial class coldbeverages_gb : UserControl
    {

        private static coldbeverages_gb _obj;

        public static coldbeverages_gb Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new coldbeverages_gb();
                }
                return _obj;

            }
        }
        public coldbeverages_gb()
        {
            InitializeComponent();
        }
    }
}

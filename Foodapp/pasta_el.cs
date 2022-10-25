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
    public partial class pasta_el : UserControl
    {
        private static pasta_el _obj;

        public static pasta_el Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new pasta_el();
                }
                return _obj;

            }
        }
        public pasta_el()
        {
            InitializeComponent();
        }
    }
}

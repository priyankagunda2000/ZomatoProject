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
    public partial class salads_empire : UserControl
    {
        private static salads_empire _obj;

        public static salads_empire Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new salads_empire();
                }
                return _obj;

            }
        }
        public salads_empire()
        {
            InitializeComponent();
        }
    }
}

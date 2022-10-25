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
    public partial class mbiriyani_mf : UserControl
    {
        private static mbiriyani_mf _obj;

        public static mbiriyani_mf Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new mbiriyani_mf();
                }
                return _obj;
            }

        }
        public mbiriyani_mf()
        {
            InitializeComponent();
        }
    }
}

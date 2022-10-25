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
    public partial class khaosuey : UserControl
    {
        private static khaosuey _obj;

        public static khaosuey Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new khaosuey();
                }
                return _obj;

            }
        }
        public khaosuey()
        {
            InitializeComponent();
        }
    }
}

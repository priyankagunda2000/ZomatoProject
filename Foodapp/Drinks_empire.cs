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
    public partial class Drinks_empire : UserControl
    {
        private static Drinks_empire _obj;

        public static Drinks_empire Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new Drinks_empire();
                }
                return _obj;

            }
        }
        public Drinks_empire()
        {
            InitializeComponent();
        }
    }
}

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
    public partial class Starters_empire : UserControl
    {
        private static Starters_empire _obj;

        public static Starters_empire Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new Starters_empire();
                }
                return _obj;

            }
        }
        public Starters_empire()
        {
            InitializeComponent();
        }
    }
}

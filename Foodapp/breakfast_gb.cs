﻿using System;
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
    public partial class breakfast_gb : UserControl
    {

        private static breakfast_gb _obj;

        public static breakfast_gb Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new breakfast_gb();
                }
                return _obj;

            }
        }
        public breakfast_gb()
        {
            InitializeComponent();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apteka_Plus
{
    public partial class AptekaUserControl : UserControl
    {
        public AptekaUserControl(string id)
        {
            InitializeComponent();

            pictureBox1.Load("../../Pictures/Аптека" + id + ".jpg");
        }
    }
}
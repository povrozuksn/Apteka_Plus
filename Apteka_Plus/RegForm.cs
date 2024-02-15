using System;
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
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();

            DisignUserControl.ApplyDisign(this);
        }
    }
}

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
    public partial class UniqueDiesignForm : Form
    {
        Button btn;
        public UniqueDiesignForm(Button _btn)
        {
            InitializeComponent();

            btn = _btn;
            SamplBTN.Text = btn.Text;
            SamplBTN.Font = btn.Font;
            SamplBTN.ForeColor = btn.ForeColor;
            SamplBTN.BackColor = btn.BackColor;
            SamplBTN.Size = btn.Size;
        }
    }
}

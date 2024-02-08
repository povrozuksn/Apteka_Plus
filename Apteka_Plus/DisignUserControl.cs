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
    public partial class DisignUserControl : UserControl
    {
        Font LABEL_FONT;
        Color LABEL_COLOR;

        public DisignUserControl()
        {
            InitializeComponent();
        }

        private void EditLabelBTN_Click(object sender, EventArgs e)
        {
            if(fontDialog1.ShowDialog() == DialogResult.OK)
            {
                LABEL_FONT = fontDialog1.Font;
                LABEL_COLOR = fontDialog1.Color;

                SampleLabel.Font = LABEL_FONT;
                SampleLabel.ForeColor = LABEL_COLOR;
            }
        }
    }
}

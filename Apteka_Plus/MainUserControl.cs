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
    public partial class MainUserControl : UserControl
    {
        public MainUserControl()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            AptekaUserControl aptekaUC = new AptekaUserControl(pb.Tag.ToString());
            Controls.Clear();
            Controls.Add(aptekaUC);
            aptekaUC.Dock = DockStyle.None;
        }
    }
}

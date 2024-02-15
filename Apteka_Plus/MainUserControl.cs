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

            List<string> apteks = SQLClass.MySelect("SELECT id, name, pic FROM level1");

            int x = 10;
            for (int i = 0; i < apteks.Count; i += 3)
            {
                Label lbl = new Label();
                lbl.Location = new Point(x, 30);
                lbl.Size = new Size(200, 30);
                lbl.Font = new Font("Arial Narrow", 13);
                lbl.Text = apteks[i + 1];
                lbl.Tag = apteks[i];
                lbl.Click += new EventHandler(label2_Click);
                Controls.Add(lbl);

                PictureBox pb = new PictureBox();
                try
                {
                    pb.Load("../../Pictures/" + apteks[i + 2]);
                }
                catch (Exception) { }
                pb.Location = new Point(x, 70);
                pb.Size = new Size(200, 130);
                pb.SizeMode = PictureBoxSizeMode.Zoom;
                pb.Tag = apteks[i];
                pb.Click += new EventHandler(pictureBox1_Click);
                Controls.Add(pb);

                x += 210;
            }

            DisignUserControl.ApplyDisign(this);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            AptekaUserControl aptekaUC = new AptekaUserControl(pb.Tag.ToString());
            Controls.Clear();
            Controls.Add(aptekaUC);
            aptekaUC.Dock = DockStyle.None;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            AptekaUserControl aptekaUC = new AptekaUserControl(lbl.Tag.ToString());
            Controls.Clear();
            Controls.Add(aptekaUC);
            aptekaUC.Dock = DockStyle.None;
        }
    }
}

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
    public partial class AptekaUserControl : UserControl
    {
        public AptekaUserControl(string id)
        {
            InitializeComponent();

            List<string> apteka = SQLClass.MySelect("SELECT id, name, pic FROM level1 WHERE id = '" + id + "'");

            NumberLabel.Text = apteka[1];

            try
            {
                pictureBox1.Load("../../Pictures/" + apteka[2]);
            }
            catch (Exception) { }


            List<string> classif = SQLClass.MySelect("SELECT id, name, pic FROM level2 WHERE id_apteka = '" + id + "'");

            int x = 10;
            for(int i=0; i<classif.Count; i+=3)
            {
                Label lbl = new Label();
                lbl.Location = new Point(x, 30);
                lbl.Size = new Size(200, 30);
                lbl.Font = new Font("Arial Narrow", 13);
                lbl.Text = classif[i + 1];
                lbl.Tag = classif[i];
                lbl.Click += new EventHandler(label_Click);
                ViewPanel.Controls.Add(lbl);

                PictureBox pb = new PictureBox();
                try
                {
                    pb.Load("../../Pictures/" + classif[i + 2]);
                }
                catch (Exception) { }
                pb.Location = new Point(x, 70);
                pb.Size = new Size(200, 130);
                pb.SizeMode = PictureBoxSizeMode.Zoom;
                pb.Tag = classif[i];
                pb.Click += new EventHandler(pirture_Click);
                ViewPanel.Controls.Add(pb);

                x += 210;
            }



            DisignUserControl.ApplyDisign(this);

        }

        private void label_Click(object sender, EventArgs e)
        {
            Label lb = (Label)sender;
            ClassificatorUserControl classUC = new ClassificatorUserControl(lb.Tag.ToString());
            Controls.Clear();
            Controls.Add(classUC);
            classUC.Dock = DockStyle.None;
        }


        private void pirture_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            ClassificatorUserControl classUC = new ClassificatorUserControl(pb.Tag.ToString());
            Controls.Clear();
            Controls.Add(classUC);
            classUC.Dock = DockStyle.None;
        }
    }
}

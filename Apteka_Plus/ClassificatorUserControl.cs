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
    public partial class ClassificatorUserControl : UserControl
    {
        public ClassificatorUserControl(string id)
        {
            InitializeComponent();

            List<string> classific = SQLClass.MySelect("SELECT id, name, pic FROM level2 WHERE id = '" + id + "'");

            string id_class = classific[0];

            NameLabel.Text = classific[1];

            try
            {
                pictureBox1.Load("../../Pictures/" + classific[2]);
            }
            catch (Exception) { }

            List<string> med = SQLClass.MySelect("SELECT id, name, pic, price FROM level3 WHERE id_class = '" + id_class + "'");

            int x = 10;
            for (int i = 0; i < med.Count; i += 4)
            {
                Label lbl = new Label();
                lbl.Location = new Point(x, 30);
                lbl.Size = new Size(200, 30);
                lbl.Font = new Font("Arial Narrow", 13);
                lbl.Text = med[i + 1];
                lbl.Tag = med[i];
                lbl.Click += new EventHandler(label_Click);
                ViewPanel.Controls.Add(lbl);

                PictureBox pb = new PictureBox();
                try
                {
                    pb.Load("../../Pictures/" + med[i + 2]);
                }
                catch (Exception) { }
                pb.Location = new Point(x, 70);
                pb.Size = new Size(200, 130);
                pb.SizeMode = PictureBoxSizeMode.Zoom;
                pb.Tag = med[i];
                pb.Click += new EventHandler(pirture_Click);
                ViewPanel.Controls.Add(pb);

                Label LabelLabel = new Label();
                LabelLabel.Name = "LabelLabel";
                LabelLabel.Location = new Point(x, 230);
                LabelLabel.Size = new Size(120, 30);
                LabelLabel.Font = new Font("Arial Narrow", 13);
                LabelLabel.Text = "Цена, руб.:  ";
                ViewPanel.Controls.Add(LabelLabel);

                Label PriceLabel = new Label();
                PriceLabel.Name = "PriceLabel";
                PriceLabel.Location = new Point(x+120, 230);
                PriceLabel.Size = new Size(100, 30);
                PriceLabel.Font = new Font("Arial Narrow", 13);
                PriceLabel.Text = med[i + 3];
                ViewPanel.Controls.Add(PriceLabel);

                x += 230;
            }


            DisignUserControl.ApplyDisign(this);

        }

        private void label_Click(object sender, EventArgs e)
        {
            Label lb = (Label)sender;
            MedicomentUserControl medUC = new MedicomentUserControl(lb.Tag.ToString());
            Controls.Clear();
            Controls.Add(medUC);
            medUC.Dock = DockStyle.None;
        }


        private void pirture_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            MedicomentUserControl medUC = new MedicomentUserControl(pb.Tag.ToString());
            Controls.Clear();
            Controls.Add(medUC);
            medUC.Dock = DockStyle.None;
        }
    }
}

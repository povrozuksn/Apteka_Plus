using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apteka_Plus
{
    public partial class AdminKlassUC : UserControl
    {
        public AdminKlassUC()
        {
            InitializeComponent();

            DisignUserControl.ApplyDisign(this);
        }

        private void AdminKlassUC_Load(object sender, EventArgs e)
        {
            InfoClassifPanel.Controls.Clear();
            InfoClassifPanel.Controls.Add(label1);
            InfoClassifPanel.Controls.Add(label13);
            InfoClassifPanel.Controls.Add(label2);

            List<string> apteks = SQLClass.MySelect("SELECT id, name FROM level1");
            NameAptekaCB.Items.Clear();
            for (int i = 0; i < apteks.Count; i += 2)
            {
                NameAptekaCB.Items.Add(apteks[i] + ". " + apteks[i + 1]);
            }

            List<string> Classif = SQLClass.MySelect("SELECT id, name, id_apteka FROM level2");
            int y = 50;
            for (int i = 0; i < Classif.Count; i += 3)
            {
                Label lbl = new Label();
                lbl.Location = new Point(20, y);
                lbl.Size = new Size(500, 30);
                lbl.Font = new Font("Arial Narrow", 13);
                lbl.Tag = Classif[i];
                lbl.Text = Classif[i + 1];
                InfoClassifPanel.Controls.Add(lbl);

                List<string> aptek = SQLClass.MySelect("SELECT name FROM level1 WHERE id = '" + Classif[i+2] + "'");

                Label lbl1 = new Label();
                lbl1.Location = new Point(520, y);
                lbl1.Size = new Size(180, 30);
                lbl1.Font = new Font("Arial Narrow", 13);
                lbl1.Text = aptek[0];
                InfoClassifPanel.Controls.Add(lbl1);

                Button btn = new Button();
                btn.Location = new Point(700, y);
                btn.Size = new Size(100, 30);
                btn.Font = new Font("Arial Narrow", 12);
                btn.Click += new EventHandler(DeleteClassifClick);
                btn.Text = "Удалить";
                InfoClassifPanel.Controls.Add(btn);

                y += 35;
            }
        }

        private void DeleteClassifClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int y = btn.Location.Y;

            foreach (Control control in InfoClassifPanel.Controls)
            {
                if (control.Location == new Point(20, y))
                {
                    SQLClass.MyUpDate("DELETE FROM level2 WHERE id = '" + control.Tag + "'");
                    SQLClass.MyUpDate("DELETE FROM level3 WHERE id_class = '" + control.Tag + "'");
                    MessageBox.Show("Удаление успешно");
                    AdminKlassUC_Load(sender, e);
                }
            }
        }


        private void AddClassifButton_Click(object sender, EventArgs e)
        {
            string id_apteka = "";
            string[] text = NameAptekaCB.Text.Split(new string[] { ". " }, StringSplitOptions.None);
            id_apteka = text[0];


            if (NameClassifCB.Text != "" && NameAptekaCB.Text != "")
            {
                SQLClass.MyUpDate("INSERT INTO level2 (name, id_apteka, pic) VALUES ('" + NameClassifCB.Text + "','" + NameAptekaCB.Text + "', '" + adress + "')");
                MessageBox.Show("Сохранено");
                AdminKlassUC_Load(sender, e);
                NameAptekaCB.Text = "";
                NameClassifCB.Text = "";
                ClassifPictureBox.Image = null;
            }
            else
            {
                MessageBox.Show("Заполните обязательные поля");
            }

        }

        string adress;
        private void ClassifPictureBox_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                adress = openFileDialog1.FileName;
                ClassifPictureBox.Load(adress);
                adress = Path.GetFileName(adress);
            }

        }
    }
}

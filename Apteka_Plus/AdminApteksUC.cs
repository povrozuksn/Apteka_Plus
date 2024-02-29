using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Apteka_Plus
{
    public partial class AdminApteksUC : UserControl
    {
        public AdminApteksUC()
        {
            InitializeComponent();
            DisignUserControl.ApplyDisign(this);
        }

        private void AdminApteksUC_Load(object sender, EventArgs e)
        {
            InfoApteksPanel.Controls.Clear();
            InfoApteksPanel.Controls.Add(label1);
            InfoApteksPanel.Controls.Add(label13);
            InfoApteksPanel.Controls.Add(label2);

            List<string> apteks = SQLClass.MySelect("SELECT id, name, adress, pic FROM level1");
            int y = 50;
            for (int i = 0; i < apteks.Count; i += 4)
            {
                Label lbl = new Label();
                lbl.Location = new Point(20, y);
                lbl.Size = new Size(220, 30);
                lbl.Font = new Font("Arial Narrow", 13);
                lbl.Tag = apteks[i];
                lbl.Text = apteks[i + 1];
                InfoApteksPanel.Controls.Add(lbl);

                Label lbl1 = new Label();
                lbl1.Location = new Point(250, y);
                lbl1.Size = new Size(300, 30);
                lbl1.Font = new Font("Arial Narrow", 13);
                lbl1.Text = apteks[i + 2];
                InfoApteksPanel.Controls.Add(lbl1);

                Button btn = new Button();
                btn.Location = new Point(600, y);
                btn.Size = new Size(100, 30);
                btn.Font = new Font("Arial Narrow", 12);
                btn.Click += new EventHandler(DeleteApteksClick);
                btn.Text = "Удалить";
                InfoApteksPanel.Controls.Add(btn);

                y += 35;
            }
        }


        private void DeleteApteksClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int y = btn.Location.Y;

            foreach (Control control in InfoApteksPanel.Controls)
            {
                if (control.Location == new Point(20, y))
                {
                    SQLClass.MyUpDate("DELETE FROM level1 WHERE id = '" + control.Tag + "'");
                    SQLClass.MyUpDate("DELETE FROM level2 WHERE id_apteka = '" + control.Tag + "'");
                    SQLClass.MyUpDate("DELETE FROM level3 WHERE id_apteka = '" + control.Tag + "'");
                    MessageBox.Show("Удаление успешно");
                    AdminApteksUC_Load(sender, e);
                }
            }
        }

        string adress;
        private void AptekaPictureBox_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                adress = openFileDialog1.FileName;
                AptekaPictureBox.Load(adress);
                adress = Path.GetFileName(adress);
            }

        }

        private void AddAptekaButton_Click(object sender, EventArgs e)
        {

            if (NameAptekaTB.Text != "" && AdressAptekaTB.Text != "")
            {
                SQLClass.MyUpDate("INSERT INTO level1 (name, adress, pic) VALUES ('" + NameAptekaTB.Text + "','" + AdressAptekaTB.Text + "', '" + adress + "')");
                MessageBox.Show("Сохранено");
                AdminApteksUC_Load(sender, e);
                NameAptekaTB.Text = "";
                AdressAptekaTB.Text = "";
                AptekaPictureBox.Image = null;
            }
            else
            {
                MessageBox.Show("Заполните обязательные поля");
            }
        }
    }
}

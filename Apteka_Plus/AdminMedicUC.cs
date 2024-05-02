using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace Apteka_Plus
{
    public partial class AdminMedicUC : UserControl
    {

        public AdminMedicUC()
        {
            InitializeComponent();

            DisignUserControl.ApplyDisign(this);
        }



        private void AddMedicButton_Click(object sender, EventArgs e)
        {
            string id_classif = "";
            string id_apteka = "";
            string[] text = NameClassifCB.Text.Split(new string[] { ". " }, StringSplitOptions.None);
            id_classif = text[0];
            id_apteka = text[2];


            if (NameMedicTB.Text != "" && NameClassifCB.Text != "")
            {
                SQLClass.MyUpDate("INSERT INTO level3 (name, id_apteka, id_class, pic) VALUES ('" + NameMedicTB.Text + "','" + id_apteka + "','" + NameClassifCB.Text + "', '" + adress + "')");
                MessageBox.Show("Сохранено");
                AdminMedicUC_Load(sender, e);
                NameMedicTB.Text = "";
                NameClassifCB.Text = "";
                MedicPictureBox.Image = null;
            }
            else
            {
                MessageBox.Show("Заполните обязательные поля");
            }

        }

        string adress;
        private void MedicPictureBox_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                adress = openFileDialog1.FileName;
                MedicPictureBox.Load(adress);
                adress = Path.GetFileName(adress);
            }

        }

        private void AdminMedicUC_Load(object sender, EventArgs e)
        {
            InfoMedicPanel.Controls.Clear();
            InfoMedicPanel.Controls.Add(label1);
            label1.Visible = true;
            InfoMedicPanel.Controls.Add(label3);
            InfoMedicPanel.Controls.Add(label13);
            InfoMedicPanel.Controls.Add(label2);
            InfoMedicPanel.Controls.Add(label7);

            List<string> classif = SQLClass.MySelect("SELECT id, name, id_apteka FROM level2");

            NameClassifCB.Items.Clear();
            for (int i = 0; i < classif.Count; i += 3)
            {
                List<string> apteks = SQLClass.MySelect("SELECT id, name FROM level1 WHERE id = '" + classif[i + 2] + "' ");
                NameClassifCB.Items.Add(classif[i] + ". " + classif[i + 1] + ". " + apteks[0] + ". " + apteks[1]);
            }

            List<string> Medic = SQLClass.MySelect("SELECT id, name, id_apteka, id_class, price, link FROM level3");
            int y = 50;
            for (int i = 0; i < Medic.Count; i += 6)
            {
                Label lbl = new Label();
                lbl.Location = new Point(20, y);
                lbl.Size = new Size(200, 30);
                lbl.Font = new Font("Arial Narrow", 13);
                lbl.Tag = Medic[i];
                lbl.Text = Medic[i + 1];
                InfoMedicPanel.Controls.Add(lbl);

                List<string> classi = SQLClass.MySelect("SELECT name FROM level2 WHERE id = '" + Medic[i + 3] + "'");
                Label lbl1 = new Label();
                lbl1.Location = new Point(280, y);
                lbl1.Size = new Size(300, 30);
                lbl1.Font = new Font("Arial Narrow", 13);
                lbl1.Text = classi[0];
                InfoMedicPanel.Controls.Add(lbl1);

                List<string> aptek = SQLClass.MySelect("SELECT name FROM level1 WHERE id = '" + Medic[i + 2] + "'");
                Label lbl2 = new Label();
                lbl2.Location = new Point(600, y);
                lbl2.Size = new Size(150, 30);
                lbl2.Font = new Font("Arial Narrow", 13);
                lbl2.Text = aptek[0];
                InfoMedicPanel.Controls.Add(lbl2);

                Label lbl_price = new Label();
                lbl_price.Location = new Point(750, y);
                lbl_price.Size = new Size(100, 30);
                lbl_price.Font = new Font("Arial Narrow", 13);
                lbl_price.Text = Medic[i + 4];
                InfoMedicPanel.Controls.Add(lbl_price);

                Button btn_price = new Button();
                btn_price.Location = new Point(850, y);
                btn_price.Size = new Size(100, 30);
                btn_price.Font = new Font("Arial Narrow", 12);
                btn_price.Click += new EventHandler(UpdatePrice);
                btn_price.Text = "Обновить цену";
                btn_price.Tag = Medic[i + 5];
                btn_price.AccessibleName = Medic[i];
                InfoMedicPanel.Controls.Add(btn_price);

                Button btn = new Button();
                btn.Location = new Point(950, y);
                btn.Size = new Size(100, 30);
                btn.Font = new Font("Arial Narrow", 12);
                btn.Click += new EventHandler(DeleteMedicClick);
                btn.Text = "Удалить";
                InfoMedicPanel.Controls.Add(btn);

                y += 35;
            }
        }

        private void DeleteMedicClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int y = btn.Location.Y;

            foreach (Control control in InfoMedicPanel.Controls)
            {
                if (control.Location == new Point(20, y))
                {
                    SQLClass.MyUpDate("DELETE FROM level3 WHERE id = '" + control.Tag + "'");
                    MessageBox.Show("Удаление успешно");
                }
            }
            AdminMedicUC_Load(sender, e);
        }

        public static float MedPrice(string link)
        {
            if(link != "")
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(link);

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream stream = response.GetResponseStream();
                StreamReader sr = new StreamReader(stream);
                string sReadData = sr.ReadToEnd();
                response.Close();

                string[] lines = sReadData.Split(new char[] { '\n' });
                int pos = lines[4].IndexOf("moneyprice__roubles");
                string price = lines[4].Substring(pos + 21, 3);
                return (float)Convert.ToDouble(price);
            }
            else
            {
                return 0;
            }
            
        }

        private void UpdatePrice(object sender, EventArgs e)
        {
            float price = 0;
            Button btn = (Button)sender;
            price = MedPrice(btn.Tag.ToString());
            SQLClass.MyUpDate("UPDATE level3 SET price = '" + price + "' WHERE id = '" + btn.AccessibleName + "' ");
            AdminMedicUC_Load(sender, e);
        }

    }
}

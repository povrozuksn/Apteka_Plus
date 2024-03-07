﻿using System;
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
    public partial class AdminMedicUC : UserControl
    {
        public AdminMedicUC()
        {
            InitializeComponent();

            DisignUserControl.ApplyDisign(this);
        }



        private void AddMedicButton_Click(object sender, EventArgs e)
        {

        }

        private void AdminMedicUC_Load(object sender, EventArgs e)
        {
            InfoMedicPanel.Controls.Clear();
            InfoMedicPanel.Controls.Add(label1);
            InfoMedicPanel.Controls.Add(label3);
            InfoMedicPanel.Controls.Add(label13);
            InfoMedicPanel.Controls.Add(label2);

            
            List<string> classif = SQLClass.MySelect("SELECT id, name, id_apteka FROM level2");

            NameClassifCB.Items.Clear();
            for (int i = 0; i < classif.Count; i += 3)
            {
                List<string> apteks = SQLClass.MySelect("SELECT id, name FROM level1 WHERE id = '" + classif[i + 2] + "' ");
                NameClassifCB.Items.Add(classif[i] + ". " + classif[i + 1] + ". " + apteks[1]);
            }

            List<string> Medic = SQLClass.MySelect("SELECT id, name, id_apteka, id_class FROM level3");
            int y = 50;
            for (int i = 0; i < Medic.Count; i += 4)
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

                Button btn = new Button();
                btn.Location = new Point(750, y);
                btn.Size = new Size(100, 30);
                btn.Font = new Font("Arial Narrow", 12);
                //btn.Click += new EventHandler(DeleteMedicClick);
                btn.Text = "Удалить";
                InfoMedicPanel.Controls.Add(btn);

                y += 35;
            }
        }
    }
}

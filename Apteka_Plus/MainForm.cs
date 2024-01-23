using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Apteka_Plus
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            Text = "Аптека Плюс";
            
            MainUserControl mainUC = new MainUserControl();
            mainUC.Dock = DockStyle.Fill;
            InfoPanel.Controls.Clear();
            InfoPanel.Controls.Add(mainUC);

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if(e.Node.Level == 0 && e.Node.Text == "Аптеки")
            {
                MainUserControl mainUC = new MainUserControl();
                mainUC.Dock = DockStyle.Fill;
                InfoPanel.Controls.Clear();
                InfoPanel.Controls.Add(mainUC);
            }
            
            else if(e.Node.Level == 1 && e.Node.Parent.Text == "Аптеки")
            {
                AptekaUserControl aptekaUC = new AptekaUserControl(e.Node.Tag.ToString());
                aptekaUC.Dock = DockStyle.Fill;
                InfoPanel.Controls.Clear();
                InfoPanel.Controls.Add(aptekaUC);
            }

            else if (e.Node.Level == 2 && e.Node.Parent.Parent.Text == "Аптеки")
            {
                MedicomentUserControl medicokaUC = new MedicomentUserControl(e.Node.Tag.ToString());
                medicokaUC.Dock = DockStyle.Fill;
                InfoPanel.Controls.Clear();
                InfoPanel.Controls.Add(medicokaUC);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            string id_apteka;
            string id_classif;

            List<string> apteks = SQLClass.MySelect("SELECT id, name FROM level1");

            for(int i = 0; i < apteks.Count; i += 2)
            {
                id_apteka = apteks[i];
                TreeNode node0 = new TreeNode(apteks[i+1]);
                node0.Tag = apteks[i];
                treeView1.Nodes[0].Nodes.Add(node0);

                List<string> classif = SQLClass.MySelect("SELECT id, name FROM level2 WHERE id_apteka = '" + id_apteka + "'");

                for (int j = 0; j < classif.Count; j += 2)
                {
                    id_classif = classif[j];
                    TreeNode node1 = new TreeNode(classif[j + 1]);
                    node1.Tag = classif[j];
                    node0.Nodes.Add(node1);

                    List<string> medicoments = SQLClass.MySelect("SELECT id, name FROM level3 WHERE id_apteka = '" + id_apteka + "' AND id_class = '" + id_classif + "'");

                    for(int g = 0; g < medicoments.Count; g += 2)
                    {
                        TreeNode node2 = new TreeNode(medicoments[g + 1]);
                        node2.Tag = medicoments[g];
                        node1.Nodes.Add(node2);
                    }
                }

            }
        }
    }
}

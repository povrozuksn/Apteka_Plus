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
            List<string> apteks = SQLClass.MySelect("SELECT id, name FROM level1");
        }
    }
}

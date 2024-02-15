using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Apteka_Plus
{
    public partial class MainForm : Form
    {
        public static int isAdmin;
        public static string Login = "";
        public static string NameFamily = "";

        public MainForm()
        {
            InitializeComponent();

            Text = "Аптека Плюс";
            
            MainUserControl mainUC = new MainUserControl();
            mainUC.Dock = DockStyle.Fill;
            InfoPanel.Controls.Clear();
            InfoPanel.Controls.Add(mainUC);

            AdminFormButton.Visible = false;
            DisignButton.Visible = false;

            DisignUserControl.ReadDefaultDisign();
            DisignUserControl.ApplyDisign(this);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            string id_apteka;
            string id_classif;

            List<string> apteks = SQLClass.MySelect("SELECT id, name FROM level1");

            for (int i = 0; i < apteks.Count; i += 2)
            {
                id_apteka = apteks[i];
                TreeNode node0 = new TreeNode(apteks[i + 1]);
                node0.Tag = apteks[i];
                treeView1.Nodes[0].Nodes.Add(node0);

                List<string> classif = SQLClass.MySelect("SELECT id, name FROM level2 WHERE id_apteka = '" + id_apteka + "'");

                for (int j = 0; j < classif.Count; j += 2)
                {
                    id_classif = classif[j];
                    TreeNode node1 = new TreeNode(classif[j + 1]);
                    node1.Tag = classif[j];
                    node0.Nodes.Add(node1);

                    List<string> medicoments = SQLClass.MySelect("SELECT id, name FROM level3 WHERE id_class = '" + id_classif + "'");

                    for (int g = 0; g < medicoments.Count; g += 2)
                    {
                        TreeNode node2 = new TreeNode(medicoments[g + 1]);
                        node2.Tag = medicoments[g];
                        node1.Nodes.Add(node2);
                    }
                }

            }

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
                ClassificatorUserControl classUC = new ClassificatorUserControl(e.Node.Tag.ToString());
                classUC.Dock = DockStyle.Fill;
                InfoPanel.Controls.Clear();
                InfoPanel.Controls.Add(classUC);
            }

            else if (e.Node.Level == 3 && e.Node.Parent.Parent.Parent.Text == "Аптеки")
            {
                MedicomentUserControl medicokaUC = new MedicomentUserControl(e.Node.Tag.ToString());
                medicokaUC.Dock = DockStyle.Fill;
                InfoPanel.Controls.Clear();
                InfoPanel.Controls.Add(medicokaUC);
            }

            else if (e.Node.Level == 0 && e.Node.Text == "Админка")
            {
                AdminUserControl adminUC = new AdminUserControl();
                adminUC.Dock = DockStyle.Fill;
                InfoPanel.Controls.Clear();
                InfoPanel.Controls.Add(adminUC);
            }

            else if (e.Node.Level == 1 && e.Node.Parent.Text == "Админка" && e.Node.Text == "Управление аптеками")
            {
                AdminApteksUC adminapteksUC = new AdminApteksUC();
                adminapteksUC.Dock = DockStyle.Fill;
                InfoPanel.Controls.Clear();
                InfoPanel.Controls.Add(adminapteksUC);
            }

            else if (e.Node.Level == 1 && e.Node.Parent.Text == "Админка" && e.Node.Text == "Управление классификатором")
            {
                AdminKlassUC adminklassUC = new AdminKlassUC();
                adminklassUC.Dock = DockStyle.Fill;
                InfoPanel.Controls.Clear();
                InfoPanel.Controls.Add(adminklassUC);
            }

            else if (e.Node.Level == 1 && e.Node.Parent.Text == "Админка" && e.Node.Text == "Управление медикоментами")
            {
                AdminMedicUC adminmedicUC = new AdminMedicUC();
                adminmedicUC.Dock = DockStyle.Fill;
                InfoPanel.Controls.Clear();
                InfoPanel.Controls.Add(adminmedicUC);
            }

            else if (e.Node.Level == 1 && e.Node.Parent.Text == "Админка" && e.Node.Text == "Управление пользователями")
            {
                AdminUsersUC adminusersUC = new AdminUsersUC();
                adminusersUC.Dock = DockStyle.Fill;
                InfoPanel.Controls.Clear();
                InfoPanel.Controls.Add(adminusersUC);
            }

            else if (e.Node.Level == 0 && e.Node.Text == "Дизайн")
            {
                DisignUserControl disignUC = new DisignUserControl();
                disignUC.Dock = DockStyle.Fill;
                InfoPanel.Controls.Clear();
                InfoPanel.Controls.Add(disignUC);
            }
        }


        private void AuthButton_Click(object sender, EventArgs e)
        {
            List<string> user_date = SQLClass.MySelect("SELECT login, name, familiya, admin FROM users WHERE login = '" + LoginTextBox.Text + "' AND pass = '" + PassTextBox.Text + "'");

            if (AuthButton.Text == "Выйти")
            {
                Login = "";
                AuthPanel.Controls.Clear();
                AuthPanel.Controls.Add(LoginLabel);
                LoginTextBox.Text = "";
                AuthPanel.Controls.Add(LoginTextBox);
                AuthPanel.Controls.Add(PassLabel);
                PassTextBox.Text = "";
                AuthPanel.Controls.Add(PassTextBox);
                AuthButton.Text = "Войти";
                AuthPanel.Controls.Add(AuthButton);
                AuthPanel.Controls.Add(RegButton);
                HelloLabel.Visible = false;
                HelloLabel.Text = "";
                isAdmin = 0;

            }
            else
            {
                if (user_date.Count > 0)
                {
                    isAdmin = Convert.ToInt32(user_date[3]);
                    Login = user_date[0];
                    NameFamily = user_date[1] + " " + user_date[2];
                    AuthPanel.Controls.Clear();
                    AuthButton.Text = "Выйти";
                    AuthPanel.Controls.Add(AuthButton);
                    AuthPanel.Controls.Add(HelloLabel);
                    HelloLabel.Visible = true;
                    HelloLabel.Text = "Приветствуем Вас, " + NameFamily;
                    AdminFormButton.Visible = Convert.ToBoolean(isAdmin);
                    AuthPanel.Controls.Add(AdminFormButton);
                    DisignButton.Visible = Convert.ToBoolean(isAdmin);
                    AuthPanel.Controls.Add(DisignButton);
                }
                else
                {
                    var result = MessageBox.Show("Вы указали неверный логин/пароль", "Зарегистрироваться", MessageBoxButtons.YesNo);
                    LoginTextBox.Text = "";
                    PassTextBox.Text = "";
                    if (result == DialogResult.Yes)
                    {
                        RegForm reg = new RegForm();
                        reg.ShowDialog();
                    }
                }

            }
        }

        private void RegButton_Click(object sender, EventArgs e)
        {
            RegForm reg = new RegForm();
            reg.ShowDialog();
        }

        private void AdminFormButton_Click(object sender, EventArgs e)
        {
            AdminUserControl adminUC = new AdminUserControl();
            adminUC.Dock = DockStyle.Fill;
            InfoPanel.Controls.Clear();
            InfoPanel.Controls.Add(adminUC);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DisignUserControl.ApplyDisign(this);

            if (Convert.ToBoolean(isAdmin) && treeView1.Nodes.Count == 1)
            {
                TreeNode node = new TreeNode("Админка");
                treeView1.Nodes.Add(node);

                TreeNode node1 = new TreeNode("Управление аптеками");
                node.Nodes.Add(node1);

                TreeNode node2 = new TreeNode("Управление классификатором");
                node.Nodes.Add(node2);

                TreeNode node3 = new TreeNode("Управление медикоментами");
                node.Nodes.Add(node3);

                TreeNode node4 = new TreeNode("Управление пользователями");
                node.Nodes.Add(node4);

                TreeNode nodeDisign = new TreeNode("Дизайн");
                treeView1.Nodes.Add(nodeDisign);
            }
            else if(!Convert.ToBoolean(isAdmin) && treeView1.Nodes.Count > 1)
            {
                treeView1.Nodes.RemoveAt(1);
            }
        }

        private void DisignButton_Click(object sender, EventArgs e)
        {
            DisignUserControl disignUC = new DisignUserControl();
            disignUC.Dock = DockStyle.Fill;
            InfoPanel.Controls.Clear();
            InfoPanel.Controls.Add(disignUC);
        }
    }
}

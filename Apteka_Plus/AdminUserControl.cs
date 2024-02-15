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
    public partial class AdminUserControl : UserControl
    {
        public AdminUserControl()
        {
            InitializeComponent();

            DisignUserControl.ApplyDisign(this);
        }

        private void AdminApteksBTN_Click(object sender, EventArgs e)
        {
            AdminApteksUC adminapteksUC = new AdminApteksUC();
            adminapteksUC.Dock = DockStyle.Fill;
            Controls.Clear();
            Controls.Add(adminapteksUC);
        }

        private void AdminKlassBTN_Click(object sender, EventArgs e)
        {
            AdminKlassUC adminklassUC = new AdminKlassUC();
            adminklassUC.Dock = DockStyle.Fill;
            Controls.Clear();
            Controls.Add(adminklassUC);
        }

        private void AdminMedicBTN_Click(object sender, EventArgs e)
        {
            AdminMedicUC adminmedicUC = new AdminMedicUC();
            adminmedicUC.Dock = DockStyle.Fill;
            Controls.Clear();
            Controls.Add(adminmedicUC);
        }

        private void AdminUseraBTN_Click(object sender, EventArgs e)
        {
            AdminUsersUC adminusersUC = new AdminUsersUC();
            adminusersUC.Dock = DockStyle.Fill;
            Controls.Clear();
            Controls.Add(adminusersUC);
        }
    }
}

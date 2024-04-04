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
    public partial class EditPanelForm : Form
    {
        public Control ctrl;
        public EditPanelForm(Control _ctrl)
        {
            InitializeComponent();

            ctrl = _ctrl;
            Text = "Изменение параметров панели " + ctrl.Name;
            ctrl.Height = _ctrl.Height;
            HeightTB.Text = ctrl.Height.ToString();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

            SQLClass.MyUpDate("DELETE FROM paneldisign WHERE type = '" + ctrl.GetType() + "' AND '" + ctrl.Name + "' AND param = 'PANEL_HEIGHT'");

            SQLClass.MyUpDate("INSERT INTO paneldisign (type, name, param, value) VALUE ('" + ctrl.GetType() + "', '" + ctrl.Name + "', 'PANEL_HEIGHT', '" + HeightTB.Text + "')");

        }
    }
}

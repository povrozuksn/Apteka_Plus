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

            NameLabel.Text = classific[1];

            try
            {
                pictureBox1.Load("../../Pictures/" + classific[2]);
            }
            catch (Exception) { }
        }
    }
}

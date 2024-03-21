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
    public partial class UniqueDiesignForm : Form
    {
        Button btn;
        public UniqueDiesignForm(Button _btn)
        {
            InitializeComponent();

            btn = _btn;
            SamplBTN.Text = btn.Text;
            SamplBTN.Font = btn.Font;
            SamplBTN.ForeColor = btn.ForeColor;
            SamplBTN.BackColor = btn.BackColor;
            SamplBTN.Size = btn.Size;
        }

        private void FontBTN_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = SamplBTN.Font;
            fontDialog1.Color = SamplBTN.ForeColor;

            if(fontDialog1.ShowDialog() == DialogResult.OK)
            {
                SamplBTN.Font = fontDialog1.Font;
                SamplBTN.ForeColor = fontDialog1.Color;


                SQLClass.MyUpDate("DELETE FROM uniquedisign WHERE type = '" + SamplBTN.GetType() + "' AND name = '" + btn.Name + "' AND form = '" + btn.FindForm().Name + "' AND parameter = 'FONT'");
                SQLClass.MyUpDate("DELETE FROM uniquedisign WHERE type = '" + SamplBTN.GetType() + "' AND name = '" + btn.Name + "' AND form = '" + btn.FindForm().Name + "' AND parameter = 'FONT_COLOR'");

                SQLClass.MyUpDate("INSERT INTO uniquedisign (type, name, form, parameter, value) VALUE ('" + SamplBTN.GetType() + "', '" + btn.Name + "', '" + btn.FindForm().Name + "', 'FONT', '" + SamplBTN.Font.Name + ";" + SamplBTN.Font.Size.ToString() + "')");
                SQLClass.MyUpDate("INSERT INTO uniquedisign (type, name, form, parameter, value) VALUE ('" + SamplBTN.GetType() + "', '" + btn.Name + "', '" + btn.FindForm().Name + "', 'FONT_COLOR', '" + SamplBTN.ForeColor.ToArgb() + "')");

            }
        }
    }
}

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
    public partial class DisignUserControl : UserControl
    {
        #region Параметры НАДПИСИ
        public static Font LABEL_FONT;
        public static Color LABEL_COLOR;
        #endregion

        public DisignUserControl()
        {
            InitializeComponent();
            DisignUserControl.ApplyDisign(this);
        }

        private void EditLabelBTN_Click(object sender, EventArgs e)
        {
            fontDialog1.Font  = LABEL_FONT;
            fontDialog1.Color  = LABEL_COLOR;

            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                LABEL_FONT = fontDialog1.Font;
                LABEL_COLOR = fontDialog1.Color;

                SampleLabel.Font = LABEL_FONT;
                SampleLabel.ForeColor = LABEL_COLOR;

                SQLClass.MyUpDate("DELETE FROM defaultdisign WHERE type = '" + SampleLabel.GetType() + "' AND parametr = 'FONT'");
                SQLClass.MyUpDate("DELETE FROM defaultdisign WHERE type = '" + SampleLabel.GetType() + "' AND parametr = 'FONT_COLOR'");

                SQLClass.MyUpDate("INSERT INTO defaultdisign (type, parametr, value) VALUE ('" + SampleLabel.GetType() + "', 'FONT', '" + LABEL_FONT.Name + ";" + LABEL_FONT.Size.ToString() + "')");
                SQLClass.MyUpDate("INSERT INTO defaultdisign (type, parametr, value) VALUE ('" + SampleLabel.GetType() + "', 'FONT_COLOR', '" + LABEL_COLOR.ToArgb() + "')");
            }
        }

        public static void ReadDefaultDisign()
        {
            //Чтение параметров НАДПИСИ
            try
            {
                string font = SQLClass.MySelect("SELECT value FROM defaultdisign WHERE type = 'System.Windows.Forms.Label' AND parametr = 'FONT'")[0];
                string[] parts = font.Split(new char[] { ';' });
                LABEL_FONT = new Font(new FontFamily(parts[0]), (float)Convert.ToDouble(parts[1]));

                string color = SQLClass.MySelect("SELECT value FROM defaultdisign WHERE type = 'System.Windows.Forms.Label' AND parametr = 'FONT_COLOR'")[0];
                LABEL_COLOR = Color.FromArgb(Convert.ToInt32(color));
            }
            catch (Exception) { }
        }

        public static void ApplyDisign(Control Form)
        {
            foreach (Control ctrl in Form.Controls)
            {
                if(ctrl is Label)
                {
                    ctrl.Font = LABEL_FONT;
                    ctrl.ForeColor = LABEL_COLOR;
                }
                else
                {
                    ApplyDisign(ctrl);
                }
            }
        }
    }
}

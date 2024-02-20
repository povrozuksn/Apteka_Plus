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

        #region Параметры ПАНЕЛИ
        public static Color PANEL_COLOR;
        #endregion

        #region Параметры ТЕКСТБОКСА
        public static Font TEXTBOX_FONT;
        public static Color TEXTBOX_FORECOLOR;
        public static Color TEXTBOX_BACKCOLOR;
        #endregion



        public DisignUserControl()
        {
            InitializeComponent();
            DisignUserControl.ApplyDisign(this);
        }

        #region Выбор и сохранение параметров НАДПИСИ
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
        #endregion

        public static void ReadDefaultDisign()
        {
            #region Чтение параметров НАДПИСИ
            try
            {
                string font = SQLClass.MySelect("SELECT value FROM defaultdisign WHERE type = 'System.Windows.Forms.Label' AND parametr = 'FONT'")[0];
                string[] parts = font.Split(new char[] { ';' });
                LABEL_FONT = new Font(new FontFamily(parts[0]), (float)Convert.ToDouble(parts[1]));

                string color = SQLClass.MySelect("SELECT value FROM defaultdisign WHERE type = 'System.Windows.Forms.Label' AND parametr = 'FONT_COLOR'")[0];
                LABEL_COLOR = Color.FromArgb(Convert.ToInt32(color));
            }
            catch (Exception) { }
            #endregion

            #region Чтение параметров ПАНЕЛИ
            try
            {
                string color = SQLClass.MySelect("SELECT value FROM defaultdisign WHERE type = 'System.Windows.Forms.Panel' AND parametr = 'PANEL_COLOR'")[0];
                PANEL_COLOR = Color.FromArgb(Convert.ToInt32(color));
            }
            catch (Exception) { }
            #endregion
        }

        public static void ApplyDisign(Control Form)
        {
            foreach (Control ctrl in Form.Controls)
            {
                #region Примение параметров НАДПИСИ
                if (ctrl is Label)
                {
                    ctrl.Font = LABEL_FONT;
                    ctrl.ForeColor = LABEL_COLOR;
                }
                else
                {
                    ApplyDisign(ctrl);
                }
                #endregion

                #region Примение параметров ПАНЕЛИ
                if (ctrl is Panel)
                {
                    ctrl.BackColor = PANEL_COLOR;
                }
                else
                {
                    ApplyDisign(ctrl);
                }
                #endregion
            }
        }


        #region Выбор и сохранение параметров ПАНЕЛИ
        private void EditPanelBTN_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = PANEL_COLOR;

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                PANEL_COLOR = colorDialog1.Color;

                SamplePanel.BackColor = PANEL_COLOR;


                SQLClass.MyUpDate("DELETE FROM defaultdisign WHERE type = '" + SamplePanel.GetType() + "' AND parametr = 'PANEL_COLOR'");

                SQLClass.MyUpDate("INSERT INTO defaultdisign (type, parametr, value) VALUE ('" + SamplePanel.GetType() + "', 'PANEL_COLOR', '" + PANEL_COLOR.ToArgb() + "')");
            }
        }
        #endregion

        private void EditTextBoxBTN1_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = TEXTBOX_FONT;
            fontDialog1.Color = TEXTBOX_FORECOLOR;

            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                TEXTBOX_FONT = fontDialog1.Font;
                TEXTBOX_FORECOLOR = fontDialog1.Color;

                SamplTextBox.Font = TEXTBOX_FONT;
                SamplTextBox.ForeColor = TEXTBOX_FORECOLOR;
            }

        }

        private void EditTextBoxBTN2_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = TEXTBOX_BACKCOLOR;

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                TEXTBOX_BACKCOLOR = colorDialog1.Color;

                SamplTextBox.BackColor = TEXTBOX_BACKCOLOR;
            }
        }
    }
}

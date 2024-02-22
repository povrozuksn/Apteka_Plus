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

        #region Параметры КНОПКИ
        public static Font BUTTON_FONT;
        public static Color BUTTON_FORECOLOR;
        public static Color BUTTON_BACKCOLOR;
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

            #region Чтение параметров ТЕКСТБОКСА
            try
            {
                string font = SQLClass.MySelect("SELECT value FROM defaultdisign WHERE type = 'System.Windows.Forms.TextBox' AND parametr = 'FONT'")[0];
                string[] parts = font.Split(new char[] { ';' });
                TEXTBOX_FONT = new Font(new FontFamily(parts[0]), (float)Convert.ToDouble(parts[1]));

                string color = SQLClass.MySelect("SELECT value FROM defaultdisign WHERE type = 'System.Windows.Forms.TextBox' AND parametr = 'FORECOLOR'")[0];
                TEXTBOX_FORECOLOR = Color.FromArgb(Convert.ToInt32(color));

                string bgcolor = SQLClass.MySelect("SELECT value FROM defaultdisign WHERE type = 'System.Windows.Forms.TextBox' AND parametr = 'BACKCOLOR'")[0];
                TEXTBOX_BACKCOLOR = Color.FromArgb(Convert.ToInt32(bgcolor));

            }
            catch (Exception) { }
            #endregion

            #region Чтение параметров КНОПКИ
            try
            {
                string font = SQLClass.MySelect("SELECT value FROM defaultdisign WHERE type = 'System.Windows.Forms.Button' AND parametr = 'FONT'")[0];
                string[] parts = font.Split(new char[] { ';' });
                BUTTON_FONT = new Font(new FontFamily(parts[0]), (float)Convert.ToDouble(parts[1]));

                string color = SQLClass.MySelect("SELECT value FROM defaultdisign WHERE type = 'System.Windows.Forms.Button' AND parametr = 'FORECOLOR'")[0];
                BUTTON_FORECOLOR = Color.FromArgb(Convert.ToInt32(color));

                string bgcolor = SQLClass.MySelect("SELECT value FROM defaultdisign WHERE type = 'System.Windows.Forms.Button' AND parametr = 'BACKCOLOR'")[0];
                BUTTON_BACKCOLOR = Color.FromArgb(Convert.ToInt32(bgcolor));

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

                #region Примение параметров ТЕКСТБОКСА
                if (ctrl is TextBox)
                {
                    ctrl.Font = TEXTBOX_FONT;
                    ctrl.ForeColor = TEXTBOX_FORECOLOR;
                    ctrl.BackColor = TEXTBOX_BACKCOLOR;
                }
                else
                {
                    ApplyDisign(ctrl);
                }
                #endregion

                #region Примение параметров КНОПКИ
                if (ctrl is Button)
                {
                    ctrl.Font = BUTTON_FONT;
                    ctrl.ForeColor = BUTTON_FORECOLOR;
                    ctrl.BackColor = BUTTON_BACKCOLOR;
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

        #region Выбор и сохранение параметров ТЕКСТБОКСА
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

                SQLClass.MyUpDate("DELETE FROM defaultdisign WHERE type = '" + SamplTextBox.GetType() + "' AND parametr = 'FONT'");
                SQLClass.MyUpDate("DELETE FROM defaultdisign WHERE type = '" + SamplTextBox.GetType() + "' AND parametr = 'FORECOLOR'");

                SQLClass.MyUpDate("INSERT INTO defaultdisign (type, parametr, value) VALUE ('" + SamplTextBox.GetType() + "', 'FONT', '" + TEXTBOX_FONT.Name + ";" + TEXTBOX_FONT.Size.ToString() + "')");
                SQLClass.MyUpDate("INSERT INTO defaultdisign (type, parametr, value) VALUE ('" + SamplTextBox.GetType() + "', 'FORECOLOR', '" + TEXTBOX_FORECOLOR.ToArgb() + "')");
            }

        }
        
        private void EditTextBoxBTN2_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = TEXTBOX_BACKCOLOR;

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                TEXTBOX_BACKCOLOR = colorDialog1.Color;

                SamplTextBox.BackColor = TEXTBOX_BACKCOLOR;


                SQLClass.MyUpDate("DELETE FROM defaultdisign WHERE type = '" + SamplTextBox.GetType() + "' AND parametr = 'BACKCOLOR'");

                SQLClass.MyUpDate("INSERT INTO defaultdisign (type, parametr, value) VALUE ('" + SamplTextBox.GetType() + "', 'BACKCOLOR', '" + TEXTBOX_BACKCOLOR.ToArgb() + "')");
            }
        }
        #endregion

        #region Выбор и сохранение параметров КНОПКИ
        private void EditButtonBTN1_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = BUTTON_FONT;
            fontDialog1.Color = BUTTON_FORECOLOR;

            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                BUTTON_FONT = fontDialog1.Font;
                BUTTON_FORECOLOR = fontDialog1.Color;

                SamplButton.Font = BUTTON_FONT;
                SamplButton.ForeColor = BUTTON_FORECOLOR;

                SQLClass.MyUpDate("DELETE FROM defaultdisign WHERE type = '" + SamplButton.GetType() + "' AND parametr = 'FONT'");
                SQLClass.MyUpDate("DELETE FROM defaultdisign WHERE type = '" + SamplButton.GetType() + "' AND parametr = 'FORECOLOR'");

                SQLClass.MyUpDate("INSERT INTO defaultdisign (type, parametr, value) VALUE ('" + SamplButton.GetType() + "', 'FONT', '" + BUTTON_FONT.Name + ";" + BUTTON_FONT.Size.ToString() + "')");
                SQLClass.MyUpDate("INSERT INTO defaultdisign (type, parametr, value) VALUE ('" + SamplButton.GetType() + "', 'FORECOLOR', '" + BUTTON_FORECOLOR.ToArgb() + "')");
            }

        }

        private void EditButtonBTN2_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = BUTTON_BACKCOLOR;

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                BUTTON_BACKCOLOR = colorDialog1.Color;

                SamplButton.BackColor = BUTTON_BACKCOLOR;


                SQLClass.MyUpDate("DELETE FROM defaultdisign WHERE type = '" + SamplButton.GetType() + "' AND parametr = 'BACKCOLOR'");

                SQLClass.MyUpDate("INSERT INTO defaultdisign (type, parametr, value) VALUE ('" + SamplButton.GetType() + "', 'BACKCOLOR', '" + BUTTON_BACKCOLOR.ToArgb() + "')");
            }
        }
        #endregion
    }
}

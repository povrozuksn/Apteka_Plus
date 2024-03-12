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
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();

            DisignUserControl.ApplyDisign(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (PasTextBox.Text == ConfirmTextBox.Text)
            {
                SQLClass.MyUpDate("INSERT INTO users (name, familiya, login, pass, admin) VALUES ('" + NameTextBox.Text + "', '" + FamilyTextBox.Text + "', '" + LoginTextBox.Text + "', '" + PasTextBox.Text + "', 0)");
                MessageBox.Show("Регистрация прошла успешно");
                Close();
            }
            else
            {
                MessageBox.Show("Пароли не совпадают");
            }
        }
    }
}

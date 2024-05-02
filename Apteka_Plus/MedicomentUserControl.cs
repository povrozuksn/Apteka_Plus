using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apteka_Plus
{
    public partial class MedicomentUserControl : UserControl
    {
        public MedicomentUserControl(string id)
        {
            InitializeComponent();

            DisignUserControl.ApplyDisign(this);

            List<string> medicoment = SQLClass.MySelect("SELECT id, name, pic, price FROM level3 WHERE id = '" + id + "'");

            NameLabel.Text = medicoment[1];
            PriceLabel.Text = medicoment[3];

            try
            {
                pictureBox1.Load("../../Pictures/" + medicoment[2]);
            }
            catch (Exception) { }
        }

    }
}

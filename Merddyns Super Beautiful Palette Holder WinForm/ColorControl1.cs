using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using System.Windows.Input;

namespace Merddyns_Super_Beautiful_Palette_Holder_WinForm
{
    public class ColorControl1 : UserControl
    {
        Color color;
        string name;
        Button button;
        Panel panel;
        TextBox textBox;
        public ColorControl1(Color _color, string _Name)
        {
            color = _color;
            name = _Name;
            button = new Button()
            {
                Text = string.Format("Buttonnn")

            };

            textBox = new TextBox()
            {
                Text = name
            };
            panel = new Panel()
            {
                BackColor = color
            };
            panel.Controls.Add(button);
            button.Click += new EventHandler(button1_Click);

        }
        

        public ColorControl1(int R, int G, int B, int A, string _Name)
        {
            color = Color.FromArgb(A, R, G, B);
            color = new Color();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox.Text = panel.BackColor.ToString();
        }

    }
}

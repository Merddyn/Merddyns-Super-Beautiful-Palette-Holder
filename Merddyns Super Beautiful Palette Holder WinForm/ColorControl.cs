using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Merddyns_Super_Beautiful_Palette_Holder_WinForm
{
    public partial class ColorControl : UserControl
    {
        Color color;
        string name;
        //Button button;
        //Panel panel;
        //TextBox textBox;
        public ColorControl()
        {
            BackColor = Color.Green;
            
            InitializeComponent();
        }

        public ColorControl (Color _color, string _name)
        {
            color = _color;
            this.BackColor = color;
            name = _name;

            InitializeComponent();
        }

        private void ColorControl_Load(object sender, EventArgs e)
        {
            OutputType.SelectedItem = "Hex";
            ColorName.Text = name;
        }

        private void ColorControl_Loaded(object sender, EventArgs e)
        {
            OutputType.SelectedIndex = 0;
            ColorName.Text = name;
        }

        private void ColorName_TextChanged(object sender, EventArgs e)
        {

        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            int R = BackColor.R;
            int G = BackColor.G;
            int B = BackColor.B;
            Clipboard.SetText(ColorRGBToText(R, G, B, (string)OutputType.SelectedItem));
            
            
        }

        private void ColorControl_DoubleClick(object sender, EventArgs e)
        {
            DialogResult result = colorDialog1.ShowDialog();
            // See if user pressed ok.
            if (result == DialogResult.OK)
            {
                // Set form background to the selected color.
                this.BackColor = colorDialog1.Color;
            }
        }

        private void OutputType_SelectedIndexChanged(object sender, EventArgs e)
        {
            int R = BackColor.R;
            int G = BackColor.G;
            int B = BackColor.B;
            txt_ColorValue.Text = ColorRGBToText(R, G, B, (string)OutputType.SelectedItem);
            
        }

        private void txt_ColorValue_KeyDown(object sender, KeyEventArgs e)
        {
            int R = BackColor.R;
            int G = BackColor.G;
            int B = BackColor.B;
        

            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if ((string)OutputType.SelectedItem == "RGB")
                    {

                        string[] ColorValues = txt_ColorValue.Text.Split(',');
                        R = Convert.ToInt32(ColorValues[0].Trim());
                        G = Convert.ToInt32(ColorValues[1].Trim());
                        B = Convert.ToInt32(ColorValues[2].Trim());
                        txt_ColorValue.Text = R + ", " + G + ", " + B;
                    }
                    else if ((string)OutputType.SelectedItem == "Hex")
                    {
                        string hexB = txt_ColorValue.Text.Substring(0, 2);
                        string hexG = txt_ColorValue.Text.Substring(2, 2);
                        string hexR = txt_ColorValue.Text.Substring(4, 2);

                        R = int.Parse(hexR, System.Globalization.NumberStyles.HexNumber);
                        G = int.Parse(hexG, System.Globalization.NumberStyles.HexNumber);
                        B = int.Parse(hexB, System.Globalization.NumberStyles.HexNumber);
                        txt_ColorValue.Text = hexB + hexG + hexR;
                    }
                    else if ((string)OutputType.SelectedItem == "#Hex")
                    {
                        string hexR = txt_ColorValue.Text.Substring(5, 2);
                        string hexG = txt_ColorValue.Text.Substring(3, 2);
                        string hexB = txt_ColorValue.Text.Substring(1, 2);

                        R = int.Parse(hexR, System.Globalization.NumberStyles.HexNumber);
                        G = int.Parse(hexG, System.Globalization.NumberStyles.HexNumber);
                        B = int.Parse(hexB, System.Globalization.NumberStyles.HexNumber);
                        txt_ColorValue.Text = "#" + hexB + hexG + hexR;
                    }
                    else if ((string)OutputType.SelectedItem == "Hex (RRGGBB)")
                    {
                        string hexR = txt_ColorValue.Text.Substring(0, 2);
                        string hexG = txt_ColorValue.Text.Substring(2, 2);
                        string hexB = txt_ColorValue.Text.Substring(4, 2);

                        R = int.Parse(hexR, System.Globalization.NumberStyles.HexNumber);
                        G = int.Parse(hexG, System.Globalization.NumberStyles.HexNumber);
                        B = int.Parse(hexB, System.Globalization.NumberStyles.HexNumber);
                        txt_ColorValue.Text = hexR + hexG + hexB;
                    }
                    else if ((string)OutputType.SelectedItem == "#Hex (RRGGBB)")
                    {
                        string hexR = txt_ColorValue.Text.Substring(1, 2);
                        string hexG = txt_ColorValue.Text.Substring(3, 2);
                        string hexB = txt_ColorValue.Text.Substring(5, 2);

                        R = int.Parse(hexR, System.Globalization.NumberStyles.HexNumber);
                        G = int.Parse(hexG, System.Globalization.NumberStyles.HexNumber);
                        B = int.Parse(hexB, System.Globalization.NumberStyles.HexNumber);
                        txt_ColorValue.Text = "#" + hexR + hexG + hexB;
                    }
                    else if ((string)OutputType.SelectedItem == "RGB(R,G,B)")
                    {
                        string RGBColor = txt_ColorValue.Text;
                        RGBColor = RGBColor.Remove(0, 6);
                        RGBColor = RGBColor.TrimEnd(')');
                        string[] ColorValues = RGBColor.Split(',');
                        R = Convert.ToInt32(ColorValues[0].Trim());
                        G = Convert.ToInt32(ColorValues[1].Trim());
                        B = Convert.ToInt32(ColorValues[2].Trim());
                        txt_ColorValue.Text = R + ", " + G + ", " + B;
                        txt_ColorValue.Text = "rgb: (" + R + ", " + G + ", " + B + ")";
                    }
                    else if ((string)OutputType.SelectedItem == "HSV")
                    {
                        Color TempColor = HSVtoRGB(txt_ColorValue.Text);
                        R = TempColor.R;
                        G = TempColor.G;
                        B = TempColor.B;
                        txt_ColorValue.Text = RGBtoHSV(R, G, B);
                    }
                        this.BackColor = Color.FromArgb(255, R, G, B);
                    CopyButton.Focus();
                }
                catch
                {
                    MessageBox.Show("An error occured while trying to change the color.");
                }
            }
            
        }

        public string RGBtoHSV(int r, int g, int b) // Converts RGB values to an HSV string. Credit for formula goes to https://www.cs.rit.edu/~ncs/color/t_convert.html
        {
            string result = "";

            float r1 = ((float)r) / 255; Console.WriteLine(r1);
            float g1 = ((float)g) / 255; Console.WriteLine(g1);
            float b1 = ((float)b) / 255; Console.WriteLine(b1);

            float h;
            float s;
            float v;
            
            float min;
            float max;
            float delta;

            min = Math.Min(Math.Min(r1, g1), b1);
            max = Math.Max(Math.Max(r1, g1), b1);
            v = max;
            delta = max - min;
            
            if(max != 0)
            {
                s = delta / max;
            }
            else
            {
                s = 0;
                h = 0;
                result = h + "," + (s * 100) + "," + (v * 100);
                return result;
            }

            if (r1 == max)
            {
                h = (g1 - b1) / delta;
            }
            else if (g1 == max)
            {
                h = 2 + (b1 - r1) / delta;
            }
            else
            {
                h = 4 + (r1 - g1) / delta;
            }

            h *= 60;
            while (h < 0)
                h += 360;
            if (s == 0)
                h = 0;
            result = Math.Floor(h) + "," + Math.Floor(s * 100) + "," + Math.Floor(v * 100);
            return result;
        }
        
        public Color HSVtoRGB(string HSV)
        {
            int R;
            int G;
            int B;
            int i;
            float r;
            float g;
            float b;
            float f;
            float p;
            float q;
            float t;
            float h;
            float s;
            float v;
                
            Color result;
            string[] ColorValues = HSV.Split(',');
            h = (((float)Convert.ToInt32(ColorValues[0].Trim())));
            s = (((float)Convert.ToInt32(ColorValues[1].Trim())) / 100);
            v = (((float)Convert.ToInt32(ColorValues[2].Trim())) / 100);

            if ( s == 0)
            {
                // achrmatic (grey)
                B = Convert.ToInt32(v * 255);
                R = B;
                G = B; 
                result = Color.FromArgb(255, R, G, B);
            }

            if (h == 360)
            {
                h = 0;
            }
            h /= 60;
            i = Convert.ToInt32(Math.Floor(h));
            if (i == 6)
            {
                h = 0;
            }
            f = h - i;
            p = v * (1 - s);
            q = v * (1 - s * f);
            t = v * (1 - s * (1 - f));

            switch(i)
            {
                case 0:
                    r = v;
                    g = t;
                    b = p;
                    break;
                case 1:
                    r = q;
                    g = v;
                    b = p;
                    break;
                case 2:
                    r = p;
                    g = v;
                    b = t;
                    break;
                case 3:
                    r = p;
                    g = q;
                    b = v;
                    break;
                case 4:
                    r = t;
                    g = p;
                    b = v;
                    break;
                default:        // case 5:
                    r = v;
                    g = p;
                    b = q;
                    break;
            }
            R = Convert.ToInt32(r * 255);
            G = Convert.ToInt32(g * 255);
            B = Convert.ToInt32(b * 255);
            result = Color.FromArgb(255, R, G, B);
            return result;
        }

        private void ColorName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CopyButton.Focus();
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private string ColorRGBToText(int R, int G, int B, string ColorType)
        {
            if ((string)OutputType.SelectedItem == "RGB")
            {
                return  R + ", " + G + ", " + B;
            }
            else if ((string)OutputType.SelectedItem == "Hex")
            {
                string hexR = R.ToString("X2");
                string hexG = G.ToString("X2");
                string hexB = B.ToString("X2");
                return hexB + hexG + hexR;
            }
            else if ((string)OutputType.SelectedItem == "#Hex")
            {
                string hexR = R.ToString("X2");
                string hexG = G.ToString("X2");
                string hexB = B.ToString("X2");
                return "#" + hexB + hexG + hexR;
            }
            else if ((string)OutputType.SelectedItem == "Hex (RRGGBB)")
            {
                string hexR = R.ToString("X2");
                string hexG = G.ToString("X2");
                string hexB = B.ToString("X2");
                return hexR + hexG + hexB;
            }
            else if ((string)OutputType.SelectedItem == "#Hex (RRGGBB)")
            {
                string hexR = R.ToString("X2");
                string hexG = G.ToString("X2");
                string hexB = B.ToString("X2");
                return "#" + hexR + hexG + hexB;
            }
            else if ((string)OutputType.SelectedItem == "RGB(R,G,B)")
            {
                return "rgb: (" + R + ", " + G + ", " + B + ")";
            }
            else if ((string)OutputType.SelectedItem == "HSV")
            {
                return RGBtoHSV(R, G, B);
            }
            else
            {
                return "Error";
            }
        }
    }
}

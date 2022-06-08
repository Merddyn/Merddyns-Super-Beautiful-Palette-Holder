using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Merddyns_Super_Beautiful_Palette_Holder_WinForm
{
    public partial class Form1 : Form
    {
        List<PaletteColor> Colors = new List<PaletteColor>();
        List<PaletteID> Palettes = new List<PaletteID>();


        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Palettes = FileReadWrites.ReadPaletteList();
            foreach (PaletteID Palette in Palettes)
            {
                PalettesListBox.Items.Add(Palette.Name);
            }
            PalettesListBox.SelectedIndex = 0;
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            SavePalette();
            /*
            DialogResult result = saveFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string path = saveFileDialog1.FileName;
            }*/
        }

        private void SavePalette()
        {
            FileReadWrites.WritePaletteList("PalettesList.xml", Palettes);
            Colors.Clear();
            foreach (ColorControl colorControl in flowLayoutPanel.Controls)
            {
                PaletteColor NewColor = new PaletteColor(colorControl.BackColor.R, colorControl.BackColor.G, colorControl.BackColor.B, colorControl.BackColor.A, colorControl.Controls[3].Text);
                Colors.Add(NewColor);
            }
            FileReadWrites.WriteColorList(Palettes[PalettesListBox.SelectedIndex].Path, Palettes[PalettesListBox.SelectedIndex].Name, Colors);
        }

        private void btn_AddPalette_Click(object sender, EventArgs e)
        {
            AddNewPalette();

        }

        private void AddNewPalette()
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "xml files (*.xml)|*.xml|AllFiles (*.*|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = saveFileDialog1.FileName;
                FileReadWrites.WriteNewColorList(path);
                PaletteID NewPalette = new PaletteID("New Palette", path);
                Palettes.Add(NewPalette);
                PalettesListBox.Items.Add(NewPalette.Name);
            }
        }

        private void PalettesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PalettesListBox.SelectedIndex != -1)
            {
                GenerateColorsList();
                txt_PaletteName.Text = PalettesListBox.SelectedItem.ToString();
            }
            
        }

        private void GenerateColorsList()
        {
            Colors = FileReadWrites.ReadColorList(Palettes[PalettesListBox.SelectedIndex].Path);
            

            flowLayoutPanel.Controls.Clear();
            for (int i = 0; i < Colors.Count; i++)
            {
                ColorControl control = new ColorControl(Colors[i].color, Colors[i].Name);
                /*                Button button = new Button()
                                {
                                    Text = string.Format("Button for {0}", i),
                                    Tag = i

                                };
                                Panel panel = new Panel()
                                {
                                    BackColor = Color.Green
                                };
                                panel.Controls.Add(button);
                                button.Click += new EventHandler(button1_Click);*/
                flowLayoutPanel.Controls.Add(control);
            }
            cmb_ColorList.Items.Clear();
            for (int i = 0; i < Colors.Count; i++)
            {
                cmb_ColorList.Items.Add(i + 1);
            }
        }

        private void txt_PaletteName_TextChanged(object sender, EventArgs e)
        {
            Palettes[PalettesListBox.SelectedIndex].Name = txt_PaletteName.Text;
            PalettesListBox.Items[PalettesListBox.SelectedIndex] = txt_PaletteName.Text;
            
        }

        private void btn_AddColor_Click(object sender, EventArgs e)
        {
            ColorControl control = new ColorControl(Color.White, "New Color");
            flowLayoutPanel.Controls.Add(control);
        }

        private void btn_Load_Click(object sender, EventArgs e) // Import existing palette.
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "xml files (*.xml)|*.xml|AllFiles (*.*|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            Palettes.Add(new PaletteID("TempName", openFileDialog1.FileName));
                            PalettesListBox.Items.Add("TempName");
                            PalettesListBox.SelectedIndex = (PalettesListBox.Items.Count - 1);
                        }
                        
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
                finally
                {
                    
                    openFileDialog1.Dispose();
                    openFileDialog1 = new OpenFileDialog();
                }

            }
        }

        private void btn_RemovePalette_Click(object sender, EventArgs e)
        {
            int CurrentIndex = PalettesListBox.SelectedIndex;
            
            if (PalettesListBox.Items.Count == 1)
            {
                MessageBox.Show("Cannot remove last palette, please add a new one first.");
            }
            else
            {
                Palettes.RemoveAt(CurrentIndex);
                PalettesListBox.Items.RemoveAt(CurrentIndex);
                if (CurrentIndex != 0)
                {
                    PalettesListBox.SelectedIndex = (CurrentIndex - 1);
                }
                else
                {
                    PalettesListBox.SelectedIndex = 0;
                }
            }
        }

        private void btn_RemoveColor_Click(object sender, EventArgs e)
        {
            if (cmb_ColorList.SelectedIndex < 0)
            {
                Colors.RemoveAt(Colors.Count - 1);
            }
            else
            {
                Colors.RemoveAt(cmb_ColorList.SelectedIndex);
            }
            RefreshColors();
        }

        private void RefreshColors()
        {
            flowLayoutPanel.Controls.Clear();
            for (int i = 0; i < Colors.Count; i++)
            {
                ColorControl control = new ColorControl(Colors[i].color, Colors[i].Name);
                flowLayoutPanel.Controls.Add(control);
            }
            cmb_ColorList.Items.Clear();
            for (int i = 0; i < Colors.Count; i++)
            {
                cmb_ColorList.Items.Add(i + 1);
            }
        }

        private void txt_PaletteName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lbl_PaletteName.Focus();
            }
        }

    }
}

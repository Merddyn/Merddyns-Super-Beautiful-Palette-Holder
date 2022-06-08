using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Drawing;

namespace Merddyns_Super_Beautiful_Palette_Holder_WinForm
{
    public static class FileReadWrites
    {
        public static List<PaletteID> ReadPaletteList()
        {
            List<PaletteID> Palettes = new List<PaletteID>();
            string Path = "PalettesList.xml";
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.IgnoreWhitespace = true;
            settings.IgnoreComments = true;

            XmlReader XmlIn = XmlReader.Create(Path, settings);

            if (XmlIn.ReadToDescendant("ColorPalette"))
            {
                do
                {
                    string path = "";
                    string name = "";
                    XmlIn.ReadToDescendant("PaletteName");
                    // XmlIn.ReadStartElement("PaletteName");
                    name = XmlIn.ReadElementContentAsString();
                    //  XmlIn.ReadToNextSibling("Location");
                    // XmlIn.ReadStartElement("Location");
                    path = XmlIn.ReadElementContentAsString();
                    PaletteID Palette = new PaletteID(name, path);
                    Palettes.Add(Palette);
                }
                while (XmlIn.ReadToNextSibling("ColorPalette"));
                XmlIn.Close();

            }
            return Palettes;
        }

        public static List<PaletteColor> ReadColorList(string Path)
        {
            List<PaletteColor> PaletteColors = new List<PaletteColor>();
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.IgnoreWhitespace = true;
            settings.IgnoreComments = true;

            XmlReader XmlIn = XmlReader.Create(Path, settings);


            if (XmlIn.ReadToDescendant("Color"))
            {
                do
                {
                    int Red;
                    int Green;
                    int Blue;
                    int Alpha;
                    string Name;
                    XmlIn.ReadToDescendant("Name");
                    // XmlIn.ReadStartElement("PaletteName");
                    Name = XmlIn.ReadElementContentAsString();
                    Red = XmlIn.ReadElementContentAsInt();
                    Green = XmlIn.ReadElementContentAsInt();
                    Blue = XmlIn.ReadElementContentAsInt();
                    Alpha = XmlIn.ReadElementContentAsInt();
                    //  XmlIn.ReadToNextSibling("Location");
                    // XmlIn.ReadStartElement("Location");

                    PaletteColor color = new PaletteColor(Red, Green, Blue, Alpha, Name);
                    PaletteColors.Add(color);

                }
                while (XmlIn.ReadToNextSibling("Color"));
                XmlIn.Close();

            }

            return PaletteColors;
        }
        public static void WriteNewColorList(string Path)
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.IndentChars = ("     ");

            XmlWriter xmlOut = XmlWriter.Create(Path, settings);

            xmlOut.WriteStartDocument();
            xmlOut.WriteStartElement("ColorPalette");
            xmlOut.WriteAttributeString("PaletteName", "New Palette");
            xmlOut.WriteStartElement("Color");
            xmlOut.WriteElementString("Name", "New Color");
            xmlOut.WriteElementString("Red", "255");
            xmlOut.WriteElementString("Green", "255");
            xmlOut.WriteElementString("Blue", "255");
            xmlOut.WriteElementString("Alpha", "255");
            xmlOut.WriteEndElement();
            xmlOut.WriteEndElement();
            xmlOut.Close();
        }

        public static void WriteColorList(string Path, string Name, List<PaletteColor> colors)
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.IndentChars = ("     ");

            XmlWriter xmlOut = XmlWriter.Create(Path, settings);

            xmlOut.WriteStartDocument();
            xmlOut.WriteStartElement("ColorPalette");
            xmlOut.WriteAttributeString("PaletteName", Name);

            foreach (PaletteColor color in colors)
            {
                xmlOut.WriteStartElement("Color");
                xmlOut.WriteElementString("Name", color.Name);
                xmlOut.WriteElementString("Red", color.color.R.ToString());
                xmlOut.WriteElementString("Green", color.color.G.ToString());
                xmlOut.WriteElementString("Blue", color.color.B.ToString());
                xmlOut.WriteElementString("Alpha", color.color.A.ToString());
                xmlOut.WriteEndElement();
            }


            xmlOut.WriteEndElement();
            xmlOut.Close();
        }

        public static void WritePaletteList(string Path, List<PaletteID> palettes)
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.IndentChars = ("     ");

            XmlWriter xmlOut = XmlWriter.Create(Path, settings);

            xmlOut.WriteStartDocument();
            xmlOut.WriteStartElement("root");


            foreach (PaletteID palette in palettes)
            {
                xmlOut.WriteStartElement("ColorPalette");
                xmlOut.WriteElementString("PaletteName", palette.Name);
                xmlOut.WriteElementString("Location", palette.Path);
                xmlOut.WriteEndElement();
            }


            xmlOut.WriteEndElement();
            xmlOut.Close();
        }
    
}    

}

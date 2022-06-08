using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Merddyns_Super_Beautiful_Palette_Holder_WinForm
{
    public class PaletteColor
    {
        public string Name;
        public Color color;
        
        public PaletteColor (int _Red, int _Green, int _Blue, int _Alpha, String _Name)
        {
            color = Color.FromArgb(_Alpha, _Red, _Green, _Blue);
            Name = _Name;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Life.CLS.Theme
{
    class ColorDisplay
    {
        public void SetColorDisplay(string selectedColorDisplay)
        {
            Properties.Settings.Default.colorDisplay = selectedColorDisplay;
            Properties.Settings.Default.Save();
        }
    }
}

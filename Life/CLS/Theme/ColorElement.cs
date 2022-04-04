using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Life.CLS.Theme
{
    class ColorElement
    {
        public void SetColorElement(string selectedcolorElement)
        {
            Properties.Settings.Default.colorElements = selectedcolorElement;
            Properties.Settings.Default.Save();
        }
    }
}

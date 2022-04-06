using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Life.CLS.Theme
{
    class BackgroundColor
    {
        /// <summary>
        /// Sets a value for Properties.Settings.backgroundColor.
        /// </summary>
        /// <param name="selectedColorDisplay"></param>
        public void SetBackgroundColor(string selectedColorDisplay)
        {
            Properties.Settings.Default.backgroundColor = selectedColorDisplay;
            Properties.Settings.Default.Save();
        }
    }
}

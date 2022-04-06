using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Life.CLS.Theme
{
    class CellColor
    {
        /// <summary>
        /// Sets a value for Properties.Settings.cellColor.
        /// </summary>
        /// <param name="selectedcolorElement"></param>
        public void SetCellColor(string selectedcolorElement)
        {
            Properties.Settings.Default.cellColor = selectedcolorElement;
            Properties.Settings.Default.Save();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Life
{
    class Resolution
    {
        /// <summary>
        /// Sets a value for Properties.Settings.resolution.
        /// </summary>
        /// <param name="resolution"></param>
        public void SetResolution(int resolution)
        {
            Properties.Settings.Default.resolution = (int)resolution;
            Properties.Settings.Default.Save();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Life
{
    class Resolution
    {
        public void SetResolution(int resolution)
        {
            Properties.Settings.Default.resolution = (int)resolution;
            Properties.Settings.Default.Save();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Life
{
    class Density
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="density"></param>
        public void SetDensity(int density)
        {
            Properties.Settings.Default.density = (int)density;
            Properties.Settings.Default.Save();
        }    
    }
}

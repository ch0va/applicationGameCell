using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Life.CLS.Theme
{
    class BackgroundImage
    {
        string filePath;
        public void SetBackgroundImage()
        {
            var oFD = new OpenFileDialog();
            oFD.Filter = "Image files (*.bmp, *.jpg, *.png)|*.bmp;*.jpg;*.png";
            oFD.RestoreDirectory = true;
            if (oFD.ShowDialog() == DialogResult.OK)
            {
                filePath = oFD.FileName;
                Properties.Settings.Default.buttonAcceptEnabled = true;
                Properties.Settings.Default.filePath = filePath;
                Properties.Settings.Default.Save();
            }
            else
            {
                if (Properties.Settings.Default.thereImage == false)
                Properties.Settings.Default.buttonAcceptEnabled = false;
            }
            
        }
    }
}

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
        /// <summary>
        /// Creating a new OpenFileDialog for loading an image from the computer.
        /// </summary>
        public void SetBackgroundImage()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.bmp, *.jpg, *.png)|*.bmp;*.jpg;*.png";
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;
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

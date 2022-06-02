using Life.FRNS;
using System.IO;

namespace Life
{
    public class NewFormSettings
    {
        /// <summary>
        ///  Сreating a new FormSettings.
        /// </summary>
        public void GetFormSettings()
        {
            if (File.Exists($@"..\..\resources\colors.txt") == false)
            {
                string path = $@"..\..\resources";
                File.AppendAllText(path + "\\colors.txt", "Aqua\nAquamarine\nAzure\nBeige" +
                    "\nBlack\nBlue\nBrown\nCoral\nGold\nGray\nGreen\nIndigo\nIvory\nKhaki" +
                    "\nLime\nOlive\nOrange\nPink\nPurple\nRed\nSalmon\nSilver\nSkyBlue\nViolet\nWhite\nYellow");
            }

            FormSettings s = new FormSettings();
            s.comboBoxCellColor.Text = Properties.Settings.Default.cellColor;
            s.comboBoxBackgroundColor.Text = Properties.Settings.Default.backgroundColor;
            s.numericUpDownResolution.Value = Properties.Settings.Default.resolution;
            s.numericUpDownDensity.Value = 17 -Properties.Settings.Default.density ;
            s.checkBoxImage.Checked = Properties.Settings.Default.checkBoxImageChecked;
            s.buttonAccept.Enabled = false;
            s.Show();

        }
    }

}



    




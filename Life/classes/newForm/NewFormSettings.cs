using Life.FRNS;

namespace Life
{
    public class NewFormSettings
    {
        /// <summary>
        ///  Сreating a new FormSettings.
        /// </summary>
        public void GetFormSettings()
        {
            FormSettings s = new FormSettings();

            s.comboBoxCellColor.Text = Properties.Settings.Default.cellColor;
            s.comboBoxBackgroundColor.Text = Properties.Settings.Default.backgroundColor;
            s.numericUpDownResolution.Value = Properties.Settings.Default.resolution;
            s.numericUpDownDensity.Value = Properties.Settings.Default.density;
            s.checkBoxImage.Checked = Properties.Settings.Default.checkBoxImageChecked;
            s.buttonAccept.Enabled = false;
            s.Show();

        }
    }

}



    




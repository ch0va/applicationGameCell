using Life.FRNS;

namespace Life
{
    public class NewFormSettings
    {
        public void GetFormSettings()
        {
            FormSettings s = new FormSettings();

            s.comboBoxElements.Text = Properties.Settings.Default.colorElements;
            s.comboBoxDisplay.Text = Properties.Settings.Default.colorDisplay;
            s.nudResolution.Value = Properties.Settings.Default.resolution;
            s.nudDensity.Value = Properties.Settings.Default.density;
            s.checkBoxImage.Checked = Properties.Settings.Default.checkBoxImageChecked;
            s.buttonAccept.Enabled = false;
            s.Show();

        }
    }

}



    




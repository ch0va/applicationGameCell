using System;
using Life.FRN;
using Life.FRNS;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Life.CLS.Theme;
using Life.classes.other;

namespace Life.FRNS
{
    public partial class FormSettings : Form
    {

        BackgroundImage setBackgroundImag = new BackgroundImage();
        public string selectedColorDisplay;
        public string selectedColorElements;
        public string pathColors = $@"..\..\DATA\colors.txt";

        public FormSettings()
        {
            InitializeComponent();
            checkBoxImage.Checked = false;
            buttonUpload.Enabled = false;
            using (StreamReader f = new StreamReader(pathColors, System.Text.Encoding.GetEncoding(1252)))
            {
                string str;
                while ((str = f.ReadLine()) != null)
                {
                    comboBoxBackgroundColor.Items.Add(str + Environment.NewLine);
                    comboBoxCellColor.Items.Add(str + Environment.NewLine);
                }
            }
        }
        /// <summary>
        /// Changing the Enabled form Elements
        /// </summary>
        /// <param name="trueOrFalse"></param>
        public void BlockElements(bool trueOrFalse)
        {
            comboBoxBackgroundColor.Enabled = trueOrFalse;
            comboBoxCellColor.Enabled = trueOrFalse;
            numericUpDownDensity.Enabled = trueOrFalse;
            numericUpDownResolution.Enabled = trueOrFalse;
            buttonAccept.Enabled = trueOrFalse;
            buttonDefault.Enabled = trueOrFalse;
            buttonMenu.Enabled = trueOrFalse;
        }
      
        public void buttonAccept_Click(object sender, EventArgs e)
        {
            Resolution setResolution = new Resolution();
            setResolution.SetResolution((int)numericUpDownResolution.Value);

            Density setDensity = new Density();
            setDensity.SetDensity((int)numericUpDownDensity.Value);


            BackgroundColor colorDisplay = new BackgroundColor();
            colorDisplay.SetBackgroundColor(selectedColorDisplay);

            CellColor colorElements = new CellColor();
            colorElements.SetCellColor(selectedColorElements);

            BlockElements(true);


            if (checkBoxImage.Checked == true)
            {
                comboBoxBackgroundColor.Enabled = false;
                Properties.Settings.Default.checkBoxImageChecked = true;
            }

            if (checkBoxImage.Checked == false)
                Properties.Settings.Default.checkBoxImageChecked = false;

            Properties.Settings.Default.Save();

            buttonAccept.Enabled = false;


        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            FormMenu formMenu = new FormMenu();
            formMenu.Show();
            this.Close();
        }

        private void numericUpDownResolution_ValueChanged(object sender, EventArgs e)
        {
            buttonAccept.Enabled = true;
        }

        private void numericUpDownDensity_ValueChanged(object sender, EventArgs e)
        {
            buttonAccept.Enabled = true;
        }

        private void buttonDefault_Click(object sender, EventArgs e)
        {
            numericUpDownDensity.Value = 5;
            numericUpDownResolution.Value = 15;

            comboBoxBackgroundColor.SelectedIndex = 137;
            comboBoxBackgroundColor.Text = "White";


            comboBoxCellColor.SelectedIndex = 7;
            comboBoxCellColor.Text = "Black";
            checkBoxImage.Checked = false;

            buttonAccept_Click(sender, e);
        }



        private void comboBoxCellColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedColorElements = comboBoxCellColor.SelectedItem.ToString();
            buttonAccept.Enabled = true;
        }

        private void comboBoxBackgroundColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedColorDisplay = comboBoxBackgroundColor.SelectedItem.ToString();
            buttonAccept.Enabled = true;
        }

        private void buttonUpload_Click(object sender, EventArgs e)
        {
            setBackgroundImag.SetBackgroundImage();
            Properties.Settings.Default.thereImage = true;
            string filePath = Properties.Settings.Default.filePath;
            BlockElements(false);
            buttonAccept.Enabled = Properties.Settings.Default.buttonAcceptEnabled;
        }

        private void checkBoxImage_CheckedChanged(object sender, EventArgs e)
        {
            buttonAccept.Enabled = true;
            if (checkBoxImage.Checked == true)
            {
                comboBoxBackgroundColor.Enabled = false;
                buttonUpload.Enabled = true;
                if (Properties.Settings.Default.thereImage == false)
                {
                    BlockElements(false);
                }
            }

            if (checkBoxImage.Checked == false)
            {
                BlockElements(true);
                buttonUpload.Enabled = false;
            }
        }

        private void buttonHelpResolution_Click(object sender, EventArgs e)
        {
            BoxWithMessage helpResolution = new BoxWithMessage();
            helpResolution.GetMessage("This parameter is responsible for changing " +
                "the resolution of the game screen.","Help");                   
        }

        private void buttonHelpCellColor_Click(object sender, EventArgs e)
        {
            BoxWithMessage helpCellColor = new BoxWithMessage();
            helpCellColor.GetMessage("This parameter is responsible " +
                "for changing the color of the cells.", "Help");
        }

        private void buttonHelpImage_Click(object sender, EventArgs e)
        {
            BoxWithMessage helpImage = new BoxWithMessage();
            helpImage.GetMessage("Check this box if you want to set your " +
                "own image as the game screen background.", "Help");
        }

        private void buttonHelpDensity_Click(object sender, EventArgs e)
        {
            BoxWithMessage helpDensity = new BoxWithMessage();
            helpDensity.GetMessage("This parameter is responsible for changing " +
                "the density of generation of new cell.","Help");
        }

        private void buttonHelpBackgroundColor_Click(object sender, EventArgs e)
        {
            BoxWithMessage helpBackgroundcolor = new BoxWithMessage();
            helpBackgroundcolor.GetMessage("This parameter is responsible for changing " +
                "the color of the background image of the game screen.","Help");
        }

    }
}

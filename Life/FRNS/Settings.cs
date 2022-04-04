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

namespace Life.FRNS
{
    public partial class FormSettings : Form
    {
        
        BackgroundImage setBI = new BackgroundImage();
        public string selectedColorDisplay;
        public string selectedColorElements;

        public string path = $@"..\..\DATA\colors.txt";
        
        public FormSettings()
        {
            InitializeComponent();
            checkBoxImage.Checked = false;
            buttonUpload.Enabled = false;
            using (StreamReader f = new StreamReader(path, System.Text.Encoding.GetEncoding(1252)))
            {
                string str;
                while ((str = f.ReadLine()) != null)
                {
                    comboBoxDisplay.Items.Add(str + Environment.NewLine);
                    comboBoxElements.Items.Add(str + Environment.NewLine);
                }
            }
        }
        public void BlockElements(bool tOF)
        {
            comboBoxDisplay.Enabled = tOF;
            comboBoxElements.Enabled = tOF;
            nudDensity.Enabled = tOF;
            nudResolution.Enabled = tOF;
            buttonAccept.Enabled = tOF;
            buttonDefault.Enabled = tOF;
            buttonMenu.Enabled = tOF;
        }

        public void buttonAccept_Click(object sender, EventArgs e)
        {
            Resolution setResolution = new Resolution();
            setResolution.SetResolution((int)nudResolution.Value);

            Density setDensity = new Density();
            setDensity.SetDensity((int)nudDensity.Value);


            ColorDisplay colorDisplay = new ColorDisplay();
            colorDisplay.SetColorDisplay(selectedColorDisplay) ;

            ColorElement colorElements = new ColorElement();
            colorElements.SetColorElement(selectedColorElements);

            BlockElements(true);


            if (checkBoxImage.Checked == true)
            {
                comboBoxDisplay.Enabled = false;
                Properties.Settings.Default.checkBoxImageChecked = true;
            }

            if (checkBoxImage.Checked == false)
                Properties.Settings.Default.checkBoxImageChecked = false;

            Properties.Settings.Default.Save();
            
            buttonAccept.Enabled = false;
            

        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            FormMenu m = new FormMenu();
            m.Show();
            this.Close();
        }

        private void nudResolution_ValueChanged(object sender, EventArgs e)
        {
            buttonAccept.Enabled = true;   
        }

        private void nudDensity_ValueChanged(object sender, EventArgs e)
        {
            buttonAccept.Enabled = true;
        }

        private void buttonDefault_Click(object sender, EventArgs e)
        {
            nudDensity.Value = 5;
            nudResolution.Value = 15;

            comboBoxDisplay.SelectedIndex = 137;
            comboBoxDisplay.Text = "White";

            
            comboBoxElements.SelectedIndex = 7;
            comboBoxElements.Text = "Black";
            checkBoxImage.Checked = false;
          
            buttonAccept_Click(sender, e);
        }

       
              
        private void comboBoxElements_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedColorElements = comboBoxElements.SelectedItem.ToString();
            buttonAccept.Enabled = true;
        }

        private void comboBoxDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedColorDisplay = comboBoxDisplay.SelectedItem.ToString();
            buttonAccept.Enabled = true;
        }

        private void buttonUpload_Click(object sender, EventArgs e)
        {
            setBI.SetBackgroundImage();
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
                comboBoxDisplay.Enabled = false;
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
    }
}

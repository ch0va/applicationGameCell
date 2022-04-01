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

namespace Life.FRNS
{
    public partial class FormSettings : Form
    {
        public string selectedColorForms;
        public string selectedColorElements;
        public string path = $@"..\..\DATA\colors.txt";
        public FormSettings()
        {

            InitializeComponent();
            using (StreamReader f = new StreamReader(path, System.Text.Encoding.GetEncoding(1252)))
            {
                string str;
                while ((str = f.ReadLine()) != null)
                {
                    comboBoxForms.Items.Add(str + Environment.NewLine);
                    comboBoxElements.Items.Add(str + Environment.NewLine);
                }
            }

            Theme colorForms = new Theme();
            colorForms.selectedColor = selectedColorForms;
            colorForms.SetTheme("selectedColorForms");

            Theme colorElements = new Theme();
            colorElements.selectedColor = selectedColorElements;
            colorElements.SetTheme("selectedColorElements");


        }
        public void Resolution()
        {

            /*resolution = (int)nudResolution.Value;
            FormGame g = new FormGame();
            g.resolution = resolution;
            g.Show();
            this.Close();*/


        }




        public void buttonAccept_Click(object sender, EventArgs e)
        {   
            RAD setResolution = new RAD();
            setResolution.resolution = (int)nudResolution.Value;
            setResolution.SetResolutionAndDansity();

            RAD setDensity = new RAD();
            setDensity.density = (int)nudDensity.Value;
            setDensity.fromFile = "settingDensity";
            setDensity.WhatNeeds = "density";
            setDensity.SetResolutionAndDansity();

           
            Theme colorForms = new Theme();
            colorForms.selectedColor = selectedColorForms;
            colorForms.SetTheme("selectedColorForms") ;

            Theme colorElements = new Theme();
            colorElements.selectedColor = selectedColorElements;
            colorElements.SetTheme("selectedColorElements");


            {
                buttonAccept.Enabled = false;
            }

        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            FormMenu m = new FormMenu();
            m.Show();
            this.Close();
        }

        private void nudResolution_ValueChanged(object sender, EventArgs e)
        {
            {
                buttonAccept.Enabled = true;
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            {
                buttonAccept.Enabled = true;
            }
        }

        private void buttonDefault_Click(object sender, EventArgs e)
        {
            nudDensity.Value = 5;
            nudResolution.Value = 15;

            comboBoxForms.SelectedIndex = 137;
            comboBoxForms.Text = "White";

            
            comboBoxElements.SelectedIndex = 7;
            comboBoxElements.Text = "Black";
            buttonAccept_Click(sender, e);
        }

       
              
        private void comboBoxElements_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedColorElements = comboBoxElements.SelectedItem.ToString();
            buttonAccept.Enabled = true;
        }

        private void comboBoxForms_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedColorForms = comboBoxForms.SelectedItem.ToString();
            buttonAccept.Enabled = true;
        }

       
    }
}

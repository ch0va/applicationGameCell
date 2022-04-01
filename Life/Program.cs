using System;
using Life.FRN;
using Life.FRNS;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Life
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMenu());
        }

    }
    public class NewForm
    {
        public void GetFormSettings()
        {
            FormSettings s = new FormSettings();
            string pathColElem = $@"..\..\DATA\selectedColorElements.txt"; ;
            using (FileStream file = new FileStream(pathColElem, FileMode.Open))
            {
                using (StreamReader stream = new StreamReader(file, System.Text.Encoding.GetEncoding(1251)))
                {
                    string newColor1 = stream.ReadLine();
                    s.comboBoxElements.Text = newColor1;
                }
            }

            string pathColForms = $@"..\..\DATA\selectedColorForms.txt"; ;
            using (FileStream file = new FileStream(pathColForms, FileMode.Open))
            {
                using (StreamReader stream = new StreamReader(file, System.Text.Encoding.GetEncoding(1251)))
                {
                    string newColor2 = stream.ReadLine();
                    s.comboBoxForms.Text = newColor2;
                }
            }

            string pathRes = $@"..\..\DATA\settingResolution.txt";
            using (FileStream settingFile = new FileStream(pathRes, FileMode.Open))
            {
                using (StreamReader stream = new StreamReader(settingFile, System.Text.Encoding.GetEncoding(1251)))
                {
                    string str = stream.ReadLine();

                    decimal newResolution;
                    decimal.TryParse(str.ToString(), out newResolution);
                    s.nudResolution.Value = newResolution;
                }
            }
            string pathDen = $@"..\..\DATA\settingDensity.txt";
            using (FileStream settingFile = new FileStream(pathDen, FileMode.Open))
            {
                using (StreamReader stream = new StreamReader(settingFile, System.Text.Encoding.GetEncoding(1251)))
                {
                    string str = stream.ReadLine();

                    decimal newDensity;
                    decimal.TryParse(str.ToString(), out newDensity);

                    s.nudDensity.Value = newDensity;
                    {
                        s.buttonAccept.Enabled = false;
                    }
                    s.Show();

                }
            }

        }
    }
    public class RAD
    {
        public string fromFile;
        public string WhatNeeds;
        public decimal resolution;
        public decimal density;

        public void SetResolutionAndDansity()
        {
            string path = $@"..\..\DATA\{fromFile}.txt";

            using (FileStream settingFile = new FileStream(path, FileMode.Open))
            {
                using (StreamWriter stream = new StreamWriter(settingFile))
                {
                    if (WhatNeeds == "resolution")
                    {
                        stream.WriteLine(resolution);
                    }
                    if (WhatNeeds == "density")
                    {
                        stream.WriteLine(density);
                    }
                }
            }
        }
        public decimal ResolutionOrDensity()
        {
            string path = $@"..\..\DATA\{fromFile}.txt";
            using (FileStream settingFile = new FileStream(path, FileMode.Open))
            {
                using (StreamReader stream = new StreamReader(settingFile, System.Text.Encoding.GetEncoding(1251)))
                {
                    string str = stream.ReadLine();

                    decimal newResolutionOrDensity;
                    decimal.TryParse(str.ToString(), out newResolutionOrDensity);
                    if (WhatNeeds == "resolution")
                    {
                        resolution = (int)newResolutionOrDensity;
                        return resolution;
                    }
                    if (WhatNeeds == "density")
                    {
                        density = (int)newResolutionOrDensity;
                        return density;
                    }
                    return resolution;
                }
            }
        }


    }
}



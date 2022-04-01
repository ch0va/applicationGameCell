using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Life
{
    class Theme
    {
        
        public string selectedColor;
        public string newSelectedColor;
        public void SetTheme(string openFile)
        {
            string path = $@"..\..\DATA\{openFile}.txt";

            using (FileStream file = new FileStream(path, FileMode.Open))
            {
                using (StreamWriter stream = new StreamWriter(file))
                {

                        stream.Write(selectedColor);
                }
         
            }
        }
        public void GetTheme(string openFile)
        {
            string path = $@"..\..\DATA\{openFile}.txt";
            using (FileStream file = new FileStream(path, FileMode.Open))
            {
                using (StreamReader stream = new StreamReader(file, System.Text.Encoding.GetEncoding(1251)))
                {
                    string newColor = stream.ReadLine();
                    newSelectedColor = newColor;
                    
                    return;
                }
            }
        }

    }
}

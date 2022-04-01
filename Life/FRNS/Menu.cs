using Life.FRN;
using Life.FRNS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Life
{
    public partial class FormMenu : Form
    {
       
        public FormMenu()
        {
            InitializeComponent();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {  
            Application.Exit();
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {

            NewForm form = new NewForm();
            form.GetFormSettings();
            this.Hide();
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
      
            FormGame g = new FormGame();
            g.buttonStop.Enabled = false;
            g.buttonStart.Enabled = false;
            this.Hide();
            g.Show();
          
            
        }

      
    }
}

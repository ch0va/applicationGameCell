﻿using Life.FRN;
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
           Properties.Settings.Default.Save();
            Application.Exit();
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            NewFormSettings s = new NewFormSettings();
            s.GetFormSettings();
            this.Hide();
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            NewFormGame s = new NewFormGame();
            s.GetFormGame();
            this.Hide();
              
        }

      
    }
}

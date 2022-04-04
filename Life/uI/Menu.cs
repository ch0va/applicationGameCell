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
            Properties.Settings.Default.filePath.DefaultIfEmpty();
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

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The universe of the game «Cell» is an infinite, " +
                "two-dimensional grid of square cells, " +
                "each of which is in one of two possible states, " +
                "live or dead.\nEvery cell interacts with its eight neighbours, " +
                "which are the cells that are horizontally, vertically, " +
                "or diagonally adjacent.\nAt each step in time, " +
                "the following transitions occur:\n\n-Any live cell " +
                "with fewer than two live neighbours dies. " +
                "\n\n-Any live cell with two or three" +
                " live neighbours lives on to the next generation." +
                "\n\n-Any live cell with more than three live neighbours dies." +
                " \n\n-Any dead cell with exactly three live " +
                "neighbours becomes a live cell.\n\n Use the left mouse button " +
                "to add live cells and the right mouse button to remove them." +
                "\n\nYou can also upload your own background image in the settings." +
                "\n\nPlese, enloy the game!","About program", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

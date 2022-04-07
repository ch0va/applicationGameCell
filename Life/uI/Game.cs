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
using System.Drawing.Imaging;
using Life.CLS.Theme;
using Life.classes.other;

namespace Life.FRN
{
    public partial class formGame : Form
    {
        public Bitmap bitmap;
        public string newColorDisplay;
        public string newColorElement;
        private Graphics graphics;
        public int resolution;
        public int density;
        public bool[,] cell;
        public int rows;
        public int cols;
        public Image backgroundImage;
        public bool checkBoxImageCheckedFormSettings = Properties.Settings.Default.checkBoxImageChecked;
        public string backgroundImagePath = Properties.Settings.Default.filePath;

        public formGame()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Getting variable values from Properties and checking for an image.
        /// </summary>
        public void GetAllParameters()
        {
            resolution = Properties.Settings.Default.resolution;

            density = Properties.Settings.Default.density;

            newColorDisplay = Properties.Settings.Default.backgroundColor;
            newColorDisplay = newColorDisplay.Trim();

            newColorElement = Properties.Settings.Default.cellColor;
            newColorElement = newColorElement.Trim();
            
            if (checkBoxImageCheckedFormSettings == true)
            {
                if (backgroundImagePath != "")
                {
                    backgroundImage = Image.FromFile(backgroundImagePath); //Setting the uploaded image as the background image
                    bitmap = new Bitmap(backgroundImage, pictureBoxDisplay.Width+1, pictureBoxDisplay.Height + 1);
                }
                
            }
        }

        /// <summary>
        /// Starting a new generation of cells.
        /// </summary>
        public void NewGame()
        {
            GetAllParameters();
            buttonStop.Enabled = true;
            buttonStart.Enabled = false;

            rows = pictureBoxDisplay.Height / resolution; 
            cols = pictureBoxDisplay.Width / resolution;
            cell = new bool[cols, rows];

            Random rand = new Random(); //Randomly filling the game screen with cells according to a given resolution.
            for (int x = 0; x < cols; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    cell[x, y] = rand.Next(density) == 0;
                }
            }

            pictureBoxDisplay.Image = new Bitmap(pictureBoxDisplay.Width, pictureBoxDisplay.Height);
            graphics = Graphics.FromImage(pictureBoxDisplay.Image);
            timerGame.Start();
        }

        /// <summary>
        /// Start game timer
        /// </summary>
        public void StopGame()
        {
            if (!timerGame.Enabled)
                return;
            timerGame.Stop();
            buttonStop.Enabled = false;
            buttonStart.Enabled = true;

        }

        /// <summary>
        /// stop game timer
        /// </summary>
        public void StartGame()
        {
            if (timerGame.Enabled)
                return;
            timerGame.Start();
            buttonStop.Enabled = true;
            buttonStart.Enabled = false;
        }

        /// <summary>
        /// Getting the parameters of the new generation.
        /// </summary>
        private void NextGeneration()
        {

            var newCell = new bool[cols, rows];

            graphics.Clear(Color.FromName(newColorDisplay));


            if (checkBoxImageCheckedFormSettings == true)
            {
                if (backgroundImagePath != "")
                {
                    graphics.Clear(Color.FromName(newColorDisplay));
                    graphics.DrawImageUnscaled(bitmap, 0, 0, pictureBoxDisplay.Width, pictureBoxDisplay.Height);
                }
                else
                    Properties.Settings.Default.checkBoxImageChecked = false;
            }

            for (int x = 0; x < cols; x++) //Creation of new cells according to the rules of the game.
            {
                for (int y = 0; y < rows; y++)
                {
                    int neighboursCount = CountNeighbours(x, y);
                    var hasLife = cell[x, y];
                    if (!hasLife && neighboursCount == 3)
                    {
                        newCell[x, y] = true;
                    }
                    else if (hasLife && (neighboursCount < 2 || neighboursCount > 3))
                    {
                        newCell[x, y] = false;
                    }
                    else
                    {
                        newCell[x, y] = cell[x, y];
                    }

                    Brush myBrush = new SolidBrush(Color.FromName(newColorElement)); //Setting cell colors.
                    if (hasLife)
                    {
                        graphics.FillRectangle(myBrush, x * resolution, y * resolution, resolution - 1, resolution - 1);
                    }
                }
            }
            cell = newCell;
            pictureBoxDisplay.Refresh(); //Game screen refreshing with new cell generation.
        }

        /// <summary>
        /// Finding the count of neighbors of each cell.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        private int CountNeighbours(int x, int y)
        {
            int count = 0;

            for (int i = -1; i < 2; i++)
            {
                for (int j = -1; j < 2; j++)
                {
                    int col = (x + i + cols) % cols;
                    int row = (y + j + rows) % rows;

                    bool selfChecking = col == x && row == y;
                    bool haslife = cell[col, row];

                    if (haslife && !selfChecking)
                        count++;

                }
            }
            return count;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            StartGame();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            StopGame();
        }

        private void timerGame_Tick(object sender, EventArgs e)
        {
            NextGeneration();
        }
       
      
        private void pictureBoxDisplay_MouseMove(object sender, MouseEventArgs e)
        {
            if (!timerGame.Enabled)
                return;
            
            if (e.Button == MouseButtons.Left) // Creating a new cell with the left mouse button.
            {
                int x = e.Location.X / resolution;
                int y = e.Location.Y / resolution;
                bool control = InvalidMousePosition(x, y);
                if (control)
                    cell[x, y] = true;
            }

            if (e.Button == MouseButtons.Right) // Deleting a cell with the right mouse button.
            {
                var x = e.Location.X / resolution;
                var y = e.Location.Y / resolution;
                var control = InvalidMousePosition(x, y);
                if (control)
                    cell[x, y] = false;
            }
        }

        private bool InvalidMousePosition(int x, int y) //Checking the edge of the screen as an invalid value to create a cell.
        {
            return x >= 0 && y >= 0 && x < cols && y < rows;
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            FormMenu formMenu = new FormMenu();
            formMenu.Show();
            this.Close();
        }

        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        /// <summary>
        /// Save a screenshot of the game screen on computer.
        /// </summary>
        public void SaveSnapshot()
        {
            if (!(pictureBoxDisplay.Image == null))
            {

                var saveFileDialog = new SaveFileDialog();
                saveFileDialog.FileName = "Nameless.png";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {

                    pictureBoxDisplay.Image.Save(saveFileDialog.FileName);
                }
            }
            else
            {
                MessageBox.Show("Game screen is clean. Please, start a new game!", 
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);   
            }
        }


        private void buttonHelp_Click(object sender, EventArgs e)
        {
            BoxWithMessage help = new BoxWithMessage();
            help.GetMessage("The universe of the game «Cell» is an infinite, " +
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
                "\n\nPlease, enjoy the game!", "Reference Information");
        }

        private void buttonSnapshot_Click(object sender, EventArgs e)
        {
            SaveSnapshot();
        }
    }
}

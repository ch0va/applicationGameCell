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

namespace Life.FRN
{
    public partial class FormGame : Form
    {
        public Bitmap bmp;
        string newColorDisplay;
        string newColorElement;
        private Graphics graphics;
        public int resolution;
        public int density;
        public bool[,] cell;
        public int rows;
        public int cols;
        public Image backgroundImage;
        public int back;

        public FormGame()
        {

            InitializeComponent();
        }

        public void GetParameters()
        {
            resolution = Properties.Settings.Default.resolution;

            density = Properties.Settings.Default.density;

            newColorDisplay = Properties.Settings.Default.colorDisplay;
            newColorDisplay = newColorDisplay.Trim();

            newColorElement = Properties.Settings.Default.colorElements;
            newColorElement = newColorElement.Trim();

            if (Properties.Settings.Default.checkBoxImageChecked == true)
            {
                if (Properties.Settings.Default.filePath != "")
                {
                    backgroundImage = Image.FromFile(Properties.Settings.Default.filePath);
                    bmp = new Bitmap(backgroundImage, pictureBoxDisplay.Width, pictureBoxDisplay.Height + 1);
                }
            }
        }

        public void NewGame()
        {
            GetParameters();
            buttonStop.Enabled = true;
            buttonStart.Enabled = false;

            rows = pictureBoxDisplay.Height / resolution;
            cols = pictureBoxDisplay.Width / resolution;
            cell = new bool[cols, rows];

            Random rand = new Random();
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
        public void StopGame()
        {
            if (!timerGame.Enabled)
                return;
            timerGame.Stop();
            buttonStop.Enabled = false;
            buttonStart.Enabled = true;

        }
        public void StartGame()
        {
            if (timerGame.Enabled)
                return;
            timerGame.Start();
            buttonStop.Enabled = true;
            buttonStart.Enabled = false;
        }

        private void NextGeneration(int back)
        {

            var newCell = new bool[cols, rows];

            graphics.Clear(Color.FromName(newColorDisplay));


            if (Properties.Settings.Default.checkBoxImageChecked == true)
            {
                if (Properties.Settings.Default.filePath != "")
                {
                    graphics.Clear(Color.FromName(newColorDisplay));
                    graphics.DrawImageUnscaled(bmp, 0, 0, pictureBoxDisplay.Width, pictureBoxDisplay.Height);
                }
            }

            for (int x = 0; x < cols; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    var neighboursCount = CountNeighbours(x, y);
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

                    Brush myBrush = new SolidBrush(Color.FromName(newColorElement));
                    if (hasLife)
                    {
                        graphics.FillRectangle(myBrush, x * resolution, y * resolution, resolution - 1, resolution - 1);
                    }
                }
            }
            cell = newCell;
            pictureBoxDisplay.Refresh();
        }
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
            NextGeneration(back);
        }

        private void pictureBoxDisplay_MouseMove(object sender, MouseEventArgs e)
        {
            if (!timerGame.Enabled)
                return;

            if (e.Button == MouseButtons.Left)
            {
                var x = e.Location.X / resolution;
                var y = e.Location.Y / resolution;
                var control = InvalidMousePosition(x, y);
                if (control)
                    cell[x, y] = true;
            }

            if (e.Button == MouseButtons.Right)
            {
                var x = e.Location.X / resolution;
                var y = e.Location.Y / resolution;
                var control = InvalidMousePosition(x, y);
                if (control)
                    cell[x, y] = false;
            }
        }

        private bool InvalidMousePosition(int x, int y)
        {
            return x >= 0 && y >= 0 && x < cols && y < rows;
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            FormMenu m = new FormMenu();
            m.Show();
            this.Close();
        }

        private void buttonNewGame_Click_1(object sender, EventArgs e)
        {
            NewGame();
        }

        public void SaveImage()
        {
            if (!(pictureBoxDisplay.Image == null))
            {

                var SFD = new SaveFileDialog();
                SFD.FileName = "Nameless.png";
                if (SFD.ShowDialog() == DialogResult.OK)
                {

                    pictureBoxDisplay.Image.Save(SFD.FileName);
                }
            }
            else
            {
                MessageBox.Show("Please, start a new game!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);   
            }
        }


        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveImage();
        }

       
    }
}

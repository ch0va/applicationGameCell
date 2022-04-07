using Life.FRN;
using Life.FRNS;
using System.Drawing;

namespace Life
{
    public class NewFormGame
    {
        /// <summary>
        /// Сreating a new FormGame.
        /// </summary>
        public void GetFormGame()
        {

            formGame formGame = new formGame();
            formGame.buttonStop.Enabled = false;
            formGame.buttonStart.Enabled = false;
            formGame.Show();

        }
    }

}



    




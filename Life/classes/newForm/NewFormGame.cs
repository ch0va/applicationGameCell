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

            FormGame formGame = new FormGame();
            formGame.buttonStop.Enabled = false;
            formGame.buttonStart.Enabled = false;
            formGame.Show();

        }
    }

}



    




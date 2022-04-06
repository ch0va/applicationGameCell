using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Life.classes.other
{
    class BoxWithMessage
    {       
        /// <summary>
        /// Creating a new MessageBox.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="nameBox"></param>
        public void GetMessage(string message, string nameBox)
        {
            MessageBox.Show(message, nameBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

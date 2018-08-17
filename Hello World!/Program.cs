using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Runtime.InteropServices;

//=========================================================================
// Hello World
// Author: Kathleen West
// Description: A very simple windows form that shows a button to click.
// The button will randomly move every time the user hovers the mouse over
// the button and giggle, but if the user skillfully clicks the button
// it will show a Message Box that says Hello World and then give the user
// an option to do a party where cats dance and music plays. 
//=========================================================================

namespace Hello_World_
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 form = new Form1();
            form.Size = new System.Drawing.Size(800, 400);
            Application.Run(form);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Runtime.InteropServices;
using System.IO;
using System.Diagnostics;

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
    public partial class Form1 : Form
    {

        Random rand;                         // Random number for direction
        Point point;                         // Point for Button
        SoundPlayer giggle, yahoo;             // Sounds
        DialogResult result;                 // User Choice for Message Box
        MessageBoxButtons buttons;           // MessageBox Buttons

        public Form1()
        {
            rand = new Random();
            point = new Point(0, 0);
            InitializeComponent();
            // Loads audio files into memory
            giggle = new SoundPlayer(Hello_World_.Properties.Resources.giggle);
            yahoo = new SoundPlayer(Hello_World_.Properties.Resources.yahoo);          
            pictureBox1.Hide(); // Hides the cat dancing GIF
        }

        // What happens when the user clicks the button
        private void button1_Click(object sender, EventArgs e)
        {
            // Plays a Short Awww
            yahoo.Play();

            // Dialog Message Box
            buttons = MessageBoxButtons.YesNo;
            MessageBox.Show("Hello World! --> Kathleen is Awesome!");
            result = MessageBox.Show("Do you want to PARTY?", "Party Time!", buttons);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                // Start a Party
                partyNow();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // What happens when the user hovers over the button
        private void button1_MouseHover(object sender, EventArgs e)
        {
            int quandrant = rand.Next(1, 5); // Random number to go 1 in 4 directions
            int X = 0;
            int Y = 0;
            int rate = 200;
            
            switch (quandrant)
            {
                case 1: // Go Diagonal Up Right
                    X = button1.Location.X + rate;
                    Y = button1.Location.Y - rate;
                    break;
                case 2: // Go Diagonal Up Left
                    X = button1.Location.X - rate;
                    Y = button1.Location.Y - rate;
                    break;
                case 3: // Go Diagnoal Down Right
                    X = button1.Location.X + rate;
                    Y = button1.Location.Y + rate;
                    break;
                case 4: // Go Diagnoal Down Left
                    X = button1.Location.X - rate;
                    Y = button1.Location.Y + rate;
                    break;
                default:
                    X = button1.Location.X;
                    Y = button1.Location.Y;
                    break;
            }

            // Edge Cases
            X = (X > 0) ? X : 0;
            X = (X < 800) ? X : 200;
            Y = (Y > 0) ? Y : 0;
            Y = (Y < 400) ? Y : 200;

            // Create a new point location
            point.X = X;
            point.Y = Y;

            // Set the button to the point location
            button1.Location = point;

            // Plays a Short Giggle
            giggle.Play();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        // Party Starts Here
        public void partyNow()
        {
  
            pictureBox1.Show();     // Shows the Cat dancing GIF
            button1.Hide();         // Hides the Button
        }
    }
   
}

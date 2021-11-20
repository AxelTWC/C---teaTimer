﻿/* teaTimerProgram 
   Name: Axel Tang
   Date: February 28
   Teacher: Mrs.Schilstra
   Purpose: Creating a Tea Timer Program
*/

 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;

namespace teaTimer
{

    public partial class Form1 : Form
    {
        int timeLeft; //Set a variable for time left 
        public Form1()
        {
            InitializeComponent();
            start2.Visible = false; 
            start3.Visible = false;
            start1.Visible = false;
            reset.Visible = false;
        }
        private void tea1_Click(object sender, EventArgs e) //A method for Black tea's icon 
        {
            temperature.Visible = true; //Shows temperature's text box
            temperature.Text = "Optimal Temperature: 85°C-100°C"; //Temperature's text box set
            intro.Text = "Click start to start timer\nClick reset to reset tea"; //set introduction's text
            intro.Location = new Point(254, 283); //shift the introduction's location to the middle of the form
            start1.Visible = true; //Shows the start and Reset button
            reset.Visible = true;
            tea2.Visible = false; //Make everything else invisible 
            tea3.Visible = false;
            teaLabel2.Visible = false;
            teaLabel3.Visible = false;
        }

        private void tea2_Click(object sender, EventArgs e) //A method for Green tea's icon 
        {
            temperature.Visible = true;
            temperature.Text = "Optimal Temperature: 70°C-85°C";
            intro.Text = "Click start to start timer\nClick reset to reset tea";
            intro.Location = new Point(254, 283);
            start2.Visible = true;
            reset.Visible = true;
            tea1.Visible = false;
            tea3.Visible = false;
            teaLabel1.Visible = false;
            teaLabel3.Visible = false;
            tea2.Location = new Point(12, 557); //Set icon's location to Black tea's position 
            teaLabel2.Location = new Point(58, 557);
        }

        private void tea3_Click(object sender, EventArgs e) //A method for White tea's icon 
        {
            temperature.Visible = true;
            temperature.Text = "Optimal Temperature: 70°C-80°C";
            intro.Text = "Click start to start timer\nClick reset to reset tea";
            intro.Location = new Point(254, 283);
            start3.Visible = true;
            reset.Visible = true;
            tea1.Visible = false;
            tea2.Visible = false;
            teaLabel1.Visible = false;
            teaLabel2.Visible = false;
            tea3.Location = new Point(12, 557);
            teaLabel3.Location = new Point(58, 557);
        }

        private void timer1_Tick(object sender, EventArgs e) //A method for timer
        {
            if (timeLeft > 0)
            {
                timeLabel.Visible = true;
                timeLeft = timeLeft - 1;
                timeLabel.Text = (timeLeft + " seconds");
            }
            else
            {
                timer1.Stop();
                System.Media.SystemSounds.Hand.Play(); //Plays a finish sound
                MessageBox.Show("You Tea is Ready!", "Finished"); //Shows MessageBox once timer is up
                tea1.Visible = true;
                tea2.Visible = true;
                tea3.Visible = true;
                teaLabel1.Visible = true;
                teaLabel2.Visible = true;
                teaLabel3.Visible = true;
                temperature.Visible = false;
                timeLabel.Visible = false;
                reset.Visible = false;
                sandTimer.Visible = false;
                intro.Visible = true;
                reset.Visible = false;
                start1.Visible = false;
                start2.Visible = false;
                start3.Visible = false;
                tea2.Location = new Point(279, 444);
                tea3.Location = new Point(539, 557);
                teaLabel2.Location = new Point(316, 444);
                teaLabel3.Location = new Point(576, 557);
                sandTimer.Visible = false;
                intro.Text = "Click the tea you want to brew"; //Set the intro back to the original text 
                intro.Location = new Point(218, 283); //Goes back to original place 
            }
        }

        private void start1_Click(object sender, EventArgs e) //When start button for Black Tea is clicked
        {
            click1(); 
        }
        public void click1() 
        {
            timeLabel.Visible = true; //Shows timeLabel
            timeLabel.Text = ("240 seconds"); 
            intro.Location = new Point(325, 617); //Set new location for intro label
            timeLeft = 240; //4 Mintues , Set time to 240 seconds
            timer1.Start(); //Starts the timer 
            intro.Text = "Brewing";
            start1.Visible = false; 
            reset.Visible = false;
            sandTimer.Visible = true;
        }

        private void start2_Click(object sender, EventArgs e) //When start button for Green Tea is clicked
        {
            click2();
        }
        public void click2()
        {
            timeLabel.Visible = true; //Shows timeLabel
            timeLabel.Text = ("180 seconds");
            intro.Location = new Point(325, 617); //Set new location for intro label
            timeLeft = 180; //3 Mintues, Set time to 180 seconds
            timer1.Start(); //Starts the timer 
            intro.Text = "Brewing";
            start2.Visible = false;
            reset.Visible = false;
            sandTimer.Visible = true;
        }

        private void start3_Click_1(object sender, EventArgs e) //When start button for White Tea is clicked
        {
            click3();
        }
        public void click3()
        {
            timeLabel.Visible = true; //Shows timeLabel
            timeLabel.Text = ("120 seconds");
            intro.Location = new Point(325, 617); //Set new location for intro label
            timeLeft = 120; //2 Mintues , Set time to 120 seconds
            timer1.Start();//Starts the timer
            intro.Text = "Brewing";
            start3.Visible = false;
            reset.Visible = false;
            sandTimer.Visible = true;
        }

        private void reset_Click(object sender, EventArgs e) //goto start does not apply here because its not a loop, therefore I manually disable and hide everything
        {
            resetChoice();
        }
        public void resetChoice()
        {
            temperature.Visible = false;
            tea1.Visible = true;
            tea2.Visible = true;
            tea3.Visible = true;
            teaLabel1.Visible = true;
            teaLabel2.Visible = true;
            teaLabel3.Visible = true;
            intro.Visible = true;
            reset.Visible = false;
            start1.Visible = false;
            start2.Visible = false;
            start3.Visible = false;
            tea2.Location = new Point(279, 444);
            tea3.Location = new Point(539, 557);
            teaLabel2.Location = new Point(316, 444);
            teaLabel3.Location = new Point(576, 557);
            sandTimer.Visible = false;


        }
    }
}

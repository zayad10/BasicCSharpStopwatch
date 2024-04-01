using System;
using System.Runtime.CompilerServices;

namespace C__Stopwatch
{
    public partial class Stopwatch : Form
    {
        private DateTime startTime;
        private DateTime stoppedTime;
        private TimeSpan stoppedTimeSpan;
        private bool currentlyStopped;
        private bool wasStopped;

        public Stopwatch()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            // Set a value with the time of which the start button was clicked.
            startTime = DateTime.Now;

            // Start the timer (ticks the formTimer_Tick every 10 ms)
            formTimer.Start();

            currentlyStopped = false;
        }

        private void timeLabel_Click(object sender, EventArgs e)
        {

        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            // Stop the timer
            formTimer.Stop();

            // Reset the Label
            timeLabel.Text = "00:00:00";

            wasStopped = false;
            currentlyStopped = false;
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            //currentlyStopped = true;
            if (!currentlyStopped)
            {
                currentlyStopped = true;
                if (wasStopped)
                {
                    stoppedTimeSpan += DateTime.Now - startTime;
                }
                else
                {
                    stoppedTimeSpan = DateTime.Now - startTime; // get the difference between the time now and the start time to save it that time elapsed.
                    wasStopped = true;
                }
            }
            
            
            formTimer.Stop();

        }

        private void formTimer_Tick(object sender, EventArgs e) //everytime the timer ticks (10ms), this function will fire. 
        {
            TimeSpan span = DateTime.Now - startTime;


            if (wasStopped)
            {
                span += stoppedTimeSpan;
            }

            timeLabel.Text = span.ToString(@"mm\:ss\:ff");
        }
    }
}

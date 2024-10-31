using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace To_Do_List_App
{
    public partial class frmPomodoroTimer : Form
    {
        private Timer timer;          // Timer for tracking time
        private int timeLeft;         // Time left in seconds
        private bool isWorking;       // Flag to check if it's a work session

        // Constants for work and rest durations
        private const int WorkDuration = 25 * 60; // 25 minutes in seconds
        private const int RestDuration = 5 * 60;  // 5 minutes in seconds
        public frmPomodoroTimer()
        {
            InitializeComponent();
           //Initialize Progress Bar
            pbTimer.Minimum = 0;
            pbTimer.Maximum = WorkDuration; // Set maximum to work duration
            pbTimer.Value = 0;               // Start at 0

            // Initialize Timer
            timer = new Timer();
            timer.Interval = 1000; // Set interval to 1 second
            timer.Tick += Timer_Tick; // Subscribe to Tick event

            isWorking = true; // Start with work session

        }
        private void frmPomodoroTimer_Load(object sender, EventArgs e)
        {

        }
        private void txtTask_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTask.Text))
                btnAddTask.Enabled = true;
        }

        private void txtTask_Click(object sender, EventArgs e)
        {
        }

      

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            lblAddTask.Visible = false;
            lblClarify.Visible = true;
            lblTaskDescription.Text = txtTask.Text;
            lblTaskDescription.Visible = true;
            txtTask.Visible = false;
            btnAddTask.Visible = false;
            btnTimer.Enabled = true;
            btnTimer.Visible = true;
        }

        private void btnTimer_Click(object sender, EventArgs e)
        {
            StartWorkSession();
            btnTimer.Enabled = false;
        }
        private void StartWorkSession()
        {
            timeLeft = WorkDuration; // Set time left to work duration
            pbTimer.Maximum = WorkDuration; // Set progress bar max
            pbTimer.Value = 0; // Reset progress bar
            lblTimer.Text = "25:00"; // Reset timer display
            timer.Start(); // Start the timer
            isWorking = true; // Set session type to working
            lblStatus.Text = "Working..."; // Update status
            pbTimer.ProgressColor = System.Drawing.Color.Red;
        }

        private void StartRestSession()
        {
            timeLeft = RestDuration; // Set time left to rest duration
            pbTimer.Maximum = RestDuration; // Set progress bar max for rest
            pbTimer.Value = 0; // Reset progress bar
            lblTimer.Text = "05:00"; // Reset timer display
            timer.Start(); // Start the timer
            isWorking = false; // Set session type to resting
            lblStatus.Text = "Resting..."; // Update status
            pbTimer.ProgressColor = System.Drawing.Color.Red;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft--; // Decrement time left
                pbTimer.Value++; // Increment progress bar value

                // Update the timer display
                lblTimer.Text = TimeSpan.FromSeconds(timeLeft).ToString(@"mm\:ss");
            }
            else
            {
                timer.Stop(); // Stop the timer when time is up
                pbTimer.ProgressColor = System.Drawing.Color.Green;
                btnTimer.Enabled = true;
                if (isWorking)
                {
                    // Notify user of end of work session
                    MessageBox.Show("Work session complete! Time to take a break.");
                    StartRestSession(); // Start the rest session
                }
                else
                {
                    // Notify user of end of rest session
                    MessageBox.Show("Rest session complete! Time to get back to work.");
                    btnTimer.Text = "Start New Section";
                }
            }
        }
    }
}

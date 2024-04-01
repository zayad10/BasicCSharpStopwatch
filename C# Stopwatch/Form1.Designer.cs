
namespace C__Stopwatch
{
    partial class Stopwatch
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            timeLabel = new Label();
            startButton = new Button();
            stopButton = new Button();
            resetButton = new Button();
            formTimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // timeLabel
            // 
            timeLabel.Font = new Font("Segoe UI", 100F);
            timeLabel.Location = new Point(12, 80);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(922, 234);
            timeLabel.TabIndex = 0;
            timeLabel.Text = "00:00:00";
            timeLabel.TextAlign = ContentAlignment.TopCenter;
            timeLabel.Click += timeLabel_Click;
            // 
            // startButton
            // 
            startButton.BackColor = Color.Gray;
            startButton.Font = new Font("Segoe UI", 35F, FontStyle.Bold);
            startButton.ForeColor = Color.Cornsilk;
            startButton.Location = new Point(355, 436);
            startButton.Name = "startButton";
            startButton.Size = new Size(223, 104);
            startButton.TabIndex = 1;
            startButton.Text = "START";
            startButton.UseVisualStyleBackColor = false;
            startButton.Click += startButton_Click;
            // 
            // stopButton
            // 
            stopButton.BackColor = Color.Red;
            stopButton.Font = new Font("Segoe UI", 35F, FontStyle.Bold);
            stopButton.ForeColor = Color.Cornsilk;
            stopButton.Location = new Point(212, 317);
            stopButton.Name = "stopButton";
            stopButton.Size = new Size(223, 99);
            stopButton.TabIndex = 2;
            stopButton.Text = "STOP";
            stopButton.UseVisualStyleBackColor = false;
            stopButton.Click += stopButton_Click;
            // 
            // resetButton
            // 
            resetButton.BackColor = Color.Black;
            resetButton.Font = new Font("Segoe UI", 35F, FontStyle.Bold);
            resetButton.ForeColor = Color.Cornsilk;
            resetButton.Location = new Point(496, 317);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(223, 99);
            resetButton.TabIndex = 3;
            resetButton.Text = "RESET";
            resetButton.UseVisualStyleBackColor = false;
            resetButton.Click += resetButton_Click;
            // 
            // formTimer
            // 
            formTimer.Interval = 10;
            formTimer.Tick += formTimer_Tick;
            // 
            // Stopwatch
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(946, 585);
            Controls.Add(resetButton);
            Controls.Add(stopButton);
            Controls.Add(startButton);
            Controls.Add(timeLabel);
            Name = "Stopwatch";
            Text = "Stopwatch";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label timeLabel;
        private Button startButton;
        private Button stopButton;
        private Button resetButton;
        private System.Windows.Forms.Timer formTimer;
    }
}

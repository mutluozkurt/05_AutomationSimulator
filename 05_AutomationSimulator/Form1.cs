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

namespace _05_AutomationSimulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private const int Step = 25;
        private Timer Timer;
        private double CurrentMotorSpeed = 0;
        private double CurrentWagonPosition = 0;
        static Stopwatch stopwatch = new Stopwatch();
        static double LastTime = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            Timer = new Timer();
            Timer.Interval = Step;
            Timer.Tick += Timer_Tick;

            CurrentWagonPosition = WagonPanel.Location.X;
            stopwatch.Start();

            Timer.Start();
        }

        private bool InInterval(double x, double min, double max)
        {
            return x >= min && x <= max;
        }

        private bool IsAbove(Control wagon, Control sensor)
            =>  InInterval(sensor.Left, wagon.Left, wagon.Right) ||
                InInterval(sensor.Right, wagon.Left, wagon.Right);

        private double Clamp(double x, double min, double max)
            => Math.Min(Math.Max(min, x), max);

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Update time
            double currentTime = stopwatch.ElapsedMilliseconds;
            double dt = (currentTime - LastTime) * 1e-3;
            LastTime = currentTime;

            // Read inputs
            Inputs inputs = new Inputs(
                sensorLeft: IsAbove(WagonPanel, IniLinksBox),
                sensorMiddle: IsAbove(WagonPanel, IniMitteBox),
                sensorRight: IsAbove(WagonPanel, IniRechtsBox),
                positioningEnabled: PositionEnabledCheckbox.Checked,
                currentTime: currentTime);

            // Update controller
            var outputs = Controller.Update(inputs);

            //======================================================================
            // Write outputs

            // Simulate motor acceleration
            double targetSpeed = 0;
            if (outputs.MoveLeft && (!outputs.MoveRight))
                targetSpeed = -outputs.MoveSpeed;
            else if (outputs.MoveRight && (!outputs.MoveLeft))
                targetSpeed = outputs.MoveSpeed;

            double targetDeltaV = targetSpeed - CurrentMotorSpeed;
            double maxDeltaV = Configuration.MotorAcceleration * dt;
            double deltaV = Math.Sign(targetDeltaV) * Math.Min(Math.Abs(targetDeltaV), maxDeltaV);
            CurrentMotorSpeed = CurrentMotorSpeed + deltaV;

            // Move wagon
            CurrentWagonPosition = CurrentWagonPosition + CurrentMotorSpeed * dt;
            WagonPanel.Location = new Point((int)CurrentWagonPosition, WagonPanel.Location.Y);

            // Show proximity sensors
            IniLinksBox.BackColor = inputs.ProximitySensorLeft ? Color.Green : Color.Black;
            IniMitteBox.BackColor = inputs.ProximitySensorMiddle ? Color.Green : Color.Black;
            IniRechtsBox.BackColor = inputs.ProximitySensorRight ? Color.Green : Color.Black;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_AutomationSimulator
{
    public struct Inputs
    {
        public Inputs( bool sensorLeft, bool sensorRight, bool sensorMiddle, bool positioningEnabled, double currentTime )
        {
            ProximitySensorLeft = sensorLeft;
            ProximitySensorMiddle = sensorMiddle;
            ProximitySensorRight = sensorRight;
            PositioningEnabled = positioningEnabled;
            CurrentTimeInMilliseconds = currentTime;
        }

        /// <summary>
        /// Gets the state of the left proximity sensor: True means triggered, false not.
        /// </summary>
        public bool ProximitySensorLeft { get; private set; }

        /// <summary>
        /// Gets the state of the right proximity sensor: True means triggered, false not.
        /// </summary>
        public bool ProximitySensorRight { get; private set; }

        /// <summary>
        /// Gets the state of the middle proximity sensor: True means triggered, false not.
        /// </summary>
        public bool ProximitySensorMiddle { get; private set; }

        /// <summary>
        /// Gets the state of the positioning enabled switch.
        /// </summary>
        public bool PositioningEnabled { get; private set; }

        /// <summary>
        /// Gets the time since the start of the simulation, in full and fractions of milliseconds.
        /// </summary>
        public double CurrentTimeInMilliseconds { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_AutomationSimulator
{
    public class Configuration
    {
        /// <summary>
        /// The desired motor speed for slow movement, in pixels / second.
        /// </summary>
        public const double MotorSpeedSlow = 25;

        /// <summary>
        /// The desired motor speed for fast movement, in pixels / second.
        /// </summary>
        public const double MotorSpeedFast = 100;

        /// <summary>
        /// The motor acceleration, in pixels / second².
        /// </summary>
        public const double MotorAcceleration = 200;
    }
}

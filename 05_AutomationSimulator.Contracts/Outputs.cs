using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_AutomationSimulator
{
    public struct Outputs
    {
        /// <summary>
        /// True if the wagon should move to the left, false otherwise.
        /// </summary>
        public bool MoveLeft { get; set; }

        /// <summary>
        /// True if the wagon should move to the right, false otherwise.
        /// </summary>
        public bool MoveRight { get; set; }

        /// <summary>
        /// The desired absolute speed for the wagon, in pixels per second.
        /// </summary>
        public double MoveSpeed { get; set; }
    }
}

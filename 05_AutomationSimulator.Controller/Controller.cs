using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_AutomationSimulator
{
    public class Controller
    {
        private enum Status
        {
            Left,
            Middle,
            Stop,
            Right,
        }

        private static Status curStatus = Status.Left;
        private static Double middleEndTime = 0, stopTime = 0, rightStopTime=0;

        public static Outputs Update(Inputs inputs)
        {
            Outputs outputs = new Outputs();

            if (inputs.PositioningEnabled)
            {
                if (!inputs.ProximitySensorMiddle && curStatus == Status.Middle && middleEndTime == 0)// Middle Sensor turn off time
                    middleEndTime = inputs.CurrentTimeInMilliseconds;

                if (inputs.ProximitySensorMiddle && curStatus==Status.Left)//Above Middle or Between Middle and Right
                {
                    curStatus = Status.Middle;
                }
                else if(inputs.ProximitySensorRight && curStatus == Status.Middle)// Stop Right
                {
                    curStatus = Status.Stop;
                    rightStopTime = inputs.CurrentTimeInMilliseconds;
                }
                else if (inputs.ProximitySensorRight && curStatus == Status.Stop)// Move Left
                {
                    curStatus = Status.Right;
                    Double rightTime = inputs.CurrentTimeInMilliseconds;
                    Double rightSensorWaitTime = ((inputs.CurrentTimeInMilliseconds - rightStopTime) * 1e-3);
                    stopTime = CalculateStopTime(rightTime, middleEndTime) + rightSensorWaitTime;
                }
                else if(curStatus == Status.Right && (inputs.CurrentTimeInMilliseconds * 1e-3) >= stopTime)// Stop Middle
                {
                    curStatus = Status.Stop;
                }

                outputs = GetStatus(outputs);
            }
            
            return (outputs);
        }


        private static Outputs GetStatus(Outputs outputs)
        {
            switch (curStatus)
            {
                case Status.Left:
                    outputs.MoveRight = true;
                    outputs.MoveSpeed = Configuration.MotorSpeedFast;
                    break;

                case Status.Middle:
                    outputs.MoveRight = true;
                    outputs.MoveSpeed = Configuration.MotorSpeedSlow;
                    break;

                case Status.Stop:
                    outputs.MoveRight = false;
                    outputs.MoveLeft = false;
                    outputs.MoveSpeed = 0;
                    break;

                case Status.Right:
                    outputs.MoveRight = false;
                    outputs.MoveLeft = true;
                    outputs.MoveSpeed = Configuration.MotorSpeedSlow;
                    break;
            }

            return outputs;
        }

        private static Double CalculateStopTime(Double _rightTime, Double _middleEndTime)
        {
            Double path = (((_rightTime - _middleEndTime) * 1e-3));
            Double stopTime = (_rightTime * 1e-3) + ((path / 2));
            return stopTime;
        }
    }
}

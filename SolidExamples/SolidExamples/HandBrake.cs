using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExamples
{
    abstract class HandBrake
    {
        private HandBrakeClient itsClient;
        public virtual bool GetState()
        {
            return true; //just to test
        }
        public void Detect()
        {
            bool isHold = GetState();
            if (isHold)
            {
                itsClient.TurnOn();
            }
            else
            {
                itsClient.TurnOff();
            }
        }
    }
}

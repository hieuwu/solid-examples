using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExamples
{
    class WrongBrake
    {
        private WrongBackLight itsBackLight;
        public bool GetCurrentState()
        {
            return true; //Just to test
        }
        public void Detect()
        {
            bool ishold = GetCurrentState();
            if (ishold)
            {
                itsBackLight.TurnOn();
            }
            else
            {
                itsBackLight.TurnOff();
            }
        }
    }
}

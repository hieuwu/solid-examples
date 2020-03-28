using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExamples
{
    abstract class HandBrakeClient
    {
        public abstract void TurnOn();
        public abstract void TurnOff();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExamples
{
    class Square:Rectangle
    {
        public override void SetHeight(int value)
        {
            base.SetHeight(value);
            Width = Height;
        }
        public override void SetWidth(int value)
        {
            base.SetWidth(value);
            Height = Width;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExamples
{
    class Rectangle
    {
        protected
        int Width;
        protected
        int Height;
        public
           virtual void SetWidth(int value)
        {
            Width = value;
        }
        public virtual void SetHeight(int value)
        {
            Height = value;
        }
    }
}

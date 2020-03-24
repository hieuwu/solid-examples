using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExamples
{
    //This locked block violate the ISP
    //class Dog : DogBehavior
    //{
    //   public void Bark() {
    //    }
    //    public void Eat() {
    //    }
    //    public void Sleep() { }
    //    public void Play() { }
    //    public void Sing() { }
    //}

    class HomeDog : DogInCircus
    {
        public void Play() { }
        public void Sing() { }
    }
}
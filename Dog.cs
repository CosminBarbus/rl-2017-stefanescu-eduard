using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session1
{
    class Dog : Animal
    {
        public override string Name()
        {
            return "Dog";
        }
        public override string Noise()
        {
            return "woof";
        }
    }
}

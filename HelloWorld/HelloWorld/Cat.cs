using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Cat : Animal
    {
        public override string Name()
        {
            return "Cat";
        }
        public override string Noise()
        {
            return "meow";
        }
    }
}

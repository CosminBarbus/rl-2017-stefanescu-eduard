using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session1
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

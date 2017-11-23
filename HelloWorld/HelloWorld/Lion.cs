using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Lion : Animal
    {
        public override string Name()
        {
            return "Lion";
        }
        public override string Noise()
        {
            return "roar";
        }
    }
}

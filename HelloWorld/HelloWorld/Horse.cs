using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Horse : Animal
    {
        public override string Name()
        {
            return "Horse";
        }
        public override string Noise()
        {
            return "neigh";
        }
    }
}

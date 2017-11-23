using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session1
{
    class Duck : Animal
    {
        public override string Name()
        {
            return "Duck";
        }
        public override string Noise()
        {
            return "quack";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_10_07_Animal_World
{
    internal class Bison : Herbivore
    {
        public Bison() { Weight = 400; }
        public override void EatGrass() { Weight += 10; Console.WriteLine("Bison eating grass()"); }
    }
}

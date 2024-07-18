using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_10_07_Animal_World
{
    internal class Wildebeest : Herbivore
    {
        public Wildebeest() { Weight = 150;  }
        public override void EatGrass() { Weight += 10; Console.WriteLine("Wildebeest eating grass()"); }
    }
}

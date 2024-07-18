using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace hw_10_07_Animal_World
{
    internal class Wolf : Carnivore
    {
        public Wolf() { Power =  135; }
        public override void Eat(Herbivore herbivore)
        {
            if(Power > herbivore.Weight)
            {
                Power += 10;
                herbivore.Life = false;
                Console.WriteLine($"Wolf eating {herbivore.GetType().Name}()");
            }
            else { Power -= 10; Console.WriteLine($"Wolf did not eat the {herbivore.GetType().Name}()"); }
        }
    }
}

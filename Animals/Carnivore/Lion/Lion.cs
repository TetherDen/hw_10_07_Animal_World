using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_10_07_Animal_World
{
    internal class Lion : Carnivore
    {
        public Lion() { Power = 175; }
        public override void Eat(Herbivore herbivore)
        {
            if( Power> herbivore.Weight)
            {
                Power += 10;
                herbivore.Life = false;
                Console.WriteLine($"Lion eating {herbivore.GetType().Name}()");
            }
            else { Power -= 10; Console.WriteLine($"Lion did not eat the {herbivore.GetType().Name}()"); }
        }
    }
}

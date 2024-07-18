using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_10_07_Animal_World
{
    internal abstract class Carnivore
    {
        public int Power { get; set; }
        protected abstract void Eat(Herbivore herbivore);
    }



}

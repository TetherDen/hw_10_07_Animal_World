using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static hw_10_07_Animal_World.Program;

namespace hw_10_07_Animal_World
{
    internal class AnimalWorld
    {
        private Herbivore _herbivore;
        private Carnivore _carnivore;
        public AnimalWorld(ContinentsFactory continent)
        {
            _herbivore = continent.CreateHerbivore();
            _carnivore = continent.CreateCarnivore();
        }
        public void MealsHerbivores()
        {
            _herbivore.EatGrass();
        }
        public void NutritionCarnivores()
        {
            _carnivore.Eat(_herbivore);
        }
    }
}

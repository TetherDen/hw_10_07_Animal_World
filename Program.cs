namespace hw_10_07_Animal_World
{
    internal class Program
    {
        //internal abstract class ContinentsFactory
        //{
        //    public abstract Herbivore CreateHerbivore();
        //    public abstract Carnivore CreateCarnivore();
        //}

        //internal  class NorthAmerica : ContinentsFactory
        //{
        //    public override Herbivore CreateHerbivore()
        //    {
        //        return new Bison();
        //    }
        //    public override Carnivore CreateCarnivore()
        //    {
        //        return new Wolf();
        //    }
        //}

        //internal class Africa : ContinentsFactory
        //{
        //    public override Herbivore CreateHerbivore()
        //    {
        //        return new Wildebeest();
        //    }
        //    public override Carnivore CreateCarnivore()
        //    {
        //        return new Lion();
        //    }
        //}

        //internal class AnimalWorld
        //{
        //    private Herbivore _herbivore;
        //    private Carnivore _carnivore;
        //    public AnimalWorld(ContinentsFactory continent)
        //    {
        //        _herbivore = continent.CreateHerbivore();
        //        _carnivore = continent.CreateCarnivore();
        //    }
        //    public void MealsHerbivores()
        //    {
        //        _herbivore.EatGrass();
        //    }
        //    public void NutritionCarnivores()
        //    {
        //        _carnivore.Eat(_herbivore);
        //    }
        //}


        static void Main(string[] args)
        {
            Console.WriteLine("NA: ");
            ContinentsFactory contFactory = new NorthAmerica();
            AnimalWorld AW = new AnimalWorld(contFactory);
            AW.MealsHerbivores();
            AW.NutritionCarnivores();

            Console.WriteLine("\nAfrica: ");
            contFactory = new Africa();
            AW = new AnimalWorld(contFactory);
            AW.MealsHerbivores();
            AW.NutritionCarnivores();
        }
    }
}

using System;

namespace lab2.NET
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal lion = new Lion(new PredatorNutrition(), new PredatorHabitation());
            lion.Food();
            lion.Action();
            Console.WriteLine();
            lion.nutrition = new HerbivoreNutrition();
            lion.Food();
            Console.WriteLine();

            Animal sheep = new Sheep(new HerbivoreNutrition(), new HerbivoreHabitation());
            sheep.Food();
            sheep.Action();

            Console.ReadLine();
        }
    }

}

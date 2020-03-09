using System;
using System.Collections.Generic;
using System.Text;

namespace lab2.NET
{
    //базовый интерфейс для реализации питани 
    interface INutrition
    {
        void GetFood();
        void Eat();
    }

    //базовый интерфейс для реализации проживания
    interface IHabitation
    {
        void Sleep();
        void Walk();
    }

    //конкретная реализация питания хищника, которая унаследована от INutrition
    class PredatorNutrition : INutrition
    {
        public void Eat()
        {
            Console.WriteLine("eating another animal...");
        }

        public void GetFood()
        {
            Console.WriteLine("hunting herbivore animal...");
        }
    }

    //конкретная реализация способа проживания хищника, которая унаследована от INutrition
    class PredatorHabitation : IHabitation
    {
        public void Sleep()
        {
            Console.WriteLine("sleeping with predator flock...");
        }

        public void Walk()
        {
            Console.WriteLine("proudly walking around with flock...");
        }
    }

    //конкретная реализация питания травоядного, которая унаследована от INutrition
    class HerbivoreNutrition : INutrition
    {
        public void Eat()
        {
            Console.WriteLine("eating some grass...");
        }

        public void GetFood()
        {
            Console.WriteLine("trying to find some lawn...");
        }
    }

    //конкретная реализация способа проживания травоядного, которая унаследована от INutrition
    class HerbivoreHabitation : IHabitation
    {
        public void Sleep()
        {
            Console.WriteLine("peacefully sleeping with herd...");
        }

        public void Walk()
        {
            Console.WriteLine("quietly walking around with herd...");
        }
    }
}

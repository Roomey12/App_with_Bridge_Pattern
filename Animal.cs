using System;
using System.Collections.Generic;
using System.Text;

namespace lab2.NET
{
    //определяет базовый интерфейс и хранит ссылкы на объекты INutrition, IHabitation
    //Выполнение операций в Animal делегируется методами объектов INutrition, IHabitation
    abstract class Animal
    {
        public INutrition nutrition;
        public IHabitation habitation;

        public Animal(INutrition nutr, IHabitation habit)
        {
            nutrition = nutr;
            habitation = habit;
        }

        public virtual void Food()
        {
            Console.Write(GetType().Name + " is ");
            nutrition.GetFood();
            Console.Write(GetType().Name + " is ");
            nutrition.Eat();
        }

        public virtual void Action()
        {
            Console.Write(GetType().Name + " is ");
            habitation.Walk();
            Console.Write(GetType().Name + " is ");
            habitation.Sleep();
        }
    }

    //уточненная абстракция, наследуется от Animal и расширяет унаследованный интерфейс
    class Lion : Animal
    {
        public Lion(INutrition nutr, IHabitation habit) :
            base(nutr, habit)
        {

        }
    }

    //уточненная абстракция, наследуется от Animal и расширяет унаследованный интерфейс
    class Sheep : Animal
    {
        public Sheep(INutrition nutr, IHabitation habit) :
            base(nutr, habit)
        {

        }
    }
}

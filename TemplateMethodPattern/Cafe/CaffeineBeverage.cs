using System;

namespace Cafe
{
    public abstract class CaffeineBeverage
    {
        public void PrepareRecipe()
        {
            BoilWater();
            Brew();
            PourInCup();
            if (CustomerWantsCondiments())
            {
                AddCondiments();
            }
        }

        public abstract void Brew();
        public abstract void AddCondiments();

        public void BoilWater()
        {
            Console.Write("Boiling water.\n");
        }

        public void PourInCup()
        {
            Console.Write("Pouring in cup.\n\n");
        }

        public bool CustomerWantsCondiments()
        {
            char input = GetUserInput();

            switch (input)
            {
                case 'y':
                    return true;
                case 'n':
                    return false;
                default:
                    return false;
            }
        }

        public virtual char GetUserInput()
        {
            return 'n';
        }
    }
}
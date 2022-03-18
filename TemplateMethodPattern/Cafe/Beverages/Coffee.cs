using System;

namespace Cafe
{
    public class Coffee : CaffeineBeverage
    {
        public override void Brew()
        {
            Console.Write("Dripping coffee through filter.\n");
        }

        public override void AddCondiments()
        {
            if (CustomerWantsCondiments())
            {
                Console.Write("*drops sugar and milk into coffee*\n");
            }
        }

        public override char GetUserInput()
        {
            while (true)
            {
                Console.Write("Would you like to add cream and sugar to your coffee? (y/n)\n");

                char input = Console.ReadKey(true).KeyChar;

                switch (input)
                {
                    case 'y':
                        return 'y';
                    case 'n':
                        return 'n';
                }

                Console.Write("I didn't quite catch that.\n");
            }
        }
    }
}
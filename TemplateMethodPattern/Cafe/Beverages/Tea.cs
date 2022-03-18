using System;

namespace Cafe
{
    public class Tea : CaffeineBeverage
    {
        public override void Brew()
        {
            Console.Write("Steeping the Tea.\n");
        }

        public override void AddCondiments()
        {
            if (CustomerWantsCondiments())
            {
                Console.Write("*Squeezes lemon into tea*");
            }
        }

        public override char GetUserInput()
        {
            while (true)
            {
                Console.Write("Would you like to add lemon to your tea? (y/n)\n");

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
using System;
using Driver;

namespace Cafe
{
    class Program
    {
        public static void Main(string[] args)
        {
            Tea tea = new Tea();
            Coffee coffee = new Coffee();

            while (true)
            {
                Console.Write("1 to order coffee.\n2 to order tea.\n3 to leave the machine.\n\n");
                char input = Console.ReadKey(true).KeyChar;

                switch (input)
                {
                    case '1':
                        coffee.PrepareRecipe();
                        Console.Write("\nHere is your coffee.\n\n");
                        break;
                    case '2':
                        tea.PrepareRecipe();
                        Console.Write("\nHere is your tea.\n\n");
                        break;
                    case '3':
                        Driver.DriverHelper.ExitToDriver();
                        return;
                }
            }
        }
    }
}

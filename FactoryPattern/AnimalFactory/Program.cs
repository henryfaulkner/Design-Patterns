using System;
using Driver;

namespace AnimalFactory
{
    class Program
    {
        public static void Main(string[] args)
        {
            bool gameLoop = true;

            while (gameLoop)
            {
                Console.Write("1 pokes a human.\n2 pokes a monkey.\n3 pokes a pig.\n4 leaves the zoo.\n\n");
                var response = StringExtensions.ConvertIntToStringResponse(Console.ReadLine());
                if (response == string.Empty) Console.Write("Invalid input.\n");
                else if (response == "exit")
                {
                    Driver.DriverHelper.ExitToDriver();
                }
                else
                {
                    var animal = AnimalFactory.CreateAnimal(response);
                    Console.Write(animal.Speak());
                }
            }
        }
    }
}

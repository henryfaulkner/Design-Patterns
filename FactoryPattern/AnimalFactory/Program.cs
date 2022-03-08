using System;

namespace AnimalFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var mainInstance = new Program();

            while (true)
            {
                Console.Write("1 pokes a human.\n2 pokes a monkey.\n3 pokes a pig.\n4 leaves the zoo.\n");
                var response = StringExtensions.ConvertIntToStringResponse(Console.ReadLine());
                if (response == string.Empty) Console.WriteLine("Invalid input.");
                else if (response == "exit") break;
                else
                {
                    var animal = AnimalFactory.CreateAnimal(response);
                    Console.WriteLine(animal.Speak());
                }
            }
        }
    }
}

using System;

namespace Driver
{
    class Program
    {
        static void Main(string[] args)
        {
            bool gameLoop = true;

            Console.WriteLine("1 to visit the zoo.\n2 to go to the liquor vending machine.\n3 to leave the park.\n\n");
            var input = Console.ReadLine();

            // while (gameLoop)
            // {
            switch (input)
            {
                case "1":
                    DriverHelper.RunDLL(Constants.Projects.AnimalFactory.path,
                        Constants.Projects.AnimalFactory.nameSpace);
                    break;
                case "2":
                    DriverHelper.RunDLL(Constants.Projects.SimpleShooterVendingMachine.path,
                        Constants.Projects.SimpleShooterVendingMachine.nameSpace);
                    break;
                case "3":
                    gameLoop = !gameLoop;
                    break;
            }
            //}
        }
    }
}

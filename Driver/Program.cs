using System;

namespace Driver
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("1 to visit the zoo.\n2 to visit the chocolate boiler.\n3 to visit the liquor vending machine.\n4 to monitor all liquor vending machines.\n5 to visit the robot.\n6 to visit the Cafe.\n7 to leave the park.\n\n");
            var input = Console.ReadKey(true).KeyChar;

            switch (input)
            {
                case '1':
                    DriverHelper.RunDLL(Constants.Projects.AnimalFactory.path,
                        Constants.Projects.AnimalFactory.nameSpace);
                    break;
                case '2':
                    DriverHelper.RunDLL(Constants.Projects.ChocolateBoiler.path,
                        Constants.Projects.ChocolateBoiler.nameSpace);
                    break;
                case '3':
                    DriverHelper.RunDLL(Constants.Projects.SimpleShooterVendingMachine.path,
                        Constants.Projects.SimpleShooterVendingMachine.nameSpace);
                    break;
                case '4':
                    DriverHelper.RunDLL(Constants.Projects.VendingMachineMonitorClient.path,
                        Constants.Projects.VendingMachineMonitorClient.nameSpace);
                    break;
                case '5':
                    DriverHelper.RunDLL(Constants.Projects.Robot.path,
                        Constants.Projects.Robot.nameSpace);
                    break;
                case '6':
                    DriverHelper.RunDLL(Constants.Projects.Cafe.path,
                        Constants.Projects.Cafe.nameSpace);
                    break;
                case '7':
                    Environment.Exit(0);
                    break;
            }
        }
    }
}

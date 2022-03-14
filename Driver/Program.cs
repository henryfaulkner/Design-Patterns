﻿using System;

namespace Driver
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("1 to visit the zoo.\n2 to visit the liquor vending machine.\n3 to monitor all liquor vending machines.\n4 to leave the park.\n\n");
            var input = Console.ReadKey(true).KeyChar;

            switch (input)
            {
                case '1':
                    DriverHelper.RunDLL(Constants.Projects.AnimalFactory.path,
                        Constants.Projects.AnimalFactory.nameSpace);
                    break;
                case '2':
                    DriverHelper.RunDLL(Constants.Projects.SimpleShooterVendingMachine.path,
                        Constants.Projects.SimpleShooterVendingMachine.nameSpace);
                    break;
                case '3':
                    DriverHelper.RunDLL(Constants.Projects.VendingMachineMonitorClient.path,
                        Constants.Projects.VendingMachineMonitorClient.nameSpace);
                    break;
                case '4':
                    Environment.Exit(0);
                    break;
            }
        }
    }
}

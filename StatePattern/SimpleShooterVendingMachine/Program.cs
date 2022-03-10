using System;
using Driver;

namespace SimpleShooterVendingMachine
{
    class Program
    {
        public static void Main(string[] args)
        {
            bool gameLoop = true;
            VendingMachine vm = new VendingMachine(10);

            while (vm.GetState() != vm.GetSOLD_OUT() && gameLoop)
            {
                Console.Write("1 to insert dollar.\n2 to press button.\n3 to eject your dollar.\n4 to leave the machine.\n\n");
                char input = Console.ReadKey(true).KeyChar;

                switch (input)
                {
                    case '1':
                        vm.InsertDollar();
                        break;
                    case '2':
                        vm.PressButton();
                        break;
                    case '3':
                        vm.EjectDollar();
                        break;
                    case '4':
                        gameLoop = !gameLoop;
                        Driver.DriverHelper.ExitToDriver();
                        break;
                }
            }
        }
    }
}

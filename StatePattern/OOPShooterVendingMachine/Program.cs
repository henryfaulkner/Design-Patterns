using System;
using Driver;

namespace OOPShooterVendingMachine
{
    class Program
    {
        public static void Main(string[] args)
        {
            bool gameLoop = true;
            ShooterMachine sm = new ShooterMachine(10);

            while (sm.state != sm.soldOutState && gameLoop)
            {
                Console.Write("1 to insert dollar.\n2 to press button.\n3 to eject your dollar.\n4 to leave the machine.\n\n");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        sm.InsertDollar();
                        break;
                    case "2":
                        sm.PressButton();
                        break;
                    case "3":
                        sm.EjectDollar();
                        break;
                    case "4":
                        gameLoop = !gameLoop;
                        Driver.DriverHelper.ExitToDriver();
                        break;
                }
            }
        }
    }
}

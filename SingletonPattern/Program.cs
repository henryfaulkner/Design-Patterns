using System;
using Driver;

namespace SingletonPattern
{
    class Program
    {
        public static void Main(string[] args)
        {
            var cb = ChocolateBoiler.GetInstance();

            while (true)
            {
                Console.Write("1 to fill chocolate boiler.\n2 to boil chocolate.\n3 to empty chocolate boiler.\n4 to leave the machine.\n\n");
                char input = Console.ReadKey(true).KeyChar;

                switch (input)
                {
                    case '1':
                        cb.Fill();
                        break;
                    case '2':
                        cb.Boil();
                        break;
                    case '3':
                        cb.Drain();
                        break;
                    case '4':
                        Driver.DriverHelper.ExitToDriver();
                        return;
                }
            }
        }
    }
}

using System;

namespace SimpleShooterVendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            VendingMachine vm = new VendingMachine(10);

            while (vm.GetState() != vm.GetSOLD_OUT())
            {
                Console.Write("1 to insert dollar.\n2 to press button.\n3 to eject your dollar.\n");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        vm.InsertDollar();
                        break;
                    case "2":
                        vm.PressButton();
                        break;
                    case "3":
                        vm.EjectDollar();
                        break;
                }
            }
        }
    }
}

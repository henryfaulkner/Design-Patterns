using System;
using System.Runtime.CompilerServices;

namespace SingletonPattern
{
    public class ChocolateBoiler
    {
        /*
            The volatile keyword ensures that multiple threads 
            handle the uniqueInstance variable correctly when 
            it is being initialized to the Singleton instance.
        */
        private volatile static ChocolateBoiler uniqueInstance;
        private bool empty;
        private bool boiled;

        private ChocolateBoiler()
        {
            empty = true;
            boiled = false;
        }

        /*
            By adding the synchronized keyword to getInstance(), 
            we force every thread to wait its turn before it can 
            enter the method. That is, no two threads may enter 
            the method at the same time.
        */
        [MethodImpl(MethodImplOptions.Synchronized)]
        public static ChocolateBoiler GetInstance()
        {
            if (uniqueInstance == null) uniqueInstance = new ChocolateBoiler();
            return uniqueInstance;
        }

        public void Fill()
        {
            if (IsEmpty())
            {
                empty = false;
                boiled = false;
                Console.Write("Chocolate boiler successfully filled with milk and chocolate.\n\n");
            }
            else if (IsBoiled())
            {
                Console.Write("Chocolate is already full and boiled.\n\n");
            }
            else if (!IsEmpty())
            {
                Console.Write("The boiler is full.\n\n");
            }
        }
        public void Drain()
        {
            if (!IsEmpty() && IsBoiled())
            {
                // drain the boiled milk and chocolate
                empty = true;
                Console.Write("Chocolate boiler was successfully drained.\n\n");
            }
            else if (IsEmpty())
            {
                Console.Write("The chocolate boiler is already empty.\n\n");
            }
            else if (!IsBoiled())
            {
                Console.Write("Chocolate is not yet boiled.\n\n");
            }
        }
        public void Boil()
        {
            if (!IsEmpty() && !IsBoiled())
            {
                Console.Write("Chocolate boiler was successfully brought to a boil.\n\n");
                boiled = true;
            }
            else if (IsEmpty())
            {
                Console.Write("The chocolate boiler is empty.\n\n");
            }
            else if (IsBoiled())
            {
                Console.Write("Chocolate is already boiled.\n\n");
            }
        }
        private bool IsEmpty()
        {
            return empty;
        }
        private bool IsBoiled()
        {
            return boiled;
        }
    }
}
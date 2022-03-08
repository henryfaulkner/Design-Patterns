using System;
using System.IO;

namespace SimpleShooterVendingMachine
{
    public class VendingMachine
    {
        /*
        *   Wisedom Nugget:
        *   A static variable means that the object's lifetime is the 
        *   entire execution of the program and it's value is initialized 
        *   only once before the program startup.
        */
        static int NO_DOLLAR = 0;
        static int HAS_DOLLAR = 1;
        const int SELL = 2;
        const int SOLD_OUT = 3;

        int state = SOLD_OUT;
        int count = 0;

        public VendingMachine(int count)
        {
            this.count = count;
            if (count > 0)
            {
                this.state = NO_DOLLAR;
            }
        }

        public void InsertDollar()
        {
            if (this.state == NO_DOLLAR)
            {
                Console.WriteLine("Your dollar slides into the machine.\n");
                this.state = HAS_DOLLAR;
            }
            else if (this.state == HAS_DOLLAR)
            {
                Console.WriteLine("Machine has a dollar already.\n");
            }
            else if (this.state == SELL)
            {

            }
            else if (this.state == SOLD_OUT)
            {

            }
        }

        public void EjectDollar()
        {
            if (this.state == NO_DOLLAR)
            {
                Console.WriteLine("You haven't inserted a dollar.\n");
            }
            else if (this.state == HAS_DOLLAR)
            {
                Console.WriteLine("You recieve your dollar back.\n");
                this.state = NO_DOLLAR;
            }
            else if (this.state == SELL)
            {

            }
            else if (this.state == SOLD_OUT)
            {

            }
        }

        public void PressButton()
        {
            if (this.state == NO_DOLLAR)
            {
                Console.WriteLine("You haven't inserted a dollar.\n");
            }
            else if (this.state == HAS_DOLLAR)
            {
                this.state = SELL;
                DispenseLiquor();
            }
            else if (this.state == SELL)
            {

            }
            else if (this.state == SOLD_OUT)
            {
                Console.WriteLine("No more liquor in the machine.\n");
            }
        }

        public void DispenseLiquor()
        {
            if (this.state == NO_DOLLAR)
            {

            }
            else if (this.state == HAS_DOLLAR)
            {

            }
            else if (this.state == SELL)
            {
                this.count = this.count - 1;
                string selectedLiquor = RandomizeLiquorSelection();
                Console.WriteLine($"You got {selectedLiquor}.\n");
                if (this.count == 0)
                {
                    this.state = SOLD_OUT;
                }
                else
                {
                    this.state = NO_DOLLAR;
                }
            }
            else if (this.state == SOLD_OUT)
            {

            }
        }

        public string RandomizeLiquorSelection()
        {
            // HARDCODED TRASH
            string[] liquorSelection = File.ReadAllLines("StatePattern/SimpleShooterVendingMachine/LiquorSelection.txt");

            Random randObj = new Random();

            return liquorSelection[randObj.Next(liquorSelection.Length)];
        }

        public int GetSOLD_OUT()
        {
            return SOLD_OUT;
        }

        public int GetState()
        {
            return this.state;
        }
    }
}
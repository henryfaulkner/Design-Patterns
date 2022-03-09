using System;
using System.IO;

namespace OOPShooterVendingMachine
{
    public class SellState : IState
    {
        ShooterMachine shooterMachine;

        public SellState(ShooterMachine shooterMachine)
        {
            this.shooterMachine = shooterMachine;
        }

        public void InsertDollar()
        {

        }

        public void EjectDollar()
        {

        }

        public void PressButton()
        {

        }

        public void DispenseLiquor()
        {
            shooterMachine.count = shooterMachine.count - 1;
            string selectedLiquor = RandomizeLiquorSelection();
            Console.WriteLine($"You got {selectedLiquor}.\n");
            if (shooterMachine.count == 0)
            {
                shooterMachine.state = shooterMachine.soldOutState;
            }
            else
            {
                shooterMachine.state = shooterMachine.noDollarState;
            }
        }

        public string RandomizeLiquorSelection()
        {
            // HARDCODED TRASH
            string[] liquorSelection = File.ReadAllLines("StatePattern/SimpleShooterVendingMachine/LiquorSelection.txt");

            Random randObj = new Random();

            return liquorSelection[randObj.Next(liquorSelection.Length)];
        }
    }
}
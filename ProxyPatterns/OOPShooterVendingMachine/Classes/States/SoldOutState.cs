using System;

namespace OOPShooterVendingMachine
{
    public class SoldOutState : IState
    {
        ShooterMachine shooterMachine;

        public SoldOutState(ShooterMachine shooterMachine)
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
            Console.WriteLine("No more liquor in the machine.\n");
        }

        public void DispenseLiquor()
        {

        }
    }
}
using System;

namespace OOPShooterVendingMachine
{
    public class HasDollarState : IState
    {
        ShooterMachine shooterMachine;

        public HasDollarState(ShooterMachine shooterMachine)
        {
            this.shooterMachine = shooterMachine;
        }

        public void InsertDollar()
        {
            Console.WriteLine("Machine has a dollar already.\n");
        }

        public void EjectDollar()
        {
            Console.WriteLine("You recieve your dollar back.\n");
            shooterMachine.state = shooterMachine.noDollarState;
        }

        public void PressButton()
        {
            shooterMachine.state = shooterMachine.sellState;
        }

        public void DispenseLiquor()
        {

        }
    }
}
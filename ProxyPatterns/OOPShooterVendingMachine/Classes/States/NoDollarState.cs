using System;

namespace OOPShooterVendingMachine
{
    public class NoDollarState : IState
    {
        ShooterMachine shooterMachine;

        public NoDollarState(ShooterMachine shooterMachine)
        {
            this.shooterMachine = shooterMachine;
        }

        public void InsertDollar()
        {
            Console.WriteLine("Your dollar slides into the machine.\n");
            shooterMachine.state = shooterMachine.hasDollarState;
        }

        public void EjectDollar()
        {
            Console.WriteLine("You haven't inserted a dollar.\n");
        }

        public void PressButton()
        {
            Console.WriteLine("You haven't inserted a dollar.\n");
        }

        public void DispenseLiquor()
        {

        }
    }
}
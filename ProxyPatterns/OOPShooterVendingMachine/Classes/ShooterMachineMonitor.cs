using System;

namespace OOPShooterVendingMachine
{
    public class ShooterMachineMonitor
    {
        ShooterMachine shooterMachine;

        public ShooterMachineMonitor(ShooterMachine shooterMachine)
        {
            this.shooterMachine = shooterMachine;
        }

        public void report()
        {
            Console.WriteLine($"Shooter Machine: {shooterMachine.location}.");
            Console.WriteLine($"Current Inventory: {shooterMachine.count} shooters.");
            Console.WriteLine($"Current State: {shooterMachine.state}");
        }
    }
}
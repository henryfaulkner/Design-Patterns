namespace Driver
{
    public struct Constants
    {
        public struct Projects
        {
            public struct Driver
            {
                public static string path => "Driver/bin/Debug/netcoreapp3.1/Driver.dll";
                public static string nameSpace => "Driver";
            }

            public struct AnimalFactory
            {
                public static string path => "FactoryPattern/AnimalFactory/bin/Debug/netcoreapp3.1/AnimalFactory.dll";
                public static string nameSpace => "AnimalFactory";
            }

            public struct SimpleShooterVendingMachine
            {
                public static string path => "StatePattern/SimpleShooterVendingMachine/bin/Debug/netcoreapp3.1/SimpleShooterVendingMachine.dll";
                public static string nameSpace => "SimpleShooterVendingMachine";
            }

            public struct VendingMachineMonitorClient
            {
                public static string path => "ProxyPatterns/OOPShooterVendingMachine/bin/Debug/netcoreapp3.1/OOPShooterVendingMachine.dll";
                public static string nameSpace => "OOPShooterVendingMachine";
            }

            public struct ChocolateBoiler
            {
                public static string path => "SingletonPattern/bin/Debug/netcoreapp3.1/SingletonPattern.dll";
                public static string nameSpace => "SingletonPattern";
            }
        }
    }
}
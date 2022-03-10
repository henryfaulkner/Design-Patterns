using System;
using System.Threading.Tasks;
using Grpc.Net.Client;
using System.Runtime.InteropServices;
using Driver;

namespace OOPShooterVendingMachine
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            //bool gameLoop = true;
            int count = 100;
            string location = "Atlanta";

            // if (args.Length != 2)
            // {
            //     Console.WriteLine("Gumballs <location> <inventory>");
            //     Environment.Exit(1);
            // }

            // location = args[0];
            // count = int.Parse(args[1]);

            ShooterMachine sm = new ShooterMachine(count, location);

            var serverAddress = "https://localhost:5001";

            if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
                // The following statement allows you to call insecure services. To be used only in development environments.
                AppContext.SetSwitch(
                    "System.Net.Http.SocketsHttpHandler.Http2UnencryptedSupport", true);
                serverAddress = "http://localhost:5000";
            }

            // The port number must match the port of the gRPC server.
            var channel = GrpcChannel.ForAddress(serverAddress);
            var client = new Greeter.GreeterClient(channel);
            var reply = await client.SayHelloAsync(
                              new HelloRequest { Name = "OOPShooterVendingMachine" });
            Console.WriteLine("Greeting: " + reply.Message);
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();

            // while (sm.state != sm.soldOutState && gameLoop)
            // {
            //     Console.Write("1 to insert dollar.\n2 to press button.\n3 to eject your dollar.\n4 to leave the machine.\n\n");
            //     string input = Console.ReadLine();

            //     switch (input)
            //     {
            //         case "1":
            //             sm.InsertDollar();
            //             break;
            //         case "2":
            //             sm.PressButton();
            //             break;
            //         case "3":
            //             sm.EjectDollar();
            //             break;
            //         case "4":
            //             gameLoop = !gameLoop;
            //             Driver.DriverHelper.ExitToDriver();
            //             break;
            //     }
            // }
        }
    }
}

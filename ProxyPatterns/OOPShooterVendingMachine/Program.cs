using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using Grpc.Net.Client;
using System.Runtime.InteropServices;
using Driver;

namespace OOPShooterVendingMachine
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                while (true)
                {
                    Tasking().Wait();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static async Task Tasking()
        {
            var location = TakeInput();

            var serverAddress = "https://localhost:5001";

            if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
                // The following statement allows you to call insecure services. To be used only in development environments.
                AppContext.SetSwitch(
                    "System.Net.Http.SocketsHttpHandler.Http2UnencryptedSupport", true);
                serverAddress = "http://localhost:5000";
            }

            try
            {
                // The port number must match the port of the gRPC server.
                var channel = GrpcChannel.ForAddress(serverAddress);
                var client = new Greeter.GreeterClient(channel);
                var reply = await client.SayHelloAsync(
                                  new HelloRequest { Location = location });
                Console.WriteLine($"{location} machine:");
                Console.WriteLine($"Shooters Available: {reply.ShootersAvailable}");
                Console.WriteLine($"Shooters Sold: {reply.ShootersSold}");
                Console.WriteLine($"Favorite Shooter: {reply.FavoriteShooter}\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static string TakeInput()
        {
            string location = "";
            var locationList = new List<string>() { "Atlanta", "Denver", "Miami" };
            var requestStatement = "Pick a location to monitor:\n";

            for (int i = 0; i <= locationList.Count; i++)
            {
                if (i == locationList.Count)
                {
                    requestStatement = $"{requestStatement}4 to leave the machine.\n\n";
                }
                else
                {
                    requestStatement = $"{requestStatement}Press {i + 1} for {locationList[i]}\n";
                }
            }

            Console.Write(requestStatement);
            char input = Console.ReadKey(true).KeyChar;

            while (!Char.IsNumber(input))
            {
                Console.Write("Please type a number.\n\n");
                input = Console.ReadKey(true).KeyChar;
            }

            var numInput = int.Parse(input.ToString());

            if (0 < numInput && numInput <= locationList.Count)
            {
                location = locationList[numInput - 1];
            }
            else
            {
                Driver.DriverHelper.ExitToDriver();
            }

            return location;
        }
    }
}

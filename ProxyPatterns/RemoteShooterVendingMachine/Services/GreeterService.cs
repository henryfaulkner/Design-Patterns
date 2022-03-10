using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Core;
using Microsoft.Extensions.Logging;

namespace RemoteShooterVendingMachine
{
    public class GreeterService : Greeter.GreeterBase
    {
        private readonly ILogger<GreeterService> _logger;
        public GreeterService(ILogger<GreeterService> logger)
        {
            _logger = logger;
        }

        public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
        {
            Console.Write($"{request.Location} machine hit.\n");

            var reportDict = FileHelper.ParseFileForKeyValuePairs(request.Location);

            return Task.FromResult(new HelloReply
            {
                ShootersAvailable = reportDict["ShootersAvailable"],
                ShootersSold = reportDict["ShootersSold"],
                FavoriteShooter = reportDict["FavoriteShooter"],
            });
        }
    }
}

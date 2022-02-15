using Grpc.Net.Client;
using GrpcServiceACCAMD;
using System;

namespace GrpcClientACCAMD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var channel = GrpcChannel.ForAddress(" https://localhost:7134");
            GrpcPersonService.GrpcPersonServiceClient client = new GrpcPersonService.GrpcPersonServiceClient(channel);
            var result = client.GetPerson(new StatusPersonRequest { Id = 2 });

            Console.WriteLine($"{ result.FirstName } { result.LastName }");

            Console.ReadKey();

        }
    }
}

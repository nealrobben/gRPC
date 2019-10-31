using Grpc.Net.Client;
using System;
using GrpcGreeter;
using System.Threading.Tasks;

namespace GrpcGreeterClient
{
    public static class Program
    {
        public static async Task Main(string[] args)
        {
            var channel = GrpcChannel.ForAddress("https://localhost:5001");

            var client = new MyGreeter.MyGreeterClient(channel);

            var reply = await client.SayHelloAsync(new MyHelloRequest { Name = "NealRobben" });

            Console.WriteLine($"Message: {reply.Message}");

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}

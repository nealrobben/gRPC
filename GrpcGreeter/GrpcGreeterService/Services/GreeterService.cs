using System.Threading.Tasks;
using Grpc.Core;
using Microsoft.Extensions.Logging;

namespace GrpcGreeter
{
    public class GreeterService : MyGreeter.MyGreeterBase
    {
        private readonly ILogger<GreeterService> _logger;

        public GreeterService(ILogger<GreeterService> logger)
        {
            _logger = logger;
        }

        public override Task<MyHelloReply> SayHello(MyHelloRequest request, ServerCallContext context)
        {
            return Task.FromResult(new MyHelloReply
            {
                Message = "Hello " + request.Name
            });
        }
    }
}

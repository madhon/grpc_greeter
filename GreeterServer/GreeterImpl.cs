namespace GreeterServer
{
    using System;
    using System.Threading.Tasks;
    using Greeter;
    using Grpc.Core;

    public class GreeterImpl : Greeter.GreeterBase
    {
        public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
        {
            return Task.FromResult(new HelloReply { Message = "Hello " + request.Name });
        }
    }
}
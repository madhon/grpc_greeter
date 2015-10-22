namespace GreeterServer
{
  using System.Threading.Tasks;
  using Greeter;
  using Grpc.Core;

  public class GreeterImpl : Greeter.IGreeter
  {
    // Server side handler of the SayHello RPC
    public Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
    {
      return Task.FromResult(new HelloReply { Message = "Hello " + request.Name });
    }
  }
}
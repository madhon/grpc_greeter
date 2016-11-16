namespace GreeterClient
{
    using System;
    using System.Threading.Tasks;
    using Greeter;
    using Grpc.Core;

    public class ClientMainClass
    {
        public static void Main() => MainAsync().GetAwaiter().GetResult();

        public static async Task MainAsync()
        {
            var channel = new Channel("127.0.0.1:50051", ChannelCredentials.Insecure);

            var client = new Greeter.GreeterClient(channel);

            var user = Environment.UserName;

            var reply = client.SayHello(new HelloRequest { Name = user });
            Console.WriteLine("Greeting: {0}", reply.Message);

            await channel.ShutdownAsync().ConfigureAwait(false);

            Console.ReadLine();
        }
    }
}
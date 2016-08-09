namespace GreeterClient
{
    using System;
    using Greeter;
    using Grpc.Core;

    public class ClientMainClass
    {
        public static void Main(string[] args)
        {
            var channel = new Channel("127.0.0.1:50051", ChannelCredentials.Insecure);

            var client = new Greeter.GreeterClient(channel);

            string user = Environment.UserName;

            var reply = client.SayHello(new HelloRequest { Name = user });
            Console.WriteLine("Greeting: {0}", reply.Message);

            channel.ShutdownAsync().Wait();
        }
    }
}
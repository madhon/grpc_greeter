namespace GreeterServer
{
    using System;
    using Greeter;
    using Grpc.Core;

    public class ServerMainClass
    {
        private const string Host = "0.0.0.0";
        private const int Port = 50051;

        public static void Main(string[] args)
        {
            Server server = new Server
            {
                Services = { Greeter.BindService(new GreeterImpl()) },
                Ports = { new ServerPort(Host, Port, ServerCredentials.Insecure) }
            };

            server.Start();

            Console.WriteLine("Greeter server listening on port {0}", Port.ToString());
            Console.WriteLine("Press any key to stop the server...");
            Console.ReadKey();

            server.ShutdownAsync().Wait();
        }
    }
}
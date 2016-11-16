namespace GreeterServer
{
    using System;
    using System.Threading.Tasks;
    using Greeter;
    using Grpc.Core;

    public class ServerMainClass
    {
        private const string Host = "0.0.0.0";
        private const int Port = 50051;

        public static void Main() => MainAsync().GetAwaiter().GetResult();

        public static async Task MainAsync()
        {
            var server = new Server
            {
                Services = { Greeter.BindService(new GreeterImpl()) },
                Ports = { new ServerPort(Host, Port, ServerCredentials.Insecure) }
            };

            server.Start();

            Console.Out.WriteLine("Greeter server listening on port {0}", Port.ToString());
            Console.Out.WriteLine("Press any key to stop the server...");
            Console.ReadKey();

            await server.ShutdownAsync().ConfigureAwait(false);
        }
    }
}
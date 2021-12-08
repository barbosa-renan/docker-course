using System;

namespace ConsoleDockerDefinitivo
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = Environment.GetEnvironmentVariable("user");
            var password = Environment.GetEnvironmentVariable("password");

            var debug = Environment.GetEnvironmentVariable("debug");

            if (!string.IsNullOrWhiteSpace(debug))
            {

                Console.WriteLine($"ConnectionString {user}:{password}");

                Console.WriteLine(Environment.MachineName);
                Console.WriteLine(Environment.OSVersion);
            }

            Console.WriteLine("Hello World!");
        }
    }
}

using System;
using System.Net;
using static System.Console;
using System.Net.NetworkInformation;

namespace WorkingWithNetworkResources
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Enter a valid web address: ");
            string url = ReadLine();

            if (string.IsNullOrWhiteSpace(url))
            {
                url = "https://github.com";
            }

            var uri = new Uri(url);

            WriteLine($"URL: {url}");
            WriteLine($"Scheme: {uri.Scheme}");
            WriteLine($"Port: {uri.Port}");
            WriteLine($"Host: {uri.Host}");
            WriteLine($"Path: {uri.AbsolutePath}");
            WriteLine($"Query: {uri.Query}");

            // Get website IP address

            IPHostEntry entry = Dns.GetHostEntry(uri.Host);
            WriteLine($"{entry.HostName} has the following IP addresses: ");
            foreach (IPAddress address in entry.AddressList)
            {
                WriteLine($"{address}");
            }

            // Pinging a server to check its health
            try
            {
                var ping = new Ping();
                WriteLine("Pinging server please wait..");
                PingReply reply = ping.Send(uri.Host);

                WriteLine($"{uri.Host} was pinged and replied: {reply.Status}");

                if (reply.Status == IPStatus.Success)
                {
                    WriteLine($"Reply from {0} took {1:N0}ms", reply.Address, reply.RoundtripTime);
                }
            } 
            catch (Exception ex)
            {
                WriteLine($"{ex.GetType()} says {ex.Message}");
            }
        }
    }
}

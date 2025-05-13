using System;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;

namespace MyApp
{
    internal class Program
    {
        class Server
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Serveur Listener is running");
                TcpListener server = new TcpListener(IPAddress.Parse("127.0.0.1"), 80);
                server.Start();
                Console.WriteLine("Server has started on 127.0.0.1:80{0}Waiting for a connection", Environment.NewLine);
                TcpClient client = server.AcceptTcpClient();
                Console.WriteLine("A client connected");
                NetworkStream stream = client.GetStream();

                //enter to an infinite cycle to be handle every change in stream
                while (true)
                {
                    Console.WriteLine("not data here");
                    while (!stream.DataAvailable)
                    {
                        byte[] bytes = new byte[client.Available];
                        stream.Read(bytes, 0, bytes.Length);

                    }
                }
            }
        }
        
    }
}
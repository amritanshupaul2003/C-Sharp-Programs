using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace NetworkingLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            UdpClient server = new UdpClient(5001);
            Console.WriteLine("UDP server started on port 5001...");

            IPEndPoint remote = new IPEndPoint(IPAddress.Any, 0);
            byte[] data = server.Receive(ref remote);
            string message = Encoding.ASCII.GetString(data);

            Console.WriteLine("Received: " + message);
            server.Close();
        }
    }
}

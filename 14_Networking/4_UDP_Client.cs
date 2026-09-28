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
            UdpClient client = new UdpClient();
            client.Connect("127.0.0.1", 5001);

            string message = "Hello UDP";
            byte[] data = Encoding.ASCII.GetBytes(message);
            client.Send(data, data.Length);

            Console.WriteLine("UDP message sent: " + message);
            client.Close();
        }
    }
}

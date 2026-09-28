using System;
using System.Net.Sockets;
using System.Text;

namespace NetworkingLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                TcpClient client = new TcpClient("127.0.0.1", 5000);
                Console.WriteLine("Connected to server.");

                NetworkStream stream = client.GetStream();

                string message = "Hello from client";
                byte[] data = Encoding.ASCII.GetBytes(message);
                stream.Write(data, 0, data.Length);

                Console.WriteLine("Sent: " + message);

                byte[] buffer = new byte[256];
                int bytesRead = stream.Read(buffer, 0, buffer.Length);
                string response = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                Console.WriteLine("Server response: " + response);

                client.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Client error: " + ex.Message);
            }
        }
    }
}

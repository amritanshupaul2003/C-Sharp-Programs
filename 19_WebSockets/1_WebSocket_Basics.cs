using System;
using System.Net.WebSockets;
using System.Text;
using System.Threading;

namespace WebSocketLearn
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("WebSockets allow full-duplex communication over a single connection.");
            Console.WriteLine("They are useful for chat apps, live dashboards, and notifications.");

            // This is conceptual code to explain the idea.
            using var ws = new ClientWebSocket();
            await ws.ConnectAsync(new Uri("ws://localhost:8080"), CancellationToken.None);
            Console.WriteLine("Connected to WebSocket server.");

            var message = Encoding.UTF8.GetBytes("Hello WebSocket");
            await ws.SendAsync(new ArraySegment<byte>(message), WebSocketMessageType.Text, true, CancellationToken.None);
            Console.WriteLine("Message sent.");
        }
    }
}

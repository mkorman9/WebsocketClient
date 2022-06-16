using System;
using System.Net.WebSockets;
using System.Threading;

namespace WebsocketClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var resetEvent = new ManualResetEvent(false);

            var uri = new Uri("ws://127.0.0.1:8080/api/v1/client/events");
            var factory = new Func<ClientWebSocket>(() =>
                {
                    var socket = new ClientWebSocket();
                    socket.Options.SetRequestHeader("Authorization", "Bearer XXX");
                    return socket;
                }
            );

            using (var client = new Websocket.Client.WebsocketClient(uri, factory))
            {
                client.MessageReceived.Subscribe(msg =>
                    Console.WriteLine($"{msg}")
                );
                client.Start();

                resetEvent.WaitOne();
            }
        }
    }
}

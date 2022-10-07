using Owin.WebSocket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace OwsDemo
{
    public class MyWebSocket : WebSocketConnection
    {
        public override Task OnMessageReceived(ArraySegment<byte> message, WebSocketMessageType type)
        {
            //Handle the message from the client

            //Example of JSON serialization with the client
            //var json = Encoding.UTF8.GetString(message.Array, message.Offset, message.Count);
            //Use something like Json.Net to read the json
            return Task.CompletedTask;
        }
    }
}

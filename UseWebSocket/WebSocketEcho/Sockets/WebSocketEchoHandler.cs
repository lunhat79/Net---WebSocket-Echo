using Microsoft.Web.WebSockets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebSocketEcho
{
    public class WebSocketEchoHandler : WebSocketHandler
    {
        private static WebSocketCollection socketClients = new WebSocketCollection();
        
        public override void OnOpen()
        {
            socketClients.Add(this);
            this.Send("Hello from server.");
        }
        public override void OnMessage(string message)
        {
            socketClients.Broadcast(string.Format("{0}", message));
        }
        public override void OnClose()
        {
            base.OnClose();
        }

        public override void OnError()
        {
            base.OnError();
        }

    }
}

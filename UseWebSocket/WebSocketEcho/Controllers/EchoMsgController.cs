using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using Microsoft.Web.WebSockets;


namespace WebSocketEcho.Controllers
{
    public class EchoMsgController : ApiController
    {
        // GET api/values
        public HttpResponseMessage Get()
        {
            if (HttpContext.Current.IsWebSocketRequest)
            {
                HttpContext.Current.AcceptWebSocketRequest(new WebSocketEchoHandler());
            }

            return new HttpResponseMessage(HttpStatusCode.SwitchingProtocols);

        }
    }

       
    
}

# Net --- WebSocket 

For implement realtime web application, we mostly think about websocket. Let exam the websocket.

To implement websocket we can use [Microsoft.WebSockets](https://www.nuget.org/packages/Microsoft.WebSockets/)
or [SignalR](https://www.nuget.org/packages/Microsoft.AspNet.SignalR/)

We are suggested to use SignalR. We can think SignalR is superset of Microsoft.WebSocket.
And SignalR also support for browser those do not have websocket client.

## Project: UseWebSocket
- Use microsoft websocket, implement as a API. 
- I use inline ReactJS as client. 
- Need websocket supported browser like chrome to run.

##Project : UseSignalR


using Owin;
using Owin.WebSocket.Extensions;
namespace OwsDemo
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapWebSocketRoute<MyWebSocket>();
            app.Run(context =>
            {
                context.Response.ContentType = "text/plain";
                return context.Response.WriteAsync("Hello World!");
            });
        }
    }
}

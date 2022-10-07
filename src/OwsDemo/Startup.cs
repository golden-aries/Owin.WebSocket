using Owin;
using Owin.WebSocket.Extensions;
using Microsoft.Owin;
namespace OwsDemo
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //app.UseDefaultFiles("/");
            app.MapWebSocketRoute<MyWebSocket>("/ws");
            app.Run(context =>
            {
                context.Response.ContentType = "text/plain";
                return context.Response.WriteAsync("Hello World!");
            });
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace ConfiguringApps.Infrastructure
{
    public class ErrorMidldeware
    {
        private RequestDelegate nextDelegate;

        public ErrorMidldeware(RequestDelegate next) => nextDelegate = next;

        public async Task Invoke(HttpContext httpContext)
        {
            await nextDelegate.Invoke(httpContext);

            if (httpContext.Response.StatusCode == 403)
            {
                await httpContext.Response
                    .WriteAsync("Microsoft Edge is not supported", Encoding.UTF8);

            }
            else if(httpContext.Response.StatusCode == 404)
            {
                await httpContext.Response
                    .WriteAsync("No content", Encoding.UTF8);
            }
        }

    }
}

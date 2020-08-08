using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Filters.Infrastructure
{
    public class TimeFilter : IAsyncActionFilter, IAsyncResultFilter
    {
        private Stopwatch timer;
        private IFilterDiagnostics diagnostic;

        public TimeFilter(IFilterDiagnostics diags)
        {
            diagnostic = diags;
        }

        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            timer = Stopwatch.StartNew();
            await next();
            diagnostic.AddMessage($@"Action filter elapsed time: {timer.Elapsed.TotalMilliseconds}");
        }

        public async Task OnResultExecutionAsync(ResultExecutingContext context, ResultExecutionDelegate next)
        {
            await next();
            timer.Stop();
            diagnostic.AddMessage($@"Result filter elapsed time: {timer.Elapsed.TotalMilliseconds}");
        }
    }
}

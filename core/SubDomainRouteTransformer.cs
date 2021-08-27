using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Routing;

namespace subdomain_routing.core {
    public class SubDomainRouteTransformer : DynamicRouteValueTransformer
    {
        public override ValueTask<RouteValueDictionary> TransformAsync(HttpContext httpContext, RouteValueDictionary values)
        {
            var subdomain = httpContext.Request.Host.Host.Split(".").First();
            Console.WriteLine(subdomain);

            if (!string.IsNullOrEmpty(subdomain)) {
                values["controller"] = subdomain;
            }
            Console.WriteLine("here");
            return ValueTask.FromResult(values);
        }
    }
}
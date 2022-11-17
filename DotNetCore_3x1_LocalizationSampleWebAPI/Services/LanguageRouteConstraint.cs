﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace DotNetCore_3x1_LocalizationSampleWebAPI.Services
{
    public class LanguageRouteConstraint : IRouteConstraint
    {
        public bool Match(HttpContext httpContext, IRouter route, string routeKey, RouteValueDictionary values, RouteDirection routeDirection)
        {

            if (!values.ContainsKey("culture"))
                return false;

            var culture = values["culture"].ToString();
            return culture == "en-US" || culture == "my-MM";            
        }
    }
}

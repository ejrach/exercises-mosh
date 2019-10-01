﻿using System.Web;
using System.Web.Mvc;

namespace Vidly
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            //This filter redirects the user to an error page when an action throws an exception.
            //This handles "exceptions" only, not "404 errors" which are handled by IIS
            filters.Add(new HandleErrorAttribute());

            //This filter restricts the user access to any page on the site if they are anonymous
            //Then add [AllowAnonymous] to controller code where you 'would' want anonymous access.
            filters.Add(new AuthorizeAttribute());

            //With this filter, the application will no longer be available on Http channel.
            filters.Add(new RequireHttpsAttribute());
        }
    }
}

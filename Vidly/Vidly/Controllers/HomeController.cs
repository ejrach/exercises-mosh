using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI;
using System.Web.Mvc;

namespace Vidly.Controllers
{
    [AllowAnonymous]    //Allow access to this page. Authorization
    public class HomeController : Controller
    {
        //This enable caching for the rendered html view so that. "Decorating" the action. 
        //Stores the cached version of the page on the server for 50 seconds.
        //The VaryByParam can be included to vary the caching based on the parameter of the function.
        //[OutputCache(Duration = 50, Location = OutputCacheLocation.Server, VaryByParam = "*")]   
        //This disables caching
        [OutputCache(Duration = 0, VaryByParam = "*", NoStore = true)]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            throw new Exception();

            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
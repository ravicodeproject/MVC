using System;
using System.Web.Mvc;

namespace web.Controllers
{
    
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //throw exception for demo
            throw new Exception("This is unhandled exception");
            return View();
        }

        [HandleError]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            //throw exception for demo
            throw new Exception("This is unhandled exception");

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        protected override void OnException(ExceptionContext filterContext)
        {
            Exception ex = filterContext.Exception;
            filterContext.ExceptionHandled = true;

            var model = new HandleErrorInfo(filterContext.Exception, "Controller", "Action");

            filterContext.Result = new ViewResult()
            {
                ViewName = "Error1",
                ViewData = new ViewDataDictionary(model)
            };

        }

    }
}
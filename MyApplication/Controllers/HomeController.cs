using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyApplication.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public string Index()
        {
            return "Hi from default index action method";
        }
        public string AnotherIndex()
        {
            return "Hello from another index action method";
        }
    }
}
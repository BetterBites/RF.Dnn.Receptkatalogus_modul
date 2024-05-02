using BetterBites.DnnRF.Dnn.Receptkatalogus.Components;
using DotNetNuke.Web.Mvc.Framework.ActionFilters;
using DotNetNuke.Web.Mvc.Framework.Controllers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace BetterBites.DnnRF.Dnn.Receptkatalogus.Controllers
{
    [DnnHandleError]
    public class HomeController : DnnController
    {
        [ModuleAction]
        public ActionResult Index()
        {
            String path = Server.MapPath("~/Kepek/");
            String[] kepekfajlok=Directory.GetFiles(path);
            ViewBag.images=kepekfajlok;
            return View();

        }
    }
}

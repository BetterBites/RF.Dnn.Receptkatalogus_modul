using BetterBites.DnnRF.Dnn.Receptkatalogus.Components;
using BetterBites.DnnRF.Dnn.Receptkatalogus.Models;
using DotNetNuke.Entities.Users;
using DotNetNuke.Framework.JavaScriptLibraries;
using DotNetNuke.Web.Mvc.Framework.ActionFilters;
using DotNetNuke.Web.Mvc.Framework.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace BetterBites.DnnRF.Dnn.Receptkatalogus.Controllers
{

    [DnnHandleError]
    public class ReceptekController: DnnController
    {

        //[ModuleAction]
        //public ActionResult Index()
        //{
        //    var items = ReceptekManager.Instance.GetReceptek();
        //    return View(items);

        //}
        //[ModuleAction]
        //public ActionResult Index()
        //{
        //    var hozzavalok = HotCakesManager.Instance.ReadHotCakes();
        //    return View(hozzavalok);

        //}

        [ModuleAction]
        public ActionResult Index()
        {
            var items = ReceptekManager.Instance.GetReceptek();
            var products = HotCakesManager.Instance.ReadHotCakes();
            var hozzavalok = ReceptekxProductsManager.Instance.GetReceptekxProducts();

            ViewBag.receptek = items;
            ViewBag.products = products;
            ViewBag.hozzavalok = hozzavalok;


            return View(items);

        }



    }
}

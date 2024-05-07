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
        //[HttpPost]
        //public void Edit(Receptek recept)
        //{
        //    var existingItem = ReceptekManager.Instance.GetItems(recept.receptId);
        //    existingItem.receptId = item.CurrencyValue;
        //    existingItem.CurrencyName = item.CurrencyName;
        //    existingItem.LongCurrencyName = item.LongCurrencyName;
        //    existingItem.IsActive = item.IsActive;

        //    ReceptekManager.Instance.UpdateItem(existingItem);
        //}



        [ModuleAction]
        public ActionResult Index()
        {
            var items = ReceptekManager.Instance.GetReceptek();
            return View(items);

        }

    }
}

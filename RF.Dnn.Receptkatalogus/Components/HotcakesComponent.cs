﻿using BetterBites.DnnRF.Dnn.Receptkatalogus.Models;
using DotNetNuke.Data;
using DotNetNuke.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetterBites.DnnRF.Dnn.Receptkatalogus.Components
{
    internal interface IHotCakesManager
    {
        IEnumerable<HotCakes> ReadHotCakes();
        IEnumerable<HotCakes> SearchSKU(string SKU);

        HotCakes GetBybvin(string bvin);

    }

    internal class HotCakesManager : ServiceLocator<IHotCakesManager, HotCakesManager>, IHotCakesManager
    {
        public IEnumerable<HotCakes> ReadHotCakes()
        {
            /// READ HOTCAKES PRODUCTS!!!!

            IEnumerable<HotCakes> products;
            using (IDataContext ctx = DataContext.Instance())
            {
                var rep = ctx.GetRepository<HotCakes>();
                products = rep.Get();
            }

            return products;
        }

        public IEnumerable<HotCakes> SearchSKU(string SKU)
        {
            IEnumerable<HotCakes> product;
            using (IDataContext ctx = DataContext.Instance())
            {
                var rep = ctx.GetRepository<HotCakes>();
                product = rep.Find("WHERE SKU = @0", SKU);
            }
            return product;
        }

        public HotCakes GetBybvin(string bvin)
        {
            HotCakes product;
            using (IDataContext ctx = DataContext.Instance())
            {
                var rep = ctx.GetRepository<HotCakes>();
                product = rep.GetById(bvin);
            }
            return product;
        }



        protected override System.Func<IHotCakesManager> GetFactory()
        {
            return () => new HotCakesManager();
        }

    }
}

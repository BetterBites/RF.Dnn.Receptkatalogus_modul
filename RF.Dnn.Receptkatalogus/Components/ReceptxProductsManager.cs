using BetterBites.DnnRF.Dnn.Receptkatalogus.Models;
using DotNetNuke.Data;
using DotNetNuke.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetterBites.DnnRF.Dnn.Receptkatalogus.Components
{
    internal interface IReceptekxProductsManager
    {
        IEnumerable<ReceptekxProducts> GetReceptekxProducts();

    }
    internal class ReceptekxProductsManager : ServiceLocator<IReceptekxProductsManager, ReceptekxProductsManager>, IReceptekxProductsManager
    {

        public IEnumerable<ReceptekxProducts> GetReceptekxProducts()
        {
            IEnumerable<ReceptekxProducts> r;
            using (IDataContext ctx = DataContext.Instance())
            {
                var rep = ctx.GetRepository<ReceptekxProducts>();
                r = rep.Get();
            }
            return r;
        }

        protected override System.Func<IReceptekxProductsManager> GetFactory()
        {
            return () => new ReceptekxProductsManager();
        }
    }
}

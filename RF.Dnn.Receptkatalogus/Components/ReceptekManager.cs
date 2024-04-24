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
    internal interface IReceptekManager
    {
        //void CreateReceptek(Receptek r);
        //void DeleteReceptek(int receptId);
        //void DeleteReceptek(Receptek r);
        IEnumerable<Receptek> GetReceptek();
        //Receptek GetRecept();
        //void UpdateReceptek(Receptek r);
    }

    internal class ReceptekManager : ServiceLocator<IReceptekManager, ReceptekManager>, IReceptekManager
    {

        public IEnumerable<Receptek> GetReceptek()
        {
            IEnumerable<Receptek> r;
            using (IDataContext ctx = DataContext.Instance())
            {
                var rep = ctx.GetRepository<Receptek>();
                r = rep.Get();
            }
            return r;
        }

        //public Receptek GetRecept()
        //{
        //    Receptek r;
        //    using (IDataContext ctx = DataContext.Instance())
        //    {
        //        var rep = ctx.GetRepository<Receptek>();
        //        r = rep.GetById();
        //    }
        //    return r;
        //}

        //public void UpdateItem(Item t)
        //{
        //    using (IDataContext ctx = DataContext.Instance())
        //    {
        //        var rep = ctx.GetRepository<Item>();
        //        rep.Update(t);
        //    }
        //}

        protected override System.Func<IReceptekManager> GetFactory()
        {
            return () => new ReceptekManager();
        }
    }
}

using DotNetNuke.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Caching;

namespace BetterBites.DnnRF.Dnn.Receptkatalogus.Models
{
    [TableName("ReceptekxProducts")]
    [PrimaryKey("id")]
    [Cacheable("ReceptekxProducts", CacheItemPriority.Default, 20)]
    [Scope("ModuleId")]

    public class ReceptekxProducts
    {
        public int id { get; set; }

        public int receptId { get; set; }

        public string productBvin { get; set; }

        public string hozzavalonev { get; set; }

        public int kosarba { get; set; }

        public int mennyi { get; set; }

        public string mennyiseg { get; set; }

    }
}

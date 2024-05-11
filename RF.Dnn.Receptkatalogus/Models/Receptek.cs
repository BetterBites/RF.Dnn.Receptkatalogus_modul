using DotNetNuke.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Caching;
using System.Diagnostics;


namespace BetterBites.DnnRF.Dnn.Receptkatalogus.Models
{
    [TableName("receptek")]
    [PrimaryKey("receptId")]
    [Cacheable("receptek", CacheItemPriority.Default, 20)]
    [Scope("ModuleId")]

    public class Receptek
    {
        public int receptId { get; set; }

        public string nev { get; set; }

        public int ido { get; set; }

        public int adag { get; set; }

        public string leiras { get; set; }

        public bool glutenmentes { get; set; }

        public bool cukormentes { get; set; }

        public bool vegan { get; set; }

        public bool reggeli { get; set; }

        public bool ebed { get; set; }

        public bool vacsora { get; set; }

        public bool laktozmentes { get; set; }

        public string kepnev { get; set; }

    }
}

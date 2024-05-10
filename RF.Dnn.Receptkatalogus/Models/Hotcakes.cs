using DotNetNuke.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Caching;

namespace BetterBites.DnnRF.Dnn.Receptkatalogus.Models
{
    [TableName("hcc_Product")]
    //setup the primary key for table
    [PrimaryKey("bvin")]
    //configure caching using PetaPoco
    [Cacheable("HotCakes", CacheItemPriority.Default, 20)]
    //scope the objects to the ModuleId of a module on a page (or copy of a module on a page)
    [Scope("ModuleId")]
    public class HotCakes
    {
        ///<summary>
        /// The ID of your object with the name of the ItemName
        ///</summary>
        public string bvin { get; set; }


        //public string Name { get; set; }

        public string SKU { get; set; }

        /// <summary>
        /// The name of the image file
        /// </summary>
        public string ImageFileSmall { get; set; }


    }
}

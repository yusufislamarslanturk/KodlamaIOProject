using Entitties.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constans
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
       
        internal static string ProductsListed="Ürünler listelendi";
        internal static string MaintenanceTime="Sistem bakımda";

        public static string ProductDeleted = "Ürün Silindi";

        public static string CategoryLimitExceded { get; internal set; }
    }
}

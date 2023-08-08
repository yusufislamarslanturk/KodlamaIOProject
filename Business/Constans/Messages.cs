using Core.Entities.Concrete;
using Entitties.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
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

        public static string CategoryLimitExceded = "aştın";
        public static string AuthorizationDenied = "Yetkiniz yok";

        public static string UserRegistered = "kullanıcı kaydoldu";
        public static string UserNotFound = "kullanıcı bulunamadı";
        public static string PasswordError = "parola hatalı";
        public static string SuccessfulLogin = "doğru giris";
        public static string UserAlreadyExists = "kullanıcı zaten var";
        public static string AccessTokenCreated = "token olusturuldu.";

        public static string UserAdded { get; internal set; }
        public static string UserDeleted { get; internal set; }
        public static string UserUpdated { get; internal set; }
        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 10 ürün olabilir";
    }
}

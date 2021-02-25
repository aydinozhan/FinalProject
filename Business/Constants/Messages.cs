using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem Bakımda";
        public static string ProductListed = "Ürünler Listelendi";
        public static string ProductCountOfCategoryError = "Bu kategoride en fazla 10 ürün olabilir";
        public static string ProductUpdated= "Ürün Güncellendi";
        public static string ProductNameAlreadyExist = "Ürün ismi zaten var";
        public static string CategoryLimitExceded = "Kategori limiti aşıldı";
    }
}

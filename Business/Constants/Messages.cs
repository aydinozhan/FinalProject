using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities.Concrete;

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
        public static string AuthorizationDenied = "Yetkiniz yok";
        public static string UserRegistered = "Kullanıcı register oldu";
        public static string UserNotFound = "Kullanıcı buluanamadı";
        public static string PasswordError = "Şifre Yanlış";

        public static string UserAlreadyExists = "Kullanıcı zaten kayıtlı";
        public static string SuccessfulLogin = "Giriş Başarılı";
        public static string AccessTokenCreated =  "Access token created";
    }
}

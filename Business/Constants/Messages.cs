using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {

        public static string Added = "Ekleme işlemi başarıyla gerçekleştirildi.";
        public static string Updated = "Güncelleme işlemi başarıyla gerçekleştirildi.";
        public static string Delete = "Silme işlemi başarıyla gerçekleştirildi.";
        public static string Listed = "Listeleme işlemi başarıyla gerçekleştirildi";
        public static string NameInvalid = "Girilen isim geçersiz.";
        public static string Undelivered = "Teslim edilmemis arac.";
        public  static string FailAddedImageLimit="Resim ekleme limitini aştınız";
        public static string ListedEmailById = "Email adleri başarılı bir şekilde listelendi";
        public static string FailedOperation = "İşlem başarısız oldu.";
        public static string RegisterSucces = "Başarılı şekilde kayıt olundu";
        public static string UserNotFound = "Aranan kullanıcı bulunamadı";
        public static string ErrorPassword = "Hatalı şifre";
        public static string SuccessLogin = "Başarılı giriş";
        public static string AlreadyRegister = "Mevcut kullanıcı";
        public static string CreatedToken = "Token oluşturuldu";
        public static string AuthorizationDenied = "Yetkiniz yok.";
    }
}

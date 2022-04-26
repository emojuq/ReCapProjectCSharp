using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string carAddedMessage = "Araba başarıyla eklenmiştir";
        public static string carUpdatedMessage = "Araba başarıyla güncellenmiştir";
        public static string carDeletedMessage = "Araba başarıyla silinmiştir";
        public static string carNameInvalid = "Araba ismi geçersiz, başka bir isim deneyin";
        public static string carListed = "Araba başarıyla listelendi";
        public static string carDetailsListed = "Araba Detayı Başarıyla Listelendi";
        public static string carListedByColorId = "Araba renge göre listelendi";
        public static string carListedByBrandId = "Araba markaya göre listelendi";

        public static string brandAddedMessage = "Marka başarıyla eklenmiştir";
        public static string brandDeletedMessage = "Marka başarıyla silinmiştir";
        public static string brandUpdatedMessage = "Marka başarıyla güncellenmiştir";
        public static string brandListed = "Marka başarıyla listelenmiştir";
        public static string brandGetById = "Marka id'sine göre getirilmiştir";

        public static string colorAddedMessage = "Renk başarıyla eklenmiştir";
        public static string colorDeletedMessage = "Renk başarıyla silinmiştir";
        public static string colorUpdatedMessage = "Renk başarıyla güncellenmiştir";
        public static string colorListed = "Renk başarıyla listelenmiştir";
        public static string colorGetById = "Renk id'sine göre getirilmiştir";

        public static string rentalAddedMessage = "Kiralama başarıyla eklenmiştir";
        public static string rentalDeletedMessage = "Kiralama başarıyla silinmiştir";
        public static string rentalUpdatedMessage = "Kiralama başarıyla güncellenmiştir";
        public static string rentalListed = "Kiralama başarıyla listelenmiştir";
        public static string rentalGetById = "Kiralama id'sine göre getirilmiştir";
        public static string rentalGetByCarId = "Kiralama araç id'sine göre getirilmiştir";
        public static string NoCarRentalInfo = "Araba kira bilgisi bulunmuyor.";
        public static string CarRented = "Araba zaten kiralanmış.";

        public static string userAddedMessage = "Kullanıcı başarıyla eklenmiştir";
        public static string userDeletedMessage = "Kullanıcı başarıyla silinmiştir";
        public static string userUpdatedMessage = "Kullanıcı başarıyla güncellenmiştir";
        public static string userListed = "Kullanıcı başarıyla listelenmiştir";
        public static string userGetById = "Kullanıcı id'sine göre getirilmiştir";

        public static string customerAddedMessage = "Müşteri başarıyla eklenmiştir";
        public static string customerDeletedMessage = "Müşteri başarıyla silinmiştir";
        public static string customerUpdatedMessage = "Müşteri başarıyla güncellenmiştir";
        public static string customerListed = "Müşteri başarıyla listelenmiştir";
        public static string customerGetById = "Müşteri id'sine göre getirilmiştir";



        public static string MaintenanceTime = "Sistem Bakımda";
        public static string CarImageLimitError = "5'ten fazla araba resmi ekleyemezsiniz";
        public static string AuthorizationDenied = "Böyle Bir Yetkin Yok";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Şifre hatalı";
        public static string SuccessfulLogin = "Sisteme giriş başarılı";
        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut";
        public static string UserRegistered = "Kullanıcı başarıyla kaydedildi";
        public static string AccessTokenCreated = "Access token başarıyla oluşturuldu";
    }
}

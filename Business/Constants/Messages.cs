using Entities.Concrete;
using System;
using System.Collections.Generic;
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


        public static string MaintenanceTime = "Sistem Bakımda";
    }
}

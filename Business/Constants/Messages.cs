using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araba eklendi";
        public static string CarDailyPriceInvalid = "Lütfen günlük fiyat kısmını 0'dan büyük giriniz.";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string CarListed = "Araba Listelendi";
        public static string CarDeleted = "Araba silindi.";
        public static string CarUpdated = "Araba güncellendi.";

        public static string BrandAdded = "Marka başarıyla eklendi.";
        public static string BrandDeleted = "Marka başarıyla silindi.";
        public static string BrandUpdated= "Marka başarıyla güncellendi.";
        public static string BrandListed = "Brand is listed";

        public static string ColorAdded = "Renk başarıyla eklendi.";
        public static string ColorDeleted = "Renk başarıyla silindi.";
        public static string ColorUpdated = "Renk başarıyla güncellendi.";
        public static string ColorListed = "Color is listed";

        public static string UserAdded = "Kullanıcı başarıyla eklendi.";
        public static string UserDeleted = "Kullanıcı başarıyla silindi.";
        public static string UserUpdated = "Kullanıcı başarıyla güncellendi.";
        public static string UserListed = "Kullanıcı listelendi";

        public static string CustomerAdded = "Customer is added";
        public static string CustomerDeleted = "Customer is deleted";
        public static string CustomerUpdated = "Customer is updated";
        public static string CustomerListed = "Customer is listed";


        public static string RentalAdded = "Araba Kiralama işlemi baraşıyla gerçekleşti.";
        public static string RentalDeleted = "Araba Kiralama işlemi iptal edildi.";
        public static string RentalUpdated = "Araba Kiralama işlemi güncellendi.";
        public static string RentalListed = "Rental is listed";
        public static string RentalNotReturned = "Bu araba henüz teslim edilmediği için kiralayamazsınız.";
        public static string RentalReturned = "Kiraladığınız araç teslim edildi.";
       
    }
}

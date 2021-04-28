using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
   public static class Messages
    {
        public static string CarsListed = "Arabalar listelendi";
        public static string CarsAdded = "Araba başarıyla eklendi";
        public static string CarsNotAdded = "Araba  eklenmedi";
        public static string CarsListedByBrandId = "Arabalar marka Id sine göre listelendi";
        public static string CarsGetByDetails = "Arabalar detaylarına göre listelendi";
        public static string CarsGetByColorId = "Arabalar renklerine göre listelendi";
        public static string RentalAdded = "Kiralama Başladı";
        public static string ErrorAddedRental = "Kiralama Başarısız";

        public static string Deleted = "başarıyla silindi";

        public static string Updated = "başarıyla güncellendi";
        internal static string AuthorizationDenied = "Yetkiniz yok";
    }
}

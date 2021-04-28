using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;
using Entities;
using Entities.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarTest();
            //BrandTest();
            RentalTest();
        }

        private static void RentalTest()
        {
            RentalManager manager = new RentalManager(new EfRentalDal());
            Rental rental4 = new Rental { CustomerId = 2, RentDate = "11-02-2021", CarId = 2, ReturnDate = null };
            var result4 = manager.Add(rental4);
            Console.WriteLine("2 numaralı araç kiralandı");

            Rental rental1 = new Rental { CustomerId = 2, RentDate = "11-02-2020", CarId = 2, ReturnDate = "22-06-2020" };
            var result = manager.Add(rental1);
            Console.WriteLine("2 numaralı araç tekrar kiralanmaya çalışıldı");
            Console.WriteLine(result.Message);


            foreach (var item in manager.GetAll().Data)
            {
                Console.WriteLine(item.CarId + "----" + item.CustomerId + "----" + item.RentDate);
            }
            Rental rental2 = new Rental { Id = 3, CustomerId = 2, RentDate = "11-02-2020", CarId = 2, ReturnDate = "25-07-2020" };
            var result2 = manager.Update(rental2);
            Console.WriteLine("2 numaralı araç iade edildi");
            Console.WriteLine(result2.Message);
            var result3 = manager.Add(rental1);
            Console.WriteLine("2 numaralı araç tekrar kiralandı");
            Console.WriteLine(result3.Message);
        }


        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.Name);
            }
        }

        private static void CarTest()
        {
            CarManager productManager = new CarManager(new EfCarDal());

            var result = productManager.GetCarDetails();
            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.Description + "/" + car.BrandName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }
    }
}

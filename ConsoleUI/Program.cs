using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarTest();
           CarTest2();

            //BrandTest();

            //ColorManager colorManager = new ColorManager(new EfColorDal());
            //foreach (var color in colorManager.GetAll())
            //{
            //    Console.WriteLine(color.ColorName);
            //}

            //ColorManager colorManager = new ColorManager(new EfColorDal());
            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine("Hepsi:"+car.Description);
            //}
            //foreach (var car in carManager.GetAllByBrandId(2))
            //{
            //    Console.WriteLine("2 numaralı BrandId :"+car.Description);
            //}

            //Console.WriteLine("Brand Id'si 1 olan arabalar: \nId\tColor Name\tBrand Name\tModel Year\tDaily Price\tDescriptions");
            //foreach (var car in carManager.GetAllByBrandId(1))
            //{
            //    Console.WriteLine($"{car.CarId}\t{colorManager.GetById(car.ColorId).ColorName}\t\t{brandManager.GetById(car.BrandId).BrandName}\t\t{car.ModelYear}\t\t{car.DailyPrice}\t\t{car.Description}");
            //}

            //Console.WriteLine("\n\nColor Id'si 2 olan arabalar: \nId\tColor Name\tBrand Name\tModel Year\tDaily Price\tDescriptions");
            //foreach (var car in carManager.GetAllByColorId(2))
            //{
            //    Console.WriteLine($"{car.CarId}\t{colorManager.GetById(car.ColorId).ColorName}\t\t{brandManager.GetById(car.BrandId).BrandName}\t\t{car.ModelYear}\t\t{car.DailyPrice}\t\t{car.Description}");
            //}

            //Console.WriteLine("\n\nId'si 2 olan araba: \nId\tColor Name\tBrand Name\tModel Year\tDaily Price\tDescriptions");
            //Car carById = carManager.GetById(2);
            //Console.WriteLine($"{carById.CarId}\t{colorManager.GetById(carById.ColorId).ColorName}\t\t{brandManager.GetById(carById.BrandId).BrandName}\t\t{carById.ModelYear}\t\t{carById.DailyPrice}\t\t{carById.Description}");


            //Console.WriteLine("\n\nGünlük fiyat aralığı 100 ile 200 olan arabalar: \nId\tColor Name\tBrand Name\tModel Year\tDaily Price\tDescriptions");
            //foreach (var car in carManager.GetByDailyPrice(100, 200))
            //{
            //    Console.WriteLine($"{car.CarId}\t{colorManager.GetById(car.ColorId).ColorName}\t\t{brandManager.GetById(car.BrandId).BrandName}\t\t{car.ModelYear}\t\t{car.DailyPrice}\t\t{car.Description}");
            //}

            //Console.WriteLine("\n");

            //carManager.Add(new Car { BrandId = 1, ColorId = 2, DailyPrice = -300, ModelYear = 2021, Description = "Otomatik Dizel" });
            //brandManager.Add(new Brand { BrandName = "a" });

        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.BrandName);
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetByDailyPrice(200, 300))
            {
                Console.WriteLine(car.DailyPrice);
            }

        }
        private static void CarTest2()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.Description+"/"+ car.BrandName + "/" + car.ColorName);
            }

        }
    }
}

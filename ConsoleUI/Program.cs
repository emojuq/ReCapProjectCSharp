using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //AddedEntities();
            //ColorTest();
            //CarTest();
            // GetCarDetailsTest();

        }




        private static void GetCarDetailsTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine("GALERİMİZDE BULUNAN VE MARKASI " + " " + car.BrandName + " " + car.CarName + " OLAN " + car.ColorName +
                                    " RENKLİ ARACIMIZIN GÜNLÜK FİYATI" + " " + car.DailyPrice + " " + "TL'DİR... ");

            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Id + " " + car.BrandId + " " + car.ColorId + " " + car.DailyPrice + " " + car.Description);

            }


            foreach (var car in carManager.GetCarsByBrandId(1))
            {
                Console.WriteLine(car.Description);

            }

            foreach (var car in carManager.GetCarsByColorId(1))
            {
                Console.WriteLine(car.Id);
            }
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());

            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine(color.ColorId + " / " + color.ColorName);

            }
        }

        private static void AddedEntities()
        {
            Color color1 = new Color();
            color1.ColorName = "Black";
            color1.ColorId = 2;
            ColorManager colorManager = new ColorManager(new EfColorDal());
            colorManager.Add(color1);

            Brand brand1 = new Brand();
            brand1.BrandId = 2;
            brand1.BrandName = "Mercedes";
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.Update(brand1);

            Car car1 = new Car();
            car1.Id = 2;
            car1.BrandId = 2;
            car1.ColorId = 2;
            car1.ModelYear = "2012";
            car1.Description = "AMG";
            car1.DailyPrice = 150;
            CarManager carManager1 = new CarManager(new EfCarDal());
            carManager1.Update(car1);

            Car car2 = new Car();
            car2.Id = 1;
            car2.BrandId = 1;
            car2.ColorId = 1;
            car2.ModelYear = "2017";
            car2.Description = "3.20";
            car2.DailyPrice = 400;
            CarManager carManager2 = new CarManager(new EfCarDal());
            carManager2.Update(car2);
        }
    }
}

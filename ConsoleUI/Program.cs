using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager( new EfCarDal());


            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Id + " " + car.BrandId + " " + car.ColorId + " " + car.DailyPrice + " " + car.Description);

            }


            foreach (var car in carManager.GetCarsByBrandId(1))
            {
                Console.WriteLine(car.Description);

            }

            foreach (var  car in carManager.GetCarsByColorId(1))
            {
                Console.WriteLine(car.Id);
            }



        }
    }
}

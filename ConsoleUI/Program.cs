using Business.Concrete;
using Core.Entities.Concrete;
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

            //GetCarDetailsTest();

            //MaintenanceTimeTest();

            //CustomerTest();

            //UserTest();

            //RentalTest();

        }






        private static void RentalTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());

            Rental rental1 = new Rental();
            rental1.Id = 1;
            rental1.CarId = 1;
            rental1.CustomerId = 1;
            rental1.RentDate = new DateTime(2022, 3, 05);


            Rental rental2 = new Rental();
            rental2.Id = 2;
            rental2.CarId = 2;
            rental2.CustomerId = 2;
            rental2.RentDate = new DateTime(2022, 6, 12);


            Console.WriteLine(rentalManager.Update(rental1).Message);
            Console.WriteLine(rentalManager.Update(rental2).Message);


            Console.WriteLine("Kiralanma tarihi: " + rentalManager.GetById(1).Data.RentDate);

            var result = rentalManager.GetAll();

            if (result.Success)
            {
                foreach (var rental in result.Data)
                {
                    Console.WriteLine(rental.RentDate.ToString() + " " + rental.ReturnDate.ToString());
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }




        private static void UserTest()
        {
            User user1 = new User();
            user1.Id = 1;
            user1.FirstName = "Emre";
            user1.LastName = "Aydın";
            user1.Email = "abc@gmail.com";
            

            User user2 = new User();
            user2.Id = 2;
            user2.FirstName = "Yunus";
            user2.LastName = "Aydın";
            user2.Email = "xyz@gmail.com";
            

            User user3 = new User();
            user3.Id = 3;
            user3.FirstName = "Ahmet";
            user3.LastName = "Aydın";
            user3.Email = "qwe@gmail.com";
           


            UserManager userManager = new UserManager(new EfUserDal());
            Console.WriteLine(userManager.Add(user1).Message);
            Console.WriteLine(userManager.Add(user2).Message);
            Console.WriteLine(userManager.Add(user3).Message);

           

            //if (result.Success)
            //{
            //    foreach (var user in result.Data)
            //    {
            //        Console.WriteLine(user.FirstName + " " + user.LastName);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine(result.Message);
            //}
        }






        private static void CustomerTest()
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.CompanyName = "Emre AŞ";

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.CompanyName = "Yunus AŞ";

            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.CompanyName = "Ahmet AŞ";


            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            Console.WriteLine(customerManager.Update(customer1).Message);
            Console.WriteLine(customerManager.Update(customer2).Message);
            Console.WriteLine(customerManager.Update(customer3).Message);

            var result = customerManager.GetAll();

            if (result.Success)
            {
                foreach (var customer in result.Data)
                {
                    Console.WriteLine(customer.CompanyName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }




        private static void MaintenanceTimeTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            var result = brandManager.GetAll();
            if (result.Success == true)
            {
                foreach (var brand in result.Data)
                {
                    Console.WriteLine(brand.BrandName);
                }

            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }




        private static void GetCarDetailsTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetCarDetails().Data)
            {
                Console.WriteLine("GALERİMİZDE BULUNAN VE MARKASI " + " " + car.BrandName + " " + car.CarName + " OLAN " + car.ColorName +
                                    " RENKLİ ARACIMIZIN GÜNLÜK FİYATI" + " " + car.DailyPrice + " " + "TL'DİR... ");

            }
        }




        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetAll().Data)
            {
                Console.WriteLine(car.Id + " " + car.BrandId + " " + car.ColorId + " " + car.DailyPrice + " " + car.Description);

            }


            foreach (var car in carManager.GetCarsByBrandId(1).Data)
            {
                Console.WriteLine(car.Description);

            }

            foreach (var car in carManager.GetCarsByColorId(1).Data)
            {
                Console.WriteLine(car.Id);
            }
        }






        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());

            foreach (var color in colorManager.GetAll().Data)
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

using Business.Concrete;
using Business.Constants;
using Core.DataAccess;
using Core.Utilities.Results;
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
            //RentalManagerTest();

            UserManager userManager = new UserManager(new EfUserDal());

            foreach (var user in userManager.GetAll().Data)
            {
                Console.WriteLine(user.FirstName+","+user.LastName);
            }

            
            

            








            //InMemoryCarDalTest();
            //carManagerGetAll();
            //carManagerGetCarsByBrandId(2);
            //carManagerNotAdd();
            //carManagerGetCarsByColorId(3);
            //LearnDateFormat();
            //ColorManagerTest();
            //brandManagerTest();
            //carManagerTest();
            //EfBrandDalTest();
            //ResulTest();




















            Console.ReadLine();
        }

        private static void RentalManagerTest()
        {
            //10.gunOdev4
            RentalManager rentalManager = new RentalManager(new EfRentalDal());

            var result = rentalManager.Add(new Rental()
            {
                CarId = 1,
                CustomerId = 2,
                RentDate = new DateTime(2021, 3, 1)
            });


            if (result.Success == true)
            {
                Console.WriteLine(result.Message);
            }
            else
            {
                Console.WriteLine(result.Message);
            }



            rentalManager.Update(new Rental
            {
                Id = 9,
                CarId = 1,
                CustomerId = 2,
                RentDate = new DateTime(2021, 3, 1),
                ReturnDate = new DateTime(2021, 3, 5)
            });
        }

        private static void ColorManagerTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach (var color in colorManager.GetAll().Data)
            {
                Console.WriteLine(color.ColorName);
            }
        }

        private static void LearnDateFormat()
        {
            var result = new DateTime(2020, 5, 12, 8, 30, 52);
            Console.WriteLine(result);
            Console.WriteLine(result.ToLongTimeString());
            Console.WriteLine(result.ToLongDateString());
            Console.WriteLine(result.ToShortTimeString());
            Console.WriteLine(result.Date);
            Console.WriteLine(result.ToShortDateString());
        }

        private static void ResulTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());


            if (carManager.GetAll().Success == true)
            {
                foreach (var car in carManager.GetAll().Data)
                {
                    Console.WriteLine(car.Description);
                }
                Console.WriteLine(carManager.GetAll().Message);
            }
            else
            {
                Console.WriteLine(carManager.GetAll().Message);
            }
        }

        private static void brandManagerTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            Console.WriteLine(brandManager.GetById(1).Data.BrandName);
            foreach (var brand in brandManager.GetAll().Data)
            {
                Console.WriteLine(brand.BrandName);
            }
            brandManager.Add(new Brand { BrandName = "Mercedes" });
            brandManager.Update(new Brand { BrandId = 4, BrandName = "MERCEDES" });
            brandManager.Delete(new Brand { BrandId = 5 });
        }

        private static void carManagerTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetails().Data)
            {
                Console.WriteLine(car.CarName + ":" + car.ColorName + ":" + car.BrandName + ":" + car.DailyPrice);
            }
        }

        private static void EfBrandDalTest()
        {
            EfBrandDal efBrandDal = new EfBrandDal();
            foreach (var brand in efBrandDal.GetAll())
            {
                Console.WriteLine(brand.BrandName);
            }
        }

        private static void InMemoryCarDalTest()
        {
            //7.gunOdev2
            CarManager carManager = new CarManager(new InMemoryCarDal());
            Console.WriteLine("---------GetAll-----------");
            foreach (var car in carManager.GetAll().Data)
            {
                Console.WriteLine("{0}---{1}---{2}", car.Id, car.DailyPrice, car.Description);
            }
            Console.WriteLine("---------GetById-----------");

            Console.WriteLine(carManager.GetById(5).Data.Description);




            Console.WriteLine("---------Add-----------");
            Car lastcar = new Car
            {
                Id = 6,
                BrandId = 3,
                ColorId = 3,
                DailyPrice = 600,
                ModelYear = 2020,
                Description = "Last car"
            };
            carManager.Add(lastcar);

            foreach (var car in carManager.GetAll().Data)
            {
                Console.WriteLine("{0}---{1}---{2}", car.Id, car.DailyPrice, car.Description);
            }

            Console.WriteLine("---------Update-----------");

            carManager.Update(new Car { Id = 6, BrandId = 10, ColorId = 10, DailyPrice = 1000, ModelYear = 2020, Description = "Update Last car " });

            foreach (var car in carManager.GetAll().Data)
            {
                Console.WriteLine("{0}---{1}---{2}", car.Id, car.DailyPrice, car.Description);
            }


            Console.WriteLine("---------Delete-----------");

            carManager.Delete(new Car { Id = 3 });

            foreach (var car in carManager.GetAll().Data)
            {
                Console.WriteLine("{0}---{1}---{2}", car.Id, car.DailyPrice, car.Description);
            }
        }

        private static void carManagerNotAdd()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car
            {
                BrandId = 3,
                ColorId = 3,
                DailyPrice = 0,
                ModelYear = 2020,
                Description = "Last car"
            });
        }

        private static void carManagerGetAll()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetAll().Data)
            {
                Console.WriteLine(car.Description);
            }
        }

        private static void carManagerGetCarsByBrandId(int brandId)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarsByBrandId(brandId).Data)
            {
                Console.WriteLine(car.Description);
            }
        }

        private static void carManagerGetCarsByColorId(int colorId)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarsByColorId(colorId).Data)
            {
                Console.WriteLine(car.Description);
            }
        }
    }
}

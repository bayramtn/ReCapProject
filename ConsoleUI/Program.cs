using Business.Concrete;
using Business.Constants;
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
            //InMemoryCarDalTest();
            //carManagerGetAll();
            //carManagerGetCarsByBrandId(2);
            //carManagerNotAdd();
            //carManagerGetCarsByColorId(3);


            //brandManagerTest();
            //carManagerTest();

            //EfBrandDalTest();


            //Car lastcar = new Car
            //{
            //    BrandId = 3,
            //    ColorId = 1,
            //    DailyPrice = 600,
            //    ModelYear = 2020,
            //    Description = "Last car"
            //};
            //carManager.Add(lastcar);


            //Console.WriteLine(new Result(false,Messages.Add).Message);
            //SuccessResult successResult = new SuccessResult(Messages.Delete);
            //Console.WriteLine(successResult.Message);


            CarManager carManager = new CarManager(new EfCarDal());


            if (carManager.GetAll().Success==true)
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

            




























            Console.ReadLine();
        }

        //private static void brandManagerTest()
        //{
        //    BrandManager brandManager = new BrandManager(new EfBrandDal());
        //    Console.WriteLine(brandManager.GetById(1).BrandName);
        //    foreach (var brand in brandManager.GetAll())
        //    {
        //        Console.WriteLine(brand.BrandName);
        //    }
        //    brandManager.Add(new Brand { BrandName = "Mercedes" });
        //    brandManager.Update(new Brand { BrandId = 4, BrandName = "MERCEDES" });
        //    brandManager.Delete(new Brand { BrandId = 5 });
        //}

        //private static void carManagerTest()
        //{
        //    CarManager carManager = new CarManager(new EfCarDal());
        //    foreach (var car in carManager.GetCarDetails())
        //    {
        //        Console.WriteLine(car.CarName + ":" + car.ColorName + ":" + car.BrandName + ":" + car.DailyPrice);
        //    }
        //}

        //private static void EfBrandDalTest()
        //{
        //    EfBrandDal efBrandDal = new EfBrandDal();
        //    foreach (var brand in efBrandDal.GetAll())
        //    {
        //        Console.WriteLine(brand.BrandName);
        //    }
        //}

        //private static void InMemoryCarDalTest()
        //{
        //    //7.gunOdev2
        //    CarManager carManager = new CarManager(new InMemoryCarDal());
        //    Console.WriteLine("---------GetAll-----------");
        //    foreach (var car in carManager.GetAll())
        //    {
        //        Console.WriteLine("{0}---{1}---{2}", car.Id, car.DailyPrice, car.Description);
        //    }
        //    Console.WriteLine("---------GetById-----------");

        //    Console.WriteLine(carManager.GetById(5).Description);




        //    Console.WriteLine("---------Add-----------");
        //    Car lastcar = new Car
        //    {
        //        Id = 6,
        //        BrandId = 3,
        //        ColorId = 3,
        //        DailyPrice = 600,
        //        ModelYear = 2020,
        //        Description = "Last car"
        //    };
        //    carManager.Add(lastcar);

        //    foreach (var car in carManager.GetAll())
        //    {
        //        Console.WriteLine("{0}---{1}---{2}", car.Id, car.DailyPrice, car.Description);
        //    }

        //    Console.WriteLine("---------Update-----------");

        //    carManager.Update(new Car { Id = 6, BrandId = 10, ColorId = 10, DailyPrice = 1000, ModelYear = 2020, Description = "Update Last car " });

        //    foreach (var car in carManager.GetAll())
        //    {
        //        Console.WriteLine("{0}---{1}---{2}", car.Id, car.DailyPrice, car.Description);
        //    }


        //    Console.WriteLine("---------Delete-----------");

        //    carManager.Delete(new Car { Id = 3 });

        //    foreach (var car in carManager.GetAll())
        //    {
        //        Console.WriteLine("{0}---{1}---{2}", car.Id, car.DailyPrice, car.Description);
        //    }
        //}

        //private static void carManagerNotAdd()
        //{
        //    CarManager carManager = new CarManager(new EfCarDal());
        //    carManager.Add(new Car
        //    {
        //        BrandId = 3,
        //        ColorId = 3,
        //        DailyPrice = 0,
        //        ModelYear = 2020,
        //        Description = "Last car"
        //    });
        //}

        //private static void carManagerGetAll()
        //{
        //    CarManager carManager = new CarManager(new EfCarDal());
        //    foreach (var car in carManager.GetAll())
        //    {
        //        Console.WriteLine(car.Description);
        //    }
        //}

        //private static void carManagerGetCarsByBrandId(int brandId)
        //{
        //    CarManager carManager = new CarManager(new EfCarDal());
        //    foreach (var car in carManager.GetCarsByBrandId(brandId))
        //    {
        //        Console.WriteLine(car.Description);
        //    }
        //}

        //private static void carManagerGetCarsByColorId(int colorId)
        //{
        //    CarManager carManager = new CarManager(new EfCarDal());
        //    foreach (var car in carManager.GetCarsByColorId(colorId))
        //    {
        //        Console.WriteLine(car.Description);
        //    }
        //}
    }
}

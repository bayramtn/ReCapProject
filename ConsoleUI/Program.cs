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
            CarManager carManager = new CarManager(new EfCarDal());

            

            Console.WriteLine("--------------GetCarsByBrandId-------------");

            foreach (var car in carManager.GetCarsByBrandId(3))
            {
                Console.WriteLine(car.Description);
            }

            Console.WriteLine("--------------GetAll-------------");

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }

            Console.WriteLine("----------GetCarsByColorId-----------------");

            foreach (var car in carManager.GetCarsByColorId(2))
            {
                Console.WriteLine(car.Description);
            }

            Console.WriteLine("----------Add-----------------");


            carManager.Add(new Car
            {
                BrandId = 3,
                ColorId = 3,
                DailyPrice = 0,
                ModelYear = 2020,
                Description = "Last car"
            });

            Console.WriteLine("----------GetAll-----------------");

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("{0}---{1}---{2}", car.Id, car.DailyPrice, car.Description);
            }









            //7.gunOdev2
            //CarManager carManager = new CarManager(new InMemoryCarDal());
            //Console.WriteLine("---------GetAll-----------");
            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine("{0}---{1}---{2}",car.Id,car.DailyPrice,car.Description);
            //}
            //Console.WriteLine("---------GetById-----------");

            //foreach (var car in carManager.GetById(3))
            //{
            //    Console.WriteLine("car id: "+car.Id+","+car.ModelYear+" model "+car.Description);
            //}

            //Console.WriteLine("---------Add-----------");
            //Car lastcar = new Car
            //{
            //    Id = 6,
            //    BrandId = 3,
            //    ColorId = 3,
            //    DailyPrice = 600,
            //    ModelYear = 2020,
            //    Description = "Last car"
            //};
            //carManager.Add(lastcar);

            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine("{0}---{1}---{2}", car.Id, car.DailyPrice, car.Description);
            //}

            //Console.WriteLine("---------Update-----------");

            //carManager.Update(new Car { Id = 6, BrandId = 10, ColorId = 10, DailyPrice = 1000, ModelYear = 2020, Description = "Update Last car " });

            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine("{0}---{1}---{2}", car.Id, car.DailyPrice, car.Description);
            //}


            //Console.WriteLine("---------Delete-----------");

            //carManager.Delete(new Car {Id=3 });

            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine("{0}---{1}---{2}", car.Id, car.DailyPrice, car.Description);
            //}

            Console.ReadLine();
        }
    }
}

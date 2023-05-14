using EntityFramework.Interfaces;
using EntityFramework.Models;
using EntityFramework.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Ninject;
using System.Runtime.CompilerServices;

namespace EntityFramework
{
    public class Program
    {
        static void Main(string[] args)
        {
            var kernel = new StandardKernel(new Module());
            var ShopRepo = kernel.Get<IRepo<Shop>>();

            //Вивід всіх магазинів з його товарами
            //var storeNetworks = ShopRepo.GetAll();
            //foreach (var shop in storeNetworks)
            //{
            //    Console.WriteLine(shop.Name);
            //    if (shop.Products.Count == 0)
            //    {
            //        Console.WriteLine("No products!");
            //    }
            //    else
            //    {
            //        foreach (var product in shop.Products)
            //        {
            //            Console.WriteLine($" - {product.Name}");
            //        }
            //    }

            //}

            //Створення нового магазину
            //ShopRepo.Create(new Shop { Id = Guid.NewGuid(), Name = "Fresh" });

            //Редагування магазину
            //ShopRepo.Update(new Shop { Id = Guid.Parse("fd59d3a9-fb28-47f7-8820-3dfaa7c00e22"), Name = "Shop Raketa" });

            //Видалення магазину
            //ShopRepo.Delete(Guid.Parse("fd59d3a9-fb28-47f7-8820-3dfaa7c00e22"));

            Console.ReadLine();

            

        }
    }
}
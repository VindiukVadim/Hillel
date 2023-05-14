using EntityFramework.Interfaces;
using EntityFramework.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Services
{
    public class ShopService : IRepo<Shop>
    {
        private readonly AppContext _context;

        public ShopService(AppContext context)
        {
            _context= context;
        }

        public void Create(Shop entity)
        {
            var shop = entity;
            _context.Shops.Add(shop);
            _context.SaveChanges();
        }

        public void Delete(Guid id)
        {
            var shop = _context.Shops.FirstOrDefault(s => s.Id == id);
            _context.Shops.Remove(shop);
            _context.SaveChanges();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Shop> GetAll()
        {
            var allShopsWithProd = _context.Shops.Include(p =>p.Products).ToList();
            return allShopsWithProd;
        }

        public void Update(Shop entity)
        {
            var shop = _context.Shops.FirstOrDefault(s => s.Id == entity.Id);
            shop.Name = entity.Name;
            _context.Shops.UpdateRange(shop);
            _context.SaveChanges();
        }
    }
}

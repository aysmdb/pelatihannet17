using apajaadastore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apajaadastore.Services
{
    public class ProductServices
    {
        private readonly ApaAjaContext _context;

        public ProductServices(ApaAjaContext context)
        {
            _context = context;
        }

        public List<Product> GetAll()
        {
            var result = _context.Product.ToList();

            return result;
        }

        public bool AddProduct()
        {
            Product product = new Product()
            {
                Id = new Guid(),
                Nama = "Sepatu Bola",
                Harga = 256000
            };

            _context.Add(product);

            _context.SaveChanges();

            return true;
        }
    }
}

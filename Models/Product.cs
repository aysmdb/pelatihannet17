using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apajaadastore.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Nama { get; set; }
        public decimal Harga { get; set; }
    }
}

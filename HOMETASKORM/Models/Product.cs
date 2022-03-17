using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HOMETASKORM.Models
{
    public class Product
    {
        
        public string Name { get; set; }

        public int  Id { get; set; }
        public int CategoryId { get; set; }
        public Category category { get; set; }
    }
}

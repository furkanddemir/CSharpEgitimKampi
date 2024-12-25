using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi501.Dtos
{
    public class CreateProductDto
    {
        //Ekleme işlemi için 
        
        public string ProductName { get; set; }

        public string ProductCategory { get; set; }

        public string ProductStock { get; set; }

        public decimal ProductPrice { get; set; }
    }
}

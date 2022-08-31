using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppCore.Enums.ProductStatusEnum;

namespace MyProducts
{

    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string Brand { get; set; }
        public decimal Price { get; set; }
        public ProductStatusEnum Status { get; set; }
    }


}


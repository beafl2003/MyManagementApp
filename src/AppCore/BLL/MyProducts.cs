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

        public Guid Id { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string Brand { get; set; }
        public string Price { get; set; }
        //public ProductStatusEnum Status { get; set; }
        public bool Active { get; set; }
    }


}


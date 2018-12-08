using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Entities
{
    public class Product : BaseEntity
    {
        public decimal Price { get; set; }
        public Category Category { get; set; }
        // public string Flavor{ get; set; }
        //public int ID { get; set; }
        //public string Name { get; set; }
        //public string Description { get; set; }

    }
}

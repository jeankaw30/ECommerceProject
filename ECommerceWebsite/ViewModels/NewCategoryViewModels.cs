using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ECommerceWebsite.ViewModels
{
    public class NewCategoryViewModels
    {
        public int CategoryID { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

    }
}
﻿using ECommerce.Entities;
using ECommerceDatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ECommerce.Services
{
    public class ProductsService
    {
        public Product GetProduct(int ID)
        {
            using (var context = new DBContext())
            {
                return context.Products.Find(ID);
            }
        }


        public List<Product> GetProducts()
        {
            //var context = new DBContext();
            //return context.Products.ToList();

            using (var context = new DBContext())
            {
                return context.Products.Include( x => x.Category ).ToList();
            }
        }


        public void SaveProduct(Product product)
        {
            using (var context = new DBContext())
            {
                context.Entry(product.Category).State = System.Data.Entity.EntityState.Unchanged;
                context.Products.Add(product);
                context.SaveChanges();
            }
        }


        public void UpdateProduct(Product product)
        {
            using (var context = new DBContext())
            {
                context.Entry(product).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }


        public void DeleteProduct(int ID)
        {
            using (var context = new DBContext())
            {         
                var product = context.Products.Find(ID);
                context.Products.Remove(product);
                context.SaveChanges();
            }
        }
    }
}

﻿
using AppContext = LabWork.Model.DataContext.AppContext;
using System.Linq;
using System.Collections.Generic;
using System;

namespace LabWork.Model
{
    public static class DataWorker
    {
        public static List<Product> GetAllProducts()
        {
            using (AppContext db = new AppContext())
            {
                var result = db.Products.ToList();
                return result;
            }
        }
        public static string AddProduct(string name, double? price, string desc)
        {
            string result = "Товар уже существует";
            using (AppContext db = new AppContext())
            {
                Product product = db.Products.Where(p => p.Name == name && p.Desc == desc && p.Price == price).FirstOrDefault();
                if (product == null)
                {
                    Product newProduct = new Product(name, price, desc);

                    db.Products.Add(newProduct);
                    db.SaveChanges();
                    result = "Товар успешно занесен в список";
                }
                
                return result;
            }           
        }
        public static string DeleteProduct(Product oldProduct)
        {
            string result = "Товар не существует";
            using (AppContext db = new AppContext())
            {
                Product product = db.Products.FirstOrDefault(p => p.Id == oldProduct.Id);
                if (product != null)
                {
                    db.Products.Remove(product);
                    db.SaveChanges();
                    result = $"{product.Name} успешно удален";
                }
               
            }
            return result;
        }
        public static string EditProduct(Product oldProduct, string name, string desc, double? price)
        {
            string result = "Товар не существует";
            using (AppContext db = new AppContext())
            {
                Product product = db.Products.Where(p => p.Id == oldProduct.Id).FirstOrDefault();
                if (product != null)
                {
                    product.Name = name;
                    product.Desc = desc;
                    product.Price = price;
                    db.SaveChanges();
                    result = $"{product.Name} успешно изменен";
                }
                return result;
            }

        }        
    }
}

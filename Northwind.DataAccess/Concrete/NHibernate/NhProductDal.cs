﻿using Northwind.DataAccess.Abstract;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataAccess.Concrete.NHibernate
{
    public class NhProductDal : IProductDal

    {
        public void Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            List<Product> products = new List<Product>
            {
                new Product { ProductId = 1, CategoryId = 1, QuantityPerUnit = "1 i n a box", ProductName = "Laptop", UnitPrice = 3000, UnitsInStock = 11 }
            };
            return products;
        }
        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
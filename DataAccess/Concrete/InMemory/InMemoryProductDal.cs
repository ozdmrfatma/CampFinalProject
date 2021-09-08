using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products; //bellekte ürün listesi

        public InMemoryProductDal()
        {
            //Oracle,Sql Server,Postgres,MongoDb veritabanından bu veriler geliyor
            _products = new List<Product> {
                new Product{ProductId=1,CategoryId=1,ProductName="Bardak",UnitPrice=15,UnitsInStock=15 },
                new Product{ProductId=2,CategoryId=1,ProductName="Kamera",UnitPrice=500,UnitsInStock=3 },
                new Product{ProductId=3,CategoryId=2,ProductName="Telefon",UnitPrice=1500,UnitsInStock=2 },
                new Product{ProductId=4,CategoryId=2,ProductName="Klavye",UnitPrice=150,UnitsInStock=65 },
                new Product{ProductId=5,CategoryId=2,ProductName="Fare",UnitPrice=85,UnitsInStock=1 }
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);//listeye ekliyor
        }

        public void Delete(Product product)
        {
            //Product productToDelete=null;
            //foreach (var p in _products)
            //{
            //    if (product.ProductId == p.ProductId)
            //    {
            //        productToDelete = p;
            //    }
            //}
            //_products.Remove(productToDelete);

            Product productToDelete;

            //Linq ile liste bazli yapilari Sql'deki gibi filtreleyebiliyoruz.

            productToDelete = _products.SingleOrDefault(p=>p.ProductId==product.ProductId);
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            //Gönderdiğim ürün Id'sine sahip olan listedeki ürünü bul

            productToUpdate.ProductName = product.ProductName;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
            productToUpdate.CategoryId = product.CategoryId;
        }
    }
}


//Bellek üzerinde ürün ile ilgili veri erişim kodlarının yazıldığı yer
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

//Test

//SOLID
//Open Closed Principle

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductTest();

            //CategoryTest();
        }

        private static void CategoryTest()
        {
            CategoryManager cM = new CategoryManager(new EfCategoryDal());//IoC
            foreach (var category in cM.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var product in productManager.GetProductDetails())
            {
                Console.WriteLine(product.ProductName + " | "+product.CategoryName);
            }
        }
    }
}

using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

namespace CosoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProducTest();
            //CategoryTest();

        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProducTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            var result = productManager.GetProductDetails();

            if (result.Success == true)
            {
                foreach (var product in productManager.GetProductDetails().Data)
                {
                    Console.WriteLine(product.ProductName + " " + product.CategoryName);
                }
            }

            else
            {
                Console.WriteLine(result.Message);
            }
        }
    }
}
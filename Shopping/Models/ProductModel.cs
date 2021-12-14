using System.Collections.Generic;

namespace Shopping.Models
{
    public class ProductModel
    {
        public  IEnumerable<Product> findAll()
        {
            IList<Product> productList = new List<Product>()
            {
                new Product()
                    { Id = "21", Name = "Test", Photo="thumb1.gif", Price=3.3},
               new Product()
                    { Id = "21", Name = "Test", Photo="thumb1.gif", Price=3.3},
               new Product()
                    { Id = "21", Name = "Test", Photo="thumb1.gif", Price=3.3},
                new Product()
                    { Id = "21", Name = "Test", Photo="thumb1.gif", Price=3.3},
            };
            return productList;
        }

        public Product find(string id)
        {
            return new Product { Id = "21", Name = "Test", Photo = "", Price = 3.3 };
        }
    }
}

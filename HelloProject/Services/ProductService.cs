using HelloProject.Models;
using System.Reflection;

namespace HelloProject.Services
{
    public class ProductService
    {
        static List<Product> products;
        public ProductService()
        {
            if (products == null)
            {
                products = new List<Product>();
                products.Add(new Product
                {
                    Id = 1,
                    Name = "Iphone 15",
                    Price = 30000000,
                    Category = "Điện thoại",
                    Description = "Smart phone của Apple",
                    ProductionDate = new DateTime(2023, 09, 01)
                });
                products.Add(new Product
                {
                    Id = 2,
                    Name = "Iphone 15 Promax",
                    Price = 32000000,
                    Category = "Điện thoại",
                    Description = "Smart phone của Apple",
                    ProductionDate = new DateTime(2023, 10, 01)
                });
            }
        }
        /// <summary>
        /// Lấy toàn bộ danh sách sản phẩm
        /// </summary>
        /// <returns>Danh sách sản phẩm</returns>
        public List<Product> GetProducts(String? keyWord)
        {
            var ls = products;
            if (!String.IsNullOrEmpty(keyWord))
            {
                ls = ls.Where(e => e.Name.Contains(keyWord) ||
                                   e.Description.Contains(keyWord) ||
                                   e.Category.Contains(keyWord) ||
                                   e.Price.ToString() == keyWord) 
                       .ToList();
            }
            return ls;
        }
    }
}

using Microsoft.EntityFrameworkCore;
using ProvaPub.Models;
using ProvaPub.Repository;

namespace ProvaPub.Services
{
    public class ProductService
    {
        TestDbContext _ctx;

        public ProductService(TestDbContext ctx)
        {
            _ctx = ctx;
        }

        public ProductList ListProducts(int pageIndex)
        {
            const int pageSize = 10;

            var products = _ctx.Products;

            var count = products.Count();
            var totalPages = (int)Math.Ceiling(count / (double)pageSize);

            var hasNext = pageIndex < totalPages;

            return new ProductList() { HasNext = hasNext, TotalCount = totalPages, Products = products.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList() };
        }
    }
}

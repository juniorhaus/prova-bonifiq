using ProvaPub.Interfaces;
using ProvaPub.Models;
using ProvaPub.Repository;

namespace ProvaPub.Services
{
    public class ProductService : IProductService
    {
        public BaseDto<Product> ListProducts(int pageIndex, TestDbContext _ctx)
        {
            const int pageSize = 10;

            var products = _ctx.Products;

            var count = products.Count();
            var totalPages = (int)Math.Ceiling(count / (double)pageSize);

            var hasNext = pageIndex < totalPages;

            return new BaseDto<Product>() { HasNext = hasNext, TotalCount = totalPages, List = products.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList() };
        }
    }
}

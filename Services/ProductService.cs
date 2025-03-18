using ProvaPub.Interfaces;
using ProvaPub.Models;
using ProvaPub.NovaPasta;
using ProvaPub.Repository;

namespace ProvaPub.Services
{
    public class ProductService : IProductService
    {
        public BaseDto<Product> ListProducts(int pageIndex, TestDbContext _ctx)
        {
            var list = Utils.GenericPagination(pageIndex, _ctx.Products.ToList());

            return new BaseDto<Product>() { HasNext = list.Item2, TotalCount = 10, List = list.Item1 };
        }
    }
}



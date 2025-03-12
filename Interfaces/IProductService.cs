using ProvaPub.Models;
using ProvaPub.Repository;

namespace ProvaPub.Interfaces
{
    public interface IProductService
    {
        BaseDto<Product> ListProducts(int pageIndex, TestDbContext _ctx);
    }
}

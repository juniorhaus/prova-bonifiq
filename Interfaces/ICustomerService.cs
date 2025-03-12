using ProvaPub.Models;
using ProvaPub.Repository;

namespace ProvaPub.Interfaces
{
    public interface ICustomerService
    {
        BaseDto<Customer> ListCustomers(int page, TestDbContext _ctx);
    }
}

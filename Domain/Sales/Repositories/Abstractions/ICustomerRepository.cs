using Domain.Models.Sales;
using System;
using System.Threading.Tasks;

namespace Domain.Sales.Repositories.Abstractions
{
    public interface ICustomerRepository
    {
        Task<Customer> GetByIdAsync(Guid id);
    }
}

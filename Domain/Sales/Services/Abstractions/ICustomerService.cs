using Domain.Models.Sales;
using Infrastructure.Diagnostics;
using System;
using System.Threading.Tasks;

namespace Domain.Sales.Services.Abstractions
{
    public interface ICustomerService
    {
        Task<IResult<Customer>> GetByIdAsync(Guid id);
    }
}

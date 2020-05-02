using Domain.Models.Sales;
using Domain.Sales.Repositories.Abstractions;
using Domain.Sales.Services.Abstractions;
using Infrastructure.Constants;
using Infrastructure.Diagnostics;
using System;
using System.Threading.Tasks;

namespace Domain.Sales.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;
        }

        public async Task<IResult<Customer>> GetByIdAsync(Guid id)
        {
            try
            {
                var customer = await customerRepository.GetByIdAsync(id);

                if (customer == null)
                    return Result<Customer>.CreateFailed(ResultCode.NotFound, $"Could not find customer with id {id}");

                return Result<Customer>.CreateSuccessful(customer);
            }
            catch (Exception ex)
            {
                return Result<Customer>.CreateFailed(ResultCode.NotFound, $"Failed find customer with id {id}. Message : {ex.Message}");
            }
        }
    }
}

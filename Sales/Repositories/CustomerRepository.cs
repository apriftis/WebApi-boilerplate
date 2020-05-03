using AutoMapper;
using DataAccess.Databases.Sales;
using Domain.Models.Sales;
using Domain.Sales.Repositories.Abstractions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace Domain.Sales.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly SalesDbContext context;
        private readonly IMapper mapper;

        public CustomerRepository(SalesDbContext salesDbContext, IMapper mapper)
        {
            this.context = salesDbContext;
            this.mapper = mapper;
        }

        public async Task<Customer> GetByIdAsync(Guid id)
        {
            var customerEntity = await context.Customers.SingleOrDefaultAsync(m => m.Id == id);
            if (customerEntity == null)
                return null;

            return mapper.Map<Customer>(customerEntity);
        }
    }
}

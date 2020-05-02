using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models.Sales
{
    public class Customer
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}

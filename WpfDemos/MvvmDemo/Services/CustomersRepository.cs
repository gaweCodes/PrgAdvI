using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using MvvmDemo.Data;

namespace MvvmDemo.Services
{
    public class CustomersRepository : ICustomersRepository
    {
        private readonly DataStoreContext _context = new DataStoreContext();
        public Task<List<Customer>> GetCustomersAsync() => _context.Customers.ToListAsync();
        public Task<Customer> GetCustomerAsync(Guid id) => _context.Customers.FirstOrDefaultAsync(c => c.Id == id);
        public async Task<Customer> AddCustomerAsync(Customer customer)
        {
            _context.Customers.Add(customer);
            await _context.SaveChangesAsync();
            return customer;
        }
        public async Task<Customer> UpdateCustomerAsync(Customer customer)
        {
            if (_context.Customers.Local.All(c => c.Id != customer.Id))
                _context.Customers.Attach(customer);

            _context.Entry(customer).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return customer;
        }

        public async Task DeleteCustomerAsync(Guid customerId)
        {
            var customer = _context.Customers.FirstOrDefault(c => c.Id == customerId);
            if (customer != null)
                _context.Customers.Remove(customer);
            await _context.SaveChangesAsync();
        }
    }
}
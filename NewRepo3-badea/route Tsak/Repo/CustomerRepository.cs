using Microsoft.EntityFrameworkCore;
using route_Tsak.Models;
using route_Tsak.Repo;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace route_Tsak.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly TaskDbContext _context;

        public CustomerRepository(TaskDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Customer customer)
        {
            _context.Customers.Add(customer);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Customer customer)
        {
            _context.Entry(customer).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Customer customer)
        {
            _context.Customers.Remove(customer);
            await _context.SaveChangesAsync();
        }

        public List<Customer> GetAll()
        {
            return _context.Customers.ToList();
        }

        public Customer GetById(int id)
        {
            return _context.Customers.FirstOrDefault(c => c.CustomerId == id);
        }

        Task<Customer> IRepository<Customer>.GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}

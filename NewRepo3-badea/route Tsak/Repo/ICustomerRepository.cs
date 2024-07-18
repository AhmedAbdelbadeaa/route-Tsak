using route_Tsak.Models;

namespace route_Tsak.Repo
{
    public interface ICustomerRepository : IRepository<Customer>
    {
        List<Customer> GetAll();
        Customer GetById(int id);
        Task AddAsync(Customer customer);
        Task UpdateAsync(Customer customer);
        Task DeleteAsync(Customer customer);


    }
}

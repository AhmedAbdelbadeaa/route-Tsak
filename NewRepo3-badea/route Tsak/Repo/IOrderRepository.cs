using route_Tsak.Dto;
using route_Tsak.Models;
namespace route_Tsak.Repo
{
    public interface IOrderRepository : IRepository<Order>
    {
        Task AddAsync(Order order);
        Order GetById(int id);
        List<Order> GetAll();
        Task UpdateAsync(AdminOrderDto order);
        Task DeleteAsync(int id);
    }
}

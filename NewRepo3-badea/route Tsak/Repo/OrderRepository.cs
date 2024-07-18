using route_Tsak.Dto;
using route_Tsak.Models;

namespace route_Tsak.Repo
{
    public class OrderRepository : IOrderRepository
    {
        public readonly TaskDbContext _context;
        public OrderRepository(TaskDbContext context)
        {
            _context = context;
        }
        public async Task AddAsync(Order order)
        {
            _context.Orders.Add(order);
            await _context.SaveChangesAsync();
        }

        public Task DeleteAsync(Order entity)
        {
            throw new NotImplementedException();
        }

        public List<Order> GetAll()
        {
            return _context.Orders.ToList();
        }

        public Order GetById(int id)
        {
            return _context.Orders.FirstOrDefault(o => o.OrderId == id);
        }

        public async Task UpdateAsync(AdminOrderDto order)
        {
            var oldorder = _context.Orders.FirstOrDefault(c=>c.OrderId == order.OrderId);
            oldorder.TotalAmount = order.TotalAmount;
            oldorder.statusenum = order.statusenum;
            oldorder.paymentenum = order.paymentenum;
            await _context.SaveChangesAsync();
        }

        public Task UpdateAsync(Order entity)
        {
            throw new NotImplementedException();
        }

        Task<Order> IRepository<Order>.GetById(int id)
        {
            throw new NotImplementedException();
        }
        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}

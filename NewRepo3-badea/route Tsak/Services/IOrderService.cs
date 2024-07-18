using route_Tsak.Dto;

namespace route_Tsak.Services
{
    public interface IOrderService
    {
        Task AddOrderAsync(UserOrderDto orderdto);
        UserOrderDto GetOrderbyId(int id);
        List<AdminOrderDto> GetAllOrders();
        Task UpdateOrderAsync(AdminOrderDto orderdto);
    }
}

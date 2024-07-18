using route_Tsak.Enum;

namespace route_Tsak.Dto
{
    public class UserOrderDto
    {
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }
        public Paymentenum paymentenum { get; set; }

    }
}

namespace EnocaNetCoreApi.CQRS.Commands.OrdersCommand
{
    public class CreateOrdersCommand
    {
        public int CarrierId { get; set; }
        public int OrderDesi { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal OrderCarrierCost { get; set; }
    }
}

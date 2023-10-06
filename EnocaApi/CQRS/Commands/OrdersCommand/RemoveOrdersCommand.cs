namespace EnocaNetCoreApi.CQRS.Commands.OrdersCommand
{
    public class RemoveOrdersCommand
    {
        public RemoveOrdersCommand(int id) 
        { 
            Id = id; 
        }
        public int Id { get; set; }
    }
}

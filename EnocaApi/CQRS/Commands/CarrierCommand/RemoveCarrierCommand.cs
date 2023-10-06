namespace EnocaNetCoreApi.CQRS.Commands.CarrierCommand
{
    public class RemoveCarrierCommand
    {
        public RemoveCarrierCommand(int id) 
        {
            Id=id;
        }
        public int Id { get; set; }

    }
}

namespace EnocaNetCoreApi.CQRS.Commands.CarrierConfigurationCommand
{
    public class RemoveCarrierConfigurationsCommands
    {
        public RemoveCarrierConfigurationsCommands(int id) { id = id; }
        public int Id { get; set; }
    }
}

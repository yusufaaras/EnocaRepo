namespace EnocaNetCoreApi.CQRS.Commands.CarrierConfigurationCommand
{
    public class UpdateCarrierConfigurationsCommands
    {
        public int CarrierId { get; set; }
        public int CarrierMaxDesi { get; set; }
        public int CarrierMinDesi { get; set; }
        public decimal CarrierCost { get; set; }
    }
}

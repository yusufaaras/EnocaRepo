namespace EnocaNetCoreApi.CQRS.Commands.CarrierCommand
{
    public class UpdateCarrierCommand
    {
        public int CarrierId { get; set; }
        public string CarrierName { get; set; }
        public bool CarrierIsActive { get; set; }
        public int CarrierPlusDesiCost { get; set; }
        public int CarrierConfigurationid { get; set; }
    }
}

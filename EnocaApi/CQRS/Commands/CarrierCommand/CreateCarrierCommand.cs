namespace EnocaNetCoreApi.CQRS.Commands.CarrierCommand
{
    public class CreateCarrierCommand
    {
        public string CarrierName { get; set; }
        public bool CarrierIsActive { get; set; }
        public int CarrierPlusDesiCost { get; set; }
        public int CarrierConfigurationid { get; set; }
    }
}

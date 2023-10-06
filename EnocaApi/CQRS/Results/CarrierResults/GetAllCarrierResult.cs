namespace EnocaNetCoreApi.CQRS.Results.CarrierResults
{
    public class GetAllCarrierResult
    {
        public int id { get; set; }
        public string carrierName { get; set; }
        public bool carrierIsActive { get; set; }
        public int carrierPlusDesiCost { get; set; }
        public int carrierConfigurationid { get; set; }
    }
}

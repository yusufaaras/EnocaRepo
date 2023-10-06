namespace EnocaNetCoreApi.CQRS.Results.CarrierResults
{
    public class GetCarrierByIdQueryResults
    {
        public int CarrierId { get; set; }
        public string CarrierName { get; set; }
        public int CarrierPlusDesiCost { get; set; }
        public int CarrierConfigurationid { get; set; }
    }
}

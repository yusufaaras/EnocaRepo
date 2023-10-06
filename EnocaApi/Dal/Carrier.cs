namespace EnocaApi.Dal
{
    public class Carrier
    {
        public int CarrierId { get; set; }
        public string CarrierName { get; set; }
        public bool CarrierIsActive { get; set; }
        public int CarrierPlusDesiCost { get; set; }
        public int CarrierConfigurationid { get; set; }
        public List<CarrierConfigurations> CarrierConfiguration { get; set; }
        public List<Orders> Order { get; set; }
    }
}

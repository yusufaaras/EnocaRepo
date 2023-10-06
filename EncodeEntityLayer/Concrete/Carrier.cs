using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncodeEntityLayer.Concrete
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

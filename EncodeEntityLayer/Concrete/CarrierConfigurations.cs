using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncodeEntityLayer.Concrete
{
    public class CarrierConfigurations
    {
     [Key]
        public int CarrierConfigurationId{ get; set; }
        public int CarrierId{ get; set; }
        public int CarrierMaxDesi{ get; set; }
        public int CarrierMinDesi{ get; set; }
        public decimal CarrierCost{ get; set; }
        public Carrier Carrier { get; set; }
    }
}

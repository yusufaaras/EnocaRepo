using DataAccessLayer.Repository;
using EncodeEntityLayer.Concrete;
using EnocaDataAccessLayer.Abstract;
using EnocaDataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnocaDataAccessLayer.EntityFreamework
{
    public class EfCarrierConfigurationsDal : GenericRepository<CarrierConfigurations>, ICarrierConfigurationsDal
    {
        public CarrierConfigurations GetCarrierConfigurationsWithGuide(int id)
        {
            using (var c = new Context())
            {
                return c.CarrierConfigurations.Where(x => x.CarrierConfigurationId == id).Include(x => x.Carrier).FirstOrDefault();
            }
        }
    }
}

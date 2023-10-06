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
    public class EfCarrierDal : GenericRepository<Carrier>, ICarrierDal
    {
        public Carrier GetCarrierWithGuide(int id)
        {
            using (var c = new Context())
            {
                return c.Carrier.Where(x => x.CarrierId == id).Include(x => x.CarrierConfiguration).FirstOrDefault();
            }
        }
    }
}

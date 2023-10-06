using EncodeEntityLayer.Concrete;
using EnocaBusinessLayer.Abctract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnocaBusinessLayer.Concrete
{
    public class CarrierManager : ICarrierService
    {
        ICarrierService _carrierService;
        public List<Carrier> GetList()
        {
            return _carrierService.GetList();
        }

        public void TAdd(Carrier t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Carrier t)
        {
            throw new NotImplementedException();
        }

        public Carrier TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Carrier t)
        {
            throw new NotImplementedException();
        }
    }
}

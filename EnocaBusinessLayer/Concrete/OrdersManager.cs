using EncodeEntityLayer.Concrete;
using EnocaBusinessLayer.Abctract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnocaBusinessLayer.Concrete
{
    public class OrdersManager : IOrdersService
    {
        public List<Orders> GetList()
        {
            throw new NotImplementedException();
        }

        public void TAdd(Orders t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Orders t)
        {
            throw new NotImplementedException();
        }

        public Orders TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Orders t)
        {
            throw new NotImplementedException();
        }
    }
}

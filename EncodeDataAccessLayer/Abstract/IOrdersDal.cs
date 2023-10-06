using DataAccessLayer.Abstract;
using EncodeEntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnocaDataAccessLayer.Abstract
{
    public interface IOrdersDal: IGenericDal<Orders>
    {
    }
}

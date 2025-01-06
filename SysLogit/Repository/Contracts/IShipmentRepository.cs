using SysLogit.Models;
using SysLogit.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysLogit.Repository.Contracts
{
    public interface IShipmentRepository
    {
        Response<IEnumerable<Shipment>> GetAll();
        Response<Shipment> GetById(int id);
        Response<string> Add(Shipment shipment);
        Response<string> Update(Shipment shipment);
        Response<string> Delete(int id);
    }
}

using SysLogit.Models;
using SysLogit.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysLogit.Business.Contracts
{
    public interface IShipmentService
    {
        Response<IEnumerable<Shipment>> GetAllShipments();
        Response<Shipment> GetShipmentById(int id);
        Response<string> AddShipment(Shipment Shipment);
        Response<string> UpdateShipment(Shipment Shipment);
        Response<string> DeleteShipment(int id);
    }
}

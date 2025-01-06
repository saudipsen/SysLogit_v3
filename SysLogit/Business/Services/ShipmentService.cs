using SysLogit.Business.Contracts;
using SysLogit.Models;
using SysLogit.Repository.Contracts;
using SysLogit.Repository.Contracts.SysLogit.Repository.Contracts;
using SysLogit.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysLogit.Business.Services
{
    public class ShipmentService : IShipmentService
    {
        private readonly IShipmentRepository _repository;

        public ShipmentService(IShipmentRepository repository)
        {
            _repository = repository;
        }

        public Response<IEnumerable<Shipment>> GetAllShipments()
        {
            return _repository.GetAll();
        }

        public Response<Shipment> GetShipmentById(int id)
        {
            return _repository.GetById(id);
        }

        public Response<string> AddShipment(Shipment shipment)
        {
            return _repository.Add(shipment);
        }

        public Response<string> UpdateShipment(Shipment shipment)
        {
            return _repository.Update(shipment);
        }

        public Response<string> DeleteShipment(int id)
        {
            return _repository.Delete(id);
        }
    }
}

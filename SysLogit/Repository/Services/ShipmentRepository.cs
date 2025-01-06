using SysLogit.Models;
using SysLogit.Repository.Contracts;
using SysLogit.Repository.Contracts.SysLogit.Repository.Contracts;
using SysLogit.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SysLogit.Repository.Services
{
    public class ShipmentRepository : IShipmentRepository
    {
        private readonly AppDbContext _context;

        public ShipmentRepository(AppDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public Response<IEnumerable<Shipment>> GetAll()
        {
            try
            {
                var shipments = _context.Shipments.ToList();
                return shipments.Any()
                    ? new Response<IEnumerable<Shipment>>(true, "Shipments retrieved successfully.", shipments)
                    : new Response<IEnumerable<Shipment>>(false, "No shipments found.");
            }
            catch (Exception ex)
            {
                Logger.LogError(nameof(GetAll), ex);
                return new Response<IEnumerable<Shipment>>(false, "An error occurred while retrieving shipments.");
            }
        }

        public Response<Shipment> GetById(int id)
        {
            try
            {
                var shipment = _context.Shipments.Find(id);
                return shipment != null
                    ? new Response<Shipment>(true, "Shipment retrieved successfully.", shipment)
                    : new Response<Shipment>(false, "Shipment not found.");
            }
            catch (Exception ex)
            {
                Logger.LogError(nameof(GetById), ex);
                return new Response<Shipment>(false, "An error occurred while retrieving the shipment.");
            }
        }

        public Response<string> Add(Shipment shipment)
        {
            try
            {
                if (shipment == null) return new Response<string>(false, "Invalid shipment data.");
                _context.Shipments.Add(shipment);
                _context.SaveChanges();
                return new Response<string>(true, "Shipment added successfully.");
            }
            catch (Exception ex)
            {
                Logger.LogError(nameof(Add), ex);
                return new Response<string>(false, "An error occurred while adding the shipment.");
            }
        }

        public Response<string> Update(Shipment shipment)
        {
            try
            {
                if (shipment == null) return new Response<string>(false, "Invalid shipment data.");
                var existingShipment = _context.Shipments.Find(shipment.ShipmentId);
                if (existingShipment == null) return new Response<string>(false, "Shipment not found.");
                _context.Entry(existingShipment).CurrentValues.SetValues(shipment);
                _context.SaveChanges();
                return new Response<string>(true, "Shipment updated successfully.");
            }
            catch (Exception ex)
            {
                Logger.LogError(nameof(Update), ex);
                return new Response<string>(false, "An error occurred while updating the shipment.");
            }
        }

        public Response<string> Delete(int id)
        {
            try
            {
                var shipment = _context.Shipments.Find(id);
                if (shipment == null) return new Response<string>(false, "Shipment not found.");
                _context.Shipments.Remove(shipment);
                _context.SaveChanges();
                return new Response<string>(true, "Shipment deleted successfully.");
            }
            catch (Exception ex)
            {
                Logger.LogError(nameof(Delete), ex);
                return new Response<string>(false, "An error occurred while deleting the shipment.");
            }
        }
    }
}



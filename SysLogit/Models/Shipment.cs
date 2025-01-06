using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysLogit.Models
{
    public class Shipment
    {
        public int ShipmentId { get; set; }
        public string ShipmentDescription { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string CreatedBy { get; set; }
        public int ProductId { get; set; }
        public string ConsignmentId { get; set; }

        public virtual Product Product { get; set; }

        public int ProductQnty { get; set; }
    }

}

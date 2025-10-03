using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionApp.Shared.Models.Orders
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime ExecutionDate { get; set; }
        public string OrderName { get; set; }
        public string OrderNumber { get; set; }
        public int QuantityOrdered { get; set; }
        public int QuantityPlanned { get; set; }
        public int QuantityExecuted { get; set; }

        // nawigacja do pozycji
        public List<OrderItem> Items { get; set; } = new();
    }
}

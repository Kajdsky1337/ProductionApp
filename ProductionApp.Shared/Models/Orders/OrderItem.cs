using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionApp.Shared.Models.Orders
{
    public class OrderItem
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public string Index { get; set; }          // np. “73348”
        public string Name { get; set; }           // nazwa detalu
        public string PartNumber { get; set; }     // “ZW01818.01”
        public int StockMin { get; set; }          // stan min
        public int Stock { get; set; }             // stan MAG
        public DateTime OrderDate { get; set; }    // z nagłówka
        public DateTime ExecutionDate { get; set; }// z nagłówka
        public int QuantityOrdered { get; set; }   // z nagłówka
        public int QuantityPlanned { get; set; }   // edytowalne
        public int QuantityExecuted { get; set; }  // wyświetlane
    }
}

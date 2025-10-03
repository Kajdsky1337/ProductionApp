using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionApp.Shared.Models.Plannings
{
    public class Planning
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Description { get; set; }
        public int WeekNumber { get; set; } // ISO week number
        public int Year { get; set; } // Year of the planning
        public int ProductionLineId { get; set; } // Foreign key to ProductionLine
        public int OrderId { get; set; } // Foreign key to Order
        public int QuantityPlanned { get; set; }
        public int QuantityExecuted { get; set; }
        public string Status { get; set; } // e.g., Planned, InProgress, Completed
    }
}

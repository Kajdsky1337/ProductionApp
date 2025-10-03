using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionApp.Shared.Models.Plannings
{
    public class WeeklyPlanItem
    {
        public int Id { get; set; }
        public int WeeklyPlanId { get; set; }
        public WeeklyPlan WeeklyPlan { get; set; }

        public int OrderId { get; set; }              // odniesienie do zamówienia
        public int OrderItemId { get; set; }          // konkretna pozycja z OrderItems

        public int QuantityToPlan { get; set; }       // ile planujesz w tym tygodniu
        public bool Started { get; set; }             // Otw T (otworzone)
        public bool Finished { get; set; }            // Otw D (zamknięte)
        public bool Confirmed { get; set; }           // Zatwierdź ➔ Zak
    }

}

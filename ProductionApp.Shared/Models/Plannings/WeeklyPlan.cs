using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionApp.Shared.Models.Plannings
{
    public class WeeklyPlan
    {
        public int Id { get; set; }
        public int Year { get; set; }
        public int WeekNumber { get; set; }
        public string WorkstationCode { get; set; }   //ST-15, ST-05 itp.

        public List<WeeklyPlanItem> Items { get; set; } = new();
    }

}

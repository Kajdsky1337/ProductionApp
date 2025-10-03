using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionApp.Shared.DTOs.Maintenance
{  
    public class MesDataDto
    {
        public int Id { get; set; }
        public int OrderItemId { get; set; }      // powiązanie z OrderItem
        public DateTime Timestamp { get; set; }   // kiedy odczyt
        public int CycleCount { get; set; }       // liczba cykli
        public double RunTimeSeconds { get; set; }// czas pracy maszyny
        public string MachineCode { get; set; }   // np. ST-15
                                                  // dodaj inne pola wedle potrzeb
    }

}

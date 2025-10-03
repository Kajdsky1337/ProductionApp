using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionApp.Shared.Models.Productions
{
    public class Production
    {
        public int Id { get; set; }

        // Kto rejestruje („Rejestrator”)
        public string Registrar { get; set; }

        // Kiedy i na jakiej zmianie
        public DateOnly ProductionDate { get; set; }
        public int Shift { get; set; }          // 1 lub 2

        // Powiązanie z zamówieniem i stanowiskiem
        public int OrderId { get; set; }
        public string WorkstationCode { get; set; }

        // Szczegóły
        public string PartName { get; set; }
        public string PartNumber { get; set; }
        public int WorkerId { get; set; }       // np. FK do tabeli Pracownicy
        public string OperationCode { get; set; }

        public decimal OperationTime { get; set; }  // czas
        public int QuantityProduced { get; set; }   // Ilość wyk.
        public int NumberOfBad { get; set; }    // Ilość złych 
        public int CavityCount { get; set; }        // Ilość gniazd

        public string BatchNumber { get; set; }     // Partia produkcji
        public string Notes { get; set; }           // Uwagi
    }
}

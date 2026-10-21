using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabinetMedical.Models
{
    public class Reteta
    {
        public int Id { get; set; }
        public int IdProgramare { get; set; }
        public DateTime DataEliberarii { get; set; }
        public string Medicamente { get; set; }
        public string Observatii { get; set; }

        public string NumePacient { get; set; }
        public string NumeMedic { get; set; }
    }
}

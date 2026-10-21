using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabinetMedical.Models
{
    public class Programare
    {
        public int Id { get; set; }
        public int IdPacient { get; set; }
        public int IdMedic {  get; set; }
        public DateTime DataProgramarii { get; set; }
        public string Diagnostic {  get; set; }
        public string Observatii { get; set; }
        public string NumePacient { get; set; }
        public string NumeMedic { get; set; }

        public override string ToString()
        {
            return Id + " - " + NumePacient + " - " + NumeMedic + " - " + DataProgramarii.ToShortDateString();
        }

    }
}

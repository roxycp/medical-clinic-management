using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabinetMedical.Models
{
    public class Medic
    {
        public int Id { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Specialitate { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }

        public string NumeComplet
        {
            get
            {
                return Nume + " " + Prenume;
            }
        }

    }
}

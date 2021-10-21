using System;
using System.Collections.Generic;
using System.Text;

namespace MyHomeProject.Core.Models
{
    public class ProgrammeImmobilier
    {
        public int ProgrammeImmobilierID { get; set; }
        public string CodeProgrammeImmobilier { get; set; }
        public string Libelle { get; set; }
        public DateTime DateDebutProgramme { get; set; }
        public int QuartierID { get; set; }
        public virtual Quartier Quartier { get; set; }
        public virtual ICollection<Propriete> Proprietes { get; set; }
        public bool EstActif { get; set; }

    }
}

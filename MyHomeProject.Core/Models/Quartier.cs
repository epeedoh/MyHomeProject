using System;
using System.Collections.Generic;

using System.Text;

namespace MyHomeProject.Core.Models
{
    public class Quartier
    {

        public int QuartierID { get; set; }
        public string CodeQuartier { get; set; }
        public string Libelle { get; set; }
        public virtual Commune Commune { get; set; }
        public int CommuneID { get; set; }

        public virtual ICollection<Propriete> Proprietes { get; set; }
        public virtual ICollection<ProgrammeImmobilier> ProgrammeImmobiliers { get; set; }
    }
}

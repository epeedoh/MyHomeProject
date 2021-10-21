using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyHomeProject.Data.Entities
{
    public class Quartier
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int QuartierID { get; set; }
        public string CodeQuartier { get; set; }
        public string Libelle { get; set; }
        public virtual Commune Commune { get; set; }
        public int CommuneID { get; set; }

        public virtual ICollection<Propriete> Proprietes { get; set; }
        public virtual ICollection<ProgrammeImmobilier> ProgrammeImmobiliers { get; set; }
    }
}

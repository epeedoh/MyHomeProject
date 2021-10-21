using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyHomeProject.Data.Entities
{
    public class ProgrammeImmobilier
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
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

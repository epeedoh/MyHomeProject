using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyHomeProject.Data.Entities
{
   public class Commune
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CommuneID { get; set; }
        public string CodeCommune { get; set; }
        public string Libelle { get; set; }
        public virtual Ville Ville { get; set; }
        public int VilleID { get; set; }
        public virtual ICollection<Quartier> Quartiers { get; set; }
    }
}

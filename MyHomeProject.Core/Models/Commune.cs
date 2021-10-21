using System;
using System.Collections.Generic;
using System.Text;

namespace MyHomeProject.Core.Models
{
   public class Commune
    {
        public int CommuneID { get; set; }
        public string CodeCommune { get; set; }
        public string Libelle { get; set; }
        public virtual Ville Ville { get; set; }
        public int VilleID { get; set; }
        public virtual ICollection<Quartier> Quartiers { get; set; }
    }
}

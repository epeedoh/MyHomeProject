using System;
using System.Collections.Generic;
using System.Text;

namespace MyHomeProject.Core.Models
{
    public class Pays
    {

        public int PaysID { get; set; }
        public string CodePays { get; set; }
        public string Libelle { get; set; }
        public string Nationalite { get; set; }
        public string Capital { get; set; }

        public byte[] Image { get; set; }
        public virtual ICollection<Ville> Villes { get; set; }

      
    }
}

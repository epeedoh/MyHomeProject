using System;
using System.Collections.Generic;
using System.Text;

namespace MyHomeProject.Core.Models
{
    public class EtatTransaction
    {
        public int EtatTransactionID { get; set; }
        public string CodeEtatTransaction { get; set; }
        public string Libelle { get; set; }
        public ICollection<Propriete> Proprietes { get; set; }
    }
}

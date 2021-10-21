using System;
using System.Collections.Generic;

using System.Text;

namespace MyHomeProject.Core.Models
{
    public class TypeTransaction
    {
 
        public int TypeTransactionID { get; set; }
        public string Libelle { get; set; }
        public ICollection<Propriete> Proprietes { get; set; }
    }
}

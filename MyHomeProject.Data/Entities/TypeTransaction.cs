using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyHomeProject.Data.Entities
{
    public class TypeTransaction
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TypeTransactionID { get; set; }
        public string Libelle { get; set; }
        public ICollection<Propriete> Proprietes { get; set; }
    }
}

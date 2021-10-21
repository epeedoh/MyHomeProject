using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyHomeProject.Data.Entities
{
    public class TypePropriete
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TypeProprieteID { get; set; }
        public string TypeName { get; set; }
        public ICollection<Propriete> Proprietes { get; set; }
    }
}

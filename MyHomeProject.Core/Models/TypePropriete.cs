using System;
using System.Collections.Generic;
using System.Text;

namespace MyHomeProject.Core.Models
{
    public class TypePropriete
    {

        public int TypeProprieteID { get; set; }
        public string TypeName { get; set; }
        public ICollection<Propriete> Proprietes { get; set; }
    }
}

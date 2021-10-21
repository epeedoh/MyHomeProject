using System;
using System.Collections.Generic;

using System.Text;

namespace MyHomeProject.Core.Models
{
    public class TypeStanding
    {

        public int TypeStandingID { get; set; }
        public string Libelle { get; set; }
        public ICollection<Propriete> Proprietes { get; set; }
    }
}

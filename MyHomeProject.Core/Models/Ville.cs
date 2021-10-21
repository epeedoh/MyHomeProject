using System;
using System.Collections.Generic;

using System.Text;

namespace MyHomeProject.Core.Models
{
    public class Ville
    {

        public int VilleID { get; set; }
        public string CodeVille { get; set; }
        public string Libelle { get; set; }
        public Pays Pays { get; set; }
        public int PaysID { get; set; }
    }
}
 
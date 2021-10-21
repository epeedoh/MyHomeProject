using System;
using System.Collections.Generic;

using System.Text;

namespace MyHomeProject.Core.Models
{
    public class Sexe
    {


        public int SexeID { get; set; }
        public string CodeSexe { get; set; }
        public string Libelle { get; set; }
        public DateTime DateCreation { get; set; }
        public ICollection<Personne> Personnes { get; set; }
    }
}

using System;
using System.Collections.Generic;

using System.Text;

namespace MyHomeProject.Core.Models
{
    public class Societe
    {

        public int SocieteID { get; set; }
        public string CodeSociete { get; set; }
        public string NomSociete { get; set; }
        public string DetailsSiege { get; set; }
        public string contact { get; set; }
        public string Logo { get; set; }
        public int QuartierID { get; set; }
        public virtual Quartier Quartier { get; set; }
        public bool EstActif { get; set; }
    }
}

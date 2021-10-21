using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyHomeProject.Data.Entities
{
    public class Societe
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
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

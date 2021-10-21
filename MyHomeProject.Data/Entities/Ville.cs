using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyHomeProject.Data.Entities
{
    public class Ville
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int VilleID { get; set; }
        public string CodeVille { get; set; }
        public string Libelle { get; set; }
        public Pays Pays { get; set; }
        public int PaysID { get; set; }
    }
}
 
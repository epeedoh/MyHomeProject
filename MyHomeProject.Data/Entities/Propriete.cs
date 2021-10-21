using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyHomeProject.Data.Entities
{
   public class Propriete
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProprieteID { get; set; }
        public string ProprieteNom { get; set; }
        public string Image { get; set; }
        public ICollection<Image> Images { get; set; }
        public string Addresse { get; set; }
        public string Localisation { get; set; }
        public string Prix { get; set; }
        public string Lit { get; set; }
        public string NbreChambre { get; set; }
        public string NbreSalon { get; set; }
        public Boolean ExistTerraste { get; set; }
        public string NbreSalleDeBain { get; set; }
        public string Superficie { get; set; }
        public string Details { get; set; }
        public DateTime DateCreation { get; set; }
        public int  TypeProprieteID { get; set; }
        public virtual TypePropriete TypePropriete { get; set; }

        public int ProgrammeImmobilierID { get; set; }
        public virtual ProgrammeImmobilier ProgrammeImmobilier { get; set; }

        public int QuartierID { get; set; }
        public virtual Quartier Quartier { get; set; }

        public int TypeTransactionID { get; set; }
        public virtual TypeTransaction TypeTransaction { get; set; }

        public int TypeStandingID { get; set; }
        public virtual TypeStanding TypeStanding { get; set; }

        public int EtatTransactionID { get; set; }
        public virtual EtatTransaction EtatTransaction { get; set; }

    }
}

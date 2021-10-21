using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyHomeProject.API.Resources
{
    public class ProprieteResource
    {
        public int ProprieteID { get; set; }
        public string ProprieteNom { get; set; }
        public string Image { get; set; }
       // public ICollection<Image> Images { get; set; }
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

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyHomeProject.API.Resources
{
    public class DetailsPropertyResponse : ApiReponse
    {
        public ProprieteResource Propriete { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace MyHomeProject.Models
{
    public class DetailsPropertyResponse: ApiReponse
    {
        public ProprieteResource Propriete { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace MyHomeProject.Models
{
    public class PropertyResponse: ApiReponse
    {
        public IEnumerable<ProprieteResource> Proprietes { get; set; }
    }
}

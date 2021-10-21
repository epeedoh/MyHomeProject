using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyHomeProject.API.Resources
{
    public class PropertyResponse : ApiReponse
    {
        public IEnumerable<ProprieteResource> Proprietes { get; set; }
    }
}

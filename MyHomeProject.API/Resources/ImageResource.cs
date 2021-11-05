using MyHomeProject.Core.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyHomeProject.API.Resources
{
    public class ImageResource
    {
        public int ImageID { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public DateTime DateAjout { get; set; }
        public bool IsMain { get; set; }

        public int ProprieteID { get; set; }
        //[JsonIgnore]
        //public virtual Propriete Propriete { get; set; }
    }
}

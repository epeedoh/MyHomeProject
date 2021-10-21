using System;
using System.Collections.Generic;
using System.Text;

namespace MyHomeProject.Core.Models
{
    public class Image
    {
        public int ImageID { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public DateTime DateAjout { get; set; }
        public bool IsMain { get; set; }

        public int ProprieteID { get; set; }
        public virtual Propriete Propriete { get; set; }

    }
}

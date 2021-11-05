using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyHomeProject.API.Resources
{
    public class ImageResponse: ApiReponse
    {
        public IEnumerable<ImageResource> Images { get; set; }
    }
}

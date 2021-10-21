using AutoMapper;
using MyHomeProject.API.Resources;
using MyHomeProject.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyHomeProject.API.Mapping
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            // Domain(base de donnée )  vers Resource
            CreateMap<Propriete, ProprieteResource>();

            // Resources vers Domain ou la base de données

            CreateMap<ProprieteResource, Propriete>();
        }
    }
}

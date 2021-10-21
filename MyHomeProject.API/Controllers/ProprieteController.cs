using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyHomeProject.API.Resources;
using MyHomeProject.Core.Models;
using MyHomeProject.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyHomeProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProprieteController : ControllerBase
    {
        private readonly IProprieteService _servicePropriete;
        private readonly IMapper _mapperService;
        public ProprieteController(IProprieteService servicePropriete, IMapper mapperService)
        {
            _servicePropriete = servicePropriete;
            _mapperService = mapperService;
        }

        //[HttpGet("")]
        //public async Task<ActionResult<IEnumerable<ProprieteResource>>> GetAllPropriete()
        //{
        //    var proprietes = await _servicePropriete.GetAllPropriete();
        //    var proprieteResources = _mapperService.Map<IEnumerable<Propriete>, IEnumerable<ProprieteResource>>(proprietes);
        //    return Ok(proprieteResources);
        //}

 
         [HttpPost("Propriete")]
        public async Task<PropertyResponse> GetAllPropriete()
        {
            PropertyResponse response = new PropertyResponse();

            var proprietes = await _servicePropriete.GetAllPropriete();
            var proprieteResources = _mapperService.Map<IEnumerable<Propriete>, IEnumerable<ProprieteResource>>(proprietes);
            response.Proprietes = proprieteResources;
            return response;
        }

        [HttpPost("GetAnPropertyByIdPropriete")]
        public async Task<DetailsPropertyResponse> GetAnPropertyByIdPropriete(int idPropertySelect)
        {
            DetailsPropertyResponse response = new DetailsPropertyResponse();

            var anProprietes = await _servicePropriete.GetProprieteById(idPropertySelect);
            var proprieteResources = _mapperService.Map<Propriete, ProprieteResource>(anProprietes);

            response.Propriete = proprieteResources;

            return response;


        }

    }
}

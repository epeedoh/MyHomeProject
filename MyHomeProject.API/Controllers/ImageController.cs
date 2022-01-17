using AutoMapper;
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
    public class ImageController : ControllerBase
    {
        private readonly IimageService _serviceImage;
        private readonly IMapper _mapperService;

        public ImageController(IimageService serviceImage,IMapper mapperService)
        {
            _serviceImage = serviceImage;
            _mapperService = mapperService;
        }


        [HttpPost("GetAllImage")]
        public async Task<ImageResponse> GetAllImage()
        {
            ImageResponse response = new ImageResponse();

            var images = await _serviceImage.GetAllImage();
            var imageResources = _mapperService.Map<IEnumerable<Image>, IEnumerable<ImageResource>>(images);
            response.Images = imageResources;
            return response;
        }

        [HttpPost("GetAllImagesByPropertyId")]
        public async Task<ImageResponse> GetAllImagesByPropertyId(int idPropertySelect)
        {
            ImageResponse response = new ImageResponse();

            var anImage = await _serviceImage.GetAllImagesByPropertyIdAsync(idPropertySelect);
            var imageResources = _mapperService.Map<IEnumerable<Image>, IEnumerable<ImageResource> >(anImage);

            response.Images = imageResources;

            return response;


        }
    }
}

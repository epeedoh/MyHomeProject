using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MyHomeProject.Core;
using MyHomeProject.Core.Models;
using MyHomeProject.Core.Services;

namespace MyHomeProject.Services.Services
{
    public class ImagesService : IimageService
    {
        private readonly IUnitOfWork _unitOfwork;

        public ImagesService(IUnitOfWork unitOfwork)
        {
            _unitOfwork = unitOfwork;
        }

        public async Task DeleteImage(Image image)
        {
            _unitOfwork.Image.Remove(image);
            await _unitOfwork.CommitAsync();
        }

        public async Task<IEnumerable<Image>> GetAllImage()
        {
            return await _unitOfwork.Image.GetAllImagesAsync();
        }

        public async Task<IEnumerable<Image>> GetAllImagesByPropertyIdAsync(int id)
        {
            return await _unitOfwork.Image.GetAllImagesByPropertyIdAsync(id);
        }

        public async Task<Image> GetImageById(int id)
        {
            return await _unitOfwork.Image.GetByIdAsync(id);
        }

        public async Task<Image> SaveImage(Image newImage)
        {
            await _unitOfwork.Image.AddAsync(newImage);
            await _unitOfwork.CommitAsync();
            return newImage;
        }

        public async Task UpdateImage(Image imageUpdated, Image image)
        {
            imageUpdated.Url = image.Url;
            imageUpdated.ImageID = image.ImageID;

            await _unitOfwork.CommitAsync();
        }
    }
}

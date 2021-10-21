using MyHomeProject.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyHomeProject.Core.Services
{
    public interface IimageService
    {
        Task<IEnumerable<Image>> GetAllImage();
        Task<Image> GetImageById(int id);
        Task<Image> SaveImage(Image newImage);
        Task UpdateImage(Image imageUpdated, Image image);
        Task DeleteImage(Image image);

    }
}

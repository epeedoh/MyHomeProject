using MyHomeProject.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyHomeProject.Core.Repositories
{
    public interface IimageRepository: IRepository<Image>
    {
        Task<IEnumerable<Image>> GetAllImagesAsync();
        Task<Image> GetAllImagesByIdAsync(int id);
        Task<IEnumerable<Image>> GetAllImagesByPropertyIdAsync(int id);
    }
}

using Microsoft.EntityFrameworkCore;
using MyHomeProject.Core.Models;
using MyHomeProject.Core.Repositories;
using MyHomeProject.Data.DataContext;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyHomeProject.Data.Repositories
{
    public class ImageRepository: Repository<Image>,IimageRepository
    {
        private DatabaseContext DatabaseContext
        {
            get { return Context as DatabaseContext;  }
        }

        public ImageRepository(DatabaseContext context) :base(context)
        {

        }

        public async Task<IEnumerable<Image>> GetAllImagesAsync()
        {
            return await DatabaseContext.Images
                //.Include(a => a.Propriete)
                .ToListAsync();
        }

        public Task<Image> GetAllImagesByIdAsync(int id)
        {
            return DatabaseContext.Images
                   .SingleOrDefaultAsync(a => a.ImageID == id);
        }

        async Task<IEnumerable<Image>> IimageRepository.GetAllImagesAsync()
        {
            return await DatabaseContext.Images
                //.Include(a => a.Propriete)
                .ToListAsync();
        }

        Task<Image> IimageRepository.GetAllImagesByIdAsync(int id)
        {
            return DatabaseContext.Images
          //.Include(a => a.Propriete)
         .SingleOrDefaultAsync(a => a.ProprieteID == id);
        }



    }
}

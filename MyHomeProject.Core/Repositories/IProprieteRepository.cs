using MyHomeProject.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyHomeProject.Core.Repositories
{
    public interface IProprieteRepository: IRepository<Propriete>
    {
        Task<IEnumerable<Propriete>> GetAllProprietesAsync();
        Task<Propriete> GetAllProprietesAsync(int id);
    }
}

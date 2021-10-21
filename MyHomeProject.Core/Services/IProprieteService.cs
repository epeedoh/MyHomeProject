using MyHomeProject.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyHomeProject.Core.Services
{
    public interface IProprieteService
    {
        Task<IEnumerable<Propriete>> GetAllPropriete();
        Task<Propriete> GetProprieteById(int id);
        Task<Propriete> CreatePropriete(Propriete newPropriete);
        Task UpdatePropriete(Propriete proprieteupdated, Propriete propriete);
        Task DeletePropriete(Propriete propriete);
    }
}

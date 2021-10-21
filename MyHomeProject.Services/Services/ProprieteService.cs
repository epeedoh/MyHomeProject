using MyHomeProject.Core;
using MyHomeProject.Core.Models;
using MyHomeProject.Core.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyHomeProject.Services.Services
{
    public class ProprieteService : IProprieteService
    {
        private readonly IUnitOfWork _unitOfwork;
        public ProprieteService(IUnitOfWork unitOfwork)
        {
            _unitOfwork = unitOfwork;
        }

        public async Task<Propriete> CreatePropriete(Propriete newPropriete)
        {
            await _unitOfwork.Propriete.AddAsync(newPropriete);
            await _unitOfwork.CommitAsync();
            return newPropriete;
        }

        public async Task DeletePropriete(Propriete propriete)
        {
             _unitOfwork.Propriete.Remove(propriete);
            await _unitOfwork.CommitAsync();
        }

        public async Task<IEnumerable<Propriete>> GetAllPropriete()
        {
          return await _unitOfwork.Propriete.GetAllProprietesAsync();
        }

        public async Task<Propriete> GetProprieteById(int id)
        {
            return await _unitOfwork.Propriete.GetByIdAsync(id);
        }

        public async Task UpdatePropriete(Propriete proprieteupdated, Propriete propriete)
        {
            proprieteupdated.ProprieteNom = propriete.ProprieteNom;
            proprieteupdated.ProprieteID = propriete.ProprieteID;

            await _unitOfwork.CommitAsync();
        }
    }
}

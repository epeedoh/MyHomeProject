using MyHomeProject.Core.Models;
using MyHomeProject.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyHomeProject.Data.DataContext;

namespace MyHomeProject.Data.Repositories
{
    public class ProprieteRepository : Repository<Propriete>, IProprieteRepository
    {

        private DatabaseContext DatabaseContext
        {
            get { return Context as DatabaseContext; }
        }

        public ProprieteRepository(DatabaseContext context) 
            : base(context)
        {

        }
        //public Task AddAsync(Propriete entity)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task AddRangeAsync(IEnumerable<Propriete> entities)
        //{
        //    throw new NotImplementedException();
        //}

        //public IEnumerable<Propriete> Find(Expression<Func<Propriete, bool>> Predicate)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<IEnumerable<Propriete>> GetAllAsync()
        //{
        //    throw new NotImplementedException();
        //}

        public async Task<IEnumerable<Propriete>> GetAllProprietesAsync()
        {
            return await DatabaseContext.Proprietes
                .Include(a => a.ProgrammeImmobilier)
                .ToListAsync();
        }

        public Task<Propriete> GetProprietesByIdAsync(int id)
        {
            return DatabaseContext.Proprietes
                   .SingleOrDefaultAsync(a=>a.ProprieteID == id);
        }

        async Task<IEnumerable<Propriete>> IProprieteRepository.GetAllProprietesAsync()
        {
            return await DatabaseContext.Proprietes
                .Include(a => a.ProgrammeImmobilier)
                .ToListAsync();
        }

        Task<Propriete> IProprieteRepository.GetAllProprietesAsync(int id)
        {
            return DatabaseContext.Proprietes
          .Include(a => a.ProgrammeImmobilier)
         .SingleOrDefaultAsync(a => a.ProprieteID == id);
        }

        //public ValueTask<Propriete> GetByIdAsync(int id)
        //{
        //    throw new NotImplementedException();
        //}

        //public void Remove(Propriete entity)
        //{
        //    throw new NotImplementedException();
        //}

        //public void RemoveRange(IEnumerable<Propriete> entities)
        //{
        //    throw new NotImplementedException();
        //}

        //public IEnumerable<Propriete> SingleOrDefaultAsync(Expression<Func<Propriete, bool>> Predicate)
        //{
        //    throw new NotImplementedException();
        //}
    }
}

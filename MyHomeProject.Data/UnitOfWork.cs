using MyHomeProject.Core;
using MyHomeProject.Core.Repositories;
using MyHomeProject.Data.DataContext;
using MyHomeProject.Data.Repositories;
using System;
using System.Threading.Tasks;

namespace MyHomeProject.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DatabaseContext _context;
        private IProprieteRepository _proprieteRepository;
        //     public IProprieteRepository Propriete => throw new NotImplementedException();

        public UnitOfWork(DatabaseContext context)
        {
            this._context = context;
        }

        public IProprieteRepository Propriete => _proprieteRepository = _proprieteRepository ?? new ProprieteRepository(_context);

        public async Task<int> CommitAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}

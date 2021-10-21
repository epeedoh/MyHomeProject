using MyHomeProject.Core.Repositories;
using System;
using System.Threading.Tasks;

namespace MyHomeProject.Core
{
    public interface IUnitOfWork : IDisposable
    {
        IProprieteRepository Propriete { get; }
        IimageRepository Image { get; }
        Task<int> CommitAsync();
    }
}

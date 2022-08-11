using Microsoft.EntityFrameworkCore;

namespace MicroServices.Auth.Infrastructure.Repository
{
    public interface IUnitOfWork
    {
        DbContext GetContext { get; }

        IGenericRepository<T> Repository<T>() where T : class;
        void SaveChanges();
        Task<int> SaveChangesAsync();
    }
}
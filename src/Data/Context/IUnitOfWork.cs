using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Data.Context
{
    public interface IUnitOfWork
    {
        public DbContext Context();
        public Task BeginAsync();
        public Task CommitAsync();
        public Task RollbackAsync();
    }
}

using System.Threading.Tasks;

namespace Data.Context
{
    public interface IUnitOfWork
    {
        public EfCrudContext Context();
        public Task BeginAsync();
        public Task CommitAsync();
        public Task RollbackAsync();
    }
}

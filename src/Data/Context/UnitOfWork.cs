using Microsoft.EntityFrameworkCore.Storage;
using System.Threading.Tasks;
using Utils.Extensions;

namespace Data.Context
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly EfCrudContext context;
        private IDbContextTransaction? transaction;

        public UnitOfWork() => context = new EfCrudContext();

        public EfCrudContext Context() => context;

        public async Task BeginAsync()
        {
            if (transaction.IsNull())
                transaction = await context.Database.BeginTransactionAsync();
        }

        public async Task CommitAsync()
        {
            if (transaction.IsNull())
                return;

            await transaction.CommitAsync();
            CloseTransaction();
        }

        public async Task RollbackAsync()
        {
            if (transaction.IsNull())
                return;

            await transaction.RollbackAsync();
            CloseTransaction();
        }

        private void CloseTransaction()
        {
            transaction?.Dispose();
            transaction = null;
        }

        ~UnitOfWork()
        {
            transaction?.Dispose();
            context.Dispose();
        }
    }
}

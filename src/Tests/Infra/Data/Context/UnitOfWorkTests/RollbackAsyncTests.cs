using Moq;
using NUnit.Framework;
using System.Threading.Tasks;

namespace Tests.Infra.Data.Context.UnitOfWorkTests
{
    public class RollbackAsyncTests : BaseUnitOfWorkTests
    {
        [Test]
        public async Task Vai_executar_o_rollback()
        {
            await unitOfWork.BeginAsync();
            await unitOfWork.RollbackAsync();

            databaseFacade.Verify(d => d.BeginTransactionAsync(default), Times.Once);
            dbContextTransaction.Verify(d => d.RollbackAsync(default), Times.Once);
        }

        [Test]
        public async Task Nao_vai_executar_o_rollback_porque_nao_ha_transacao()
        {
            await unitOfWork.RollbackAsync();

            dbContextTransaction.Verify(d => d.RollbackAsync(default), Times.Never);
        }
    }
}

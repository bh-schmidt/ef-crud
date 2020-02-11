using Moq;
using NUnit.Framework;
using System.Threading.Tasks;

namespace Tests.Infra.Data.Context.UnitOfWorkTests
{
    public class CommitAsyncTests : BaseUnitOfWorkTests
    {
        [Test]
        public async Task Vai_executar_o_commit()
        {
            await unitOfWork.BeginAsync();
            await unitOfWork.CommitAsync();

            databaseFacade.Verify(d => d.BeginTransactionAsync(default), Times.Once);
            dbContextTransaction.Verify(d => d.CommitAsync(default), Times.Once);
        }

        [Test]
        public async Task Nao_vai_executar_o_commit_porque_nao_ha_transacao()
        {
            await unitOfWork.CommitAsync();

            dbContextTransaction.Verify(d => d.CommitAsync(default), Times.Never);
        }
    }
}

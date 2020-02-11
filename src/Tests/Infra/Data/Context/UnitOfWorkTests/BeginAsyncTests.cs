using Microsoft.EntityFrameworkCore.Infrastructure;
using Moq;
using NUnit.Framework;
using System.Threading.Tasks;

namespace Tests.Infra.Data.Context.UnitOfWorkTests
{
    public class BeginAsyncTests : BaseUnitOfWorkTests
    {
        [Test]
        public async Task Vai_iniciar_a_transacao_porque_nao_existe_uma_transacao()
        {
            await unitOfWork.BeginAsync();

            databaseFacade.Verify(d => d.BeginTransactionAsync(default), Times.Once);
        }

        [Test]
        public async Task Vai_iniciar_a_transacao_apenas_uma_vez()
        {
            await unitOfWork.BeginAsync();
            await unitOfWork.BeginAsync();

            databaseFacade.Verify(d => d.BeginTransactionAsync(default), Times.Once);
        }
    }
}



using Data.Context;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using Moq;
using NUnit.Framework;

namespace Tests.Infra.Data.Context.UnitOfWorkTests
{
    public abstract class BaseUnitOfWorkTests : BaseTests
    {
        protected UnitOfWork unitOfWork = null!;
        protected Mock<EfCrudContext> efCrudContext = null!;
        protected Mock<DatabaseFacade> databaseFacade = null!;
        protected Mock<IDbContextTransaction> dbContextTransaction = null!;

        [SetUp]
        public void Setup()
        {
            dbContextTransaction = new Mock<IDbContextTransaction>();
            efCrudContext = new Mock<EfCrudContext>();
            databaseFacade = new Mock<DatabaseFacade>(efCrudContext.Object);

            efCrudContext.Setup(e => e.Database)
                .Returns(databaseFacade.Object);

            unitOfWork = new UnitOfWork(efCrudContext.Object);

            databaseFacade.Setup(d => d.BeginTransactionAsync(default))
                .ReturnsAsync(dbContextTransaction.Object);
        }
    }
}

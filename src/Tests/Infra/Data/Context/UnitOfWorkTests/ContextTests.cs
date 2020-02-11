using Models.Caminhoes;
using NUnit.Framework;
using System.Linq;

namespace Tests.Infra.Data.Context.UnitOfWorkTests
{
    public class ContextTests : BaseUnitOfWorkTests
    {
        [Test]
        public void Vai_retornar_o_context()
        {
            var context = unitOfWork.Context();

            Assert.AreEqual(efCrudContext.Object, context);
        }
    }
}

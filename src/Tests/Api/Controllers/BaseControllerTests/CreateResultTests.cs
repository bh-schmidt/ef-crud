using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;

namespace Tests.Api.Controllers.BaseControllerTests
{
    [TestFixture]
    public class CreateResultTests
    {
        BaseControllerChild baseController = null!;

        [SetUp]
        public void Setup() => baseController = new BaseControllerChild();

        [Test]
        public void Vai_gerar_um_OkResult()
        {
            var resultado = baseController.ChildCreateResult();

            Assert.IsInstanceOf<OkResult>(resultado);
        }
    }
}

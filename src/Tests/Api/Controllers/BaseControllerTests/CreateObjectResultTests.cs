using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;

namespace Tests.Api.Controllers.BaseControllerTests
{
    public class CreateObjectResultTests : BaseTests
    {
        BaseControllerChild baseController = null!;

        [SetUp]
        public void Setup() => baseController = new BaseControllerChild();

        [Test]
        public void Vai_gerar_um_OkObjectResult()
        {
            string value = "123";

            var resultado = baseController.ChildCreateObjectResult(value);

            Assert.IsInstanceOf<OkObjectResult>(resultado);

            var valorRetornado = ObterObjeto(resultado);

            Assert.NotNull(valorRetornado);
            Assert.AreEqual(value, valorRetornado);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Models.Caminhoes;
using Moq;
using NUnit.Framework;
using System.Threading.Tasks;

namespace Tests.Api.Controllers.Caminhoes.CamihoesControllerTests
{
    public class ObterPorIdTests : BaseCaminhoesControllerTests
    {
        [Test]
        public async Task Vai_retornar_o_caminhao()
        {
            var caminhao = new Caminhao();

            obterCaminhaoPorId.Setup(o => o.ObterPor(It.IsAny<long>()))
                .ReturnsAsync(caminhao);

            var resultado = await caminhoesController.ObterPor(It.IsAny<long>());

            Assert.IsInstanceOf<OkObjectResult>(resultado);

            var objeto = ObterObjeto(resultado);

            Assert.NotNull(objeto);
            Assert.AreEqual(caminhao, objeto);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Models.Caminhoes;
using Moq;
using NUnit.Framework;
using System.Threading.Tasks;

namespace Tests.Api.Controllers.Caminhoes.CamihoesControllerTests
{
    public class ExcluirTests : BaseCaminhoesControllerTests
    {
        [Test]
        public async Task Vai_exluir_o_caminhao()
        {
            var caminhao = new Caminhao();

            excluirCaminhao.Setup(e => e.Excluir(It.IsAny<long>()))
                .ReturnsAsync(caminhao);

            var resultado = await caminhoesController.Exluir(It.IsAny<long>());

            Assert.IsInstanceOf<OkObjectResult>(resultado);

            var objeto = ObterObjeto(resultado);

            Assert.NotNull(objeto);
            Assert.AreEqual(caminhao, objeto);
        }
    }
}

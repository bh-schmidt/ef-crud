using Microsoft.AspNetCore.Mvc;
using Models.Caminhoes;
using Moq;
using NUnit.Framework;
using System.Threading.Tasks;

namespace Tests.Api.Controllers.Caminhoes.CamihoesControllerTests
{
    public class InserirTests : BaseCaminhoesControllerTests
    {
        [Test]
        public async Task Vai_inserir_o_caminhao()
        {
            var caminhao = new Caminhao();

            inserirCaminhao.Setup(i => i.Inserir(caminhao))
                .ReturnsAsync(caminhao);

            var resultado = await caminhoesController.Inserir(caminhao);

            Assert.IsInstanceOf<OkObjectResult>(resultado);

            var objeto = ObterObjeto(resultado);

            Assert.NotNull(objeto);
            Assert.AreEqual(caminhao, objeto);
        }
    }
}

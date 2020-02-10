using Microsoft.AspNetCore.Mvc;
using Models.Caminhoes;
using Moq;
using NUnit.Framework;
using System.Threading.Tasks;

namespace Tests.Api.Controllers.Caminhoes.CamihoesControllerTests
{
    public class AtualizarTests : BaseCaminhoesControllerTests
    {
        [Test]
        public async Task Vai_atualizar_o_caminhao()
        {
            var caminhao = new Caminhao();

            atualizarCaminhao.Setup(i => i.Atualizar(caminhao))
                .ReturnsAsync(caminhao);

            var resultado = await caminhoesController.Atualizar(caminhao);

            Assert.IsInstanceOf<OkObjectResult>(resultado);

            var objeto = ObterObjeto(resultado);

            Assert.NotNull(objeto);
            Assert.AreEqual(caminhao, objeto);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
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
            var resultado = await caminhoesController.Exluir(It.IsAny<long>());

            Assert.IsInstanceOf<OkResult>(resultado);
        }
    }
}

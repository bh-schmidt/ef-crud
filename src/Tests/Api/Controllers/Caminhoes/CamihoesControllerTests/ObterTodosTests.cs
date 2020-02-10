using Api.Controllers.Caminhoes;
using Business.Caminhoes.AtualizarCaminhoes;
using Business.Caminhoes.ExcluirCaminhoes;
using Business.Caminhoes.InserirCaminhoes;
using Business.Caminhoes.ObterCaminhoes;
using Microsoft.AspNetCore.Mvc;
using Models.Caminhoes;
using Moq;
using NUnit.Framework;
using System.Linq;
using System.Threading.Tasks;

namespace Tests.Api.Controllers.Caminhoes.CamihoesControllerTests
{
    public class ObterTodosTests : BaseCaminhoesControllerTests
    {
        public async Task Vai_retornar_os_caminhoes()
        {
            var caminhoes = Enumerable.Repeat(new Caminhao(), 10);

            obterTodosOsCaminhoes.Setup(s => s.ObterTodos())
                .ReturnsAsync(caminhoes);

            var resultado = await caminhoesController.ObterTodos();

            Assert.IsInstanceOf<OkObjectResult>(resultado);

            var caminhoesRetornados = ObterObjeto(resultado);

            Assert.AreEqual(caminhoes, caminhoesRetornados);
        }
    }
}

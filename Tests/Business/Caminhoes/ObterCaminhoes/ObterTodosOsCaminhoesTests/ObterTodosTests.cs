using Business.Caminhoes.ObterCaminhoes;
using Data.Repositories.Caminhoes;
using Models.Caminhoes;
using Moq;
using NUnit.Framework;
using System.Threading.Tasks;

namespace Tests.Business.Caminhoes.ObterCaminhoes.ObterTodosOsCaminhoesTests
{
    public class ObterTodosTests : BaseTests
    {
        ObterTodosOsCaminhoes obterTodosOsCaminhoes = null!;
        Mock<ICaminhaoRepository> caminhaoRepository = null!;

        [SetUp]
        public void Setup()
        {
            caminhaoRepository = new Mock<ICaminhaoRepository>();

            obterTodosOsCaminhoes = new ObterTodosOsCaminhoes(caminhaoRepository.Object);
        }

        [Test]
        public async Task Vai_retornar_todos_os_caminhoes()
        {
            var caminhoes = new Caminhao[] { new Caminhao() };

            caminhaoRepository.Setup(c => c.ObterTodos())
                .ReturnsAsync(caminhoes);

            var resultado = await obterTodosOsCaminhoes.ObterTodos();

            Assert.AreEqual(caminhoes, resultado);

            caminhaoRepository.Verify(c => c.ObterTodos(), Times.Once);
        }
    }
}

using Business.Caminhoes.ObterCaminhoes;
using Data.Repositories.Caminhoes;
using Models.Caminhoes;
using Moq;
using NUnit.Framework;
using System.Threading.Tasks;

namespace Tests.Business.Caminhoes.ObterCaminhoes.ObterCaminhaoPorIdTests
{
    public class ObterPorIdTests : BaseTests
    {
        ObterCaminhaoPorId obterCaminhaoPorId = null!;
        Mock<ICaminhaoRepository> caminhaoRepository = null!;

        [SetUp]
        public void Setup()
        {
            caminhaoRepository = new Mock<ICaminhaoRepository>();

            obterCaminhaoPorId = new ObterCaminhaoPorId(caminhaoRepository.Object);
        }

        [Test]
        public async Task Vai_retornar_todos_os_caminhoes()
        {
            var caminhao = new Caminhao();

            caminhaoRepository.Setup(c => c.ObterPor(It.IsAny<long>()))
                .ReturnsAsync(caminhao);

            var resultado = await obterCaminhaoPorId.ObterPor(It.IsAny<long>());

            Assert.AreEqual(caminhao, resultado);

            caminhaoRepository.Verify(c => c.ObterPor(It.IsAny<long>()), Times.Once);
        }
    }
}

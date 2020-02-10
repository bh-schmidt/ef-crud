using Api.Controllers.Caminhoes;
using Business.Caminhoes.AtualizarCaminhoes;
using Business.Caminhoes.ExcluirCaminhoes;
using Business.Caminhoes.InserirCaminhoes;
using Business.Caminhoes.ObterCaminhoes;
using Moq;
using NUnit.Framework;

namespace Tests.Api.Controllers.Caminhoes.CamihoesControllerTests
{
    public abstract class BaseCaminhoesControllerTests : BaseTests
    {
        protected CaminhoesController caminhoesController = null!;
        protected Mock<IObterTodosOsCaminhoes> obterTodosOsCaminhoes = null!;
        protected Mock<IObterCaminhaoPorId> obterCaminhaoPorId = null!;
        protected Mock<IInserirCaminhao> inserirCaminhao = null!;
        protected Mock<IAtualizarCaminhao> atualizarCaminhao = null!;
        protected Mock<IExcluirCaminhao> excluirCaminhao = null!;

        [SetUp]
        public void Setup()
        {
            obterTodosOsCaminhoes = new Mock<IObterTodosOsCaminhoes>();
            obterCaminhaoPorId = new Mock<IObterCaminhaoPorId>();
            inserirCaminhao = new Mock<IInserirCaminhao>();
            atualizarCaminhao = new Mock<IAtualizarCaminhao>();
            excluirCaminhao = new Mock<IExcluirCaminhao>();

            caminhoesController = new CaminhoesController(
                obterTodosOsCaminhoes.Object,
                obterCaminhaoPorId.Object,
                inserirCaminhao.Object,
                atualizarCaminhao.Object,
                excluirCaminhao.Object);
        }
    }
}

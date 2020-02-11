using Business.Caminhoes;
using Business.Caminhoes.InserirCaminhoes;
using Data.Context;
using Data.Repositories.Caminhoes;
using Models.Caminhoes;
using Moq;
using NUnit.Framework;
using System;
using System.Threading.Tasks;

namespace Tests.Business.Caminhoes.InserirCaminhoes.InserirCaminhaoTests
{
    public class InserirTests: BaseTests
    {
        InserirCaminhao inserirCaminhao = null!;
        Mock<IUnitOfWork> unitOfWork = null!;
        Mock<ICaminhaoRepository> caminhaoRepository = null!;
        Mock<IInserirCaminhaoValidator> inserirCaminhaoValidator = null!;

        [SetUp]
        public void Setup()
        {
            unitOfWork = new Mock<IUnitOfWork>();
            caminhaoRepository = new Mock<ICaminhaoRepository>();
            inserirCaminhaoValidator = new Mock<IInserirCaminhaoValidator>();

            inserirCaminhao = new InserirCaminhao(
                unitOfWork.Object,
                caminhaoRepository.Object,
                inserirCaminhaoValidator.Object);
        }

        [Test]
        public async Task Vai_inserir_o_caminhao()
        {
            var caminhao = new Caminhao();

            inserirCaminhaoValidator.Setup(i => i.Validate(caminhao))
                .Returns(ValidResult());

            await inserirCaminhao.Inserir(caminhao);

            unitOfWork.Verify(u => u.BeginAsync(), Times.Once);
            unitOfWork.Verify(u => u.CommitAsync(), Times.Once);
            unitOfWork.Verify(u => u.RollbackAsync(), Times.Never);

            inserirCaminhaoValidator.Verify(e => e.Validate(caminhao), Times.Once);
            caminhaoRepository.Verify(c => c.Inserir(caminhao), Times.Once);
        }

        [Test]
        public async Task Nao_vai_inserir_o_caminhao_porque_esta_invalido()
        {
            var caminhao = new Caminhao();

            inserirCaminhaoValidator.Setup(i => i.Validate(caminhao))
                .Returns(InvalidResult());

            await inserirCaminhao.Inserir(caminhao);

            unitOfWork.Verify(u => u.BeginAsync(), Times.Once);
            unitOfWork.Verify(u => u.CommitAsync(), Times.Never);
            unitOfWork.Verify(u => u.RollbackAsync(), Times.Once);

            inserirCaminhaoValidator.Verify(e => e.Validate(caminhao), Times.Once);
            caminhaoRepository.Verify(c => c.Inserir(caminhao), Times.Never);
        }

        [Test]
        public void Nao_vai_inserir_o_caminhao_porque_houve_um_erro_com_o_banco_de_dados()
        {
            var caminhao = new Caminhao();

            inserirCaminhaoValidator.Setup(i => i.Validate(caminhao))
                .Throws(new Exception());

            Assert.CatchAsync(() => inserirCaminhao.Inserir(caminhao));

            unitOfWork.Verify(u => u.BeginAsync(), Times.Once);
            unitOfWork.Verify(u => u.CommitAsync(), Times.Never);
            unitOfWork.Verify(u => u.RollbackAsync(), Times.Once);

            inserirCaminhaoValidator.Verify(e => e.Validate(caminhao), Times.Once);
            caminhaoRepository.Verify(c => c.Inserir(caminhao), Times.Never);
        }
    }
}

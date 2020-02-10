using Business.Caminhoes.AtualizarCaminhoes;
using Data.Context;
using Data.Repositories.Caminhoes;
using Models.Caminhoes;
using Moq;
using NUnit.Framework;
using System;
using System.Threading.Tasks;

namespace Tests.Business.Caminhoes.AtualizarCaminhoes.AtualizarCaminhaoTests
{
    public class AtualizarTests : BaseTests
    {
        AtualizarCaminhao atualizarCaminhao = null!;
        Mock<IUnitOfWork> unitOfWork = null!;
        Mock<ICaminhaoRepository> caminhaoRepository = null!;
        Mock<IAtualizarCaminhaoValidator> atualizarCaminhaoValidator = null!;

        [SetUp]
        public void Setup()
        {
            unitOfWork = new Mock<IUnitOfWork>();
            caminhaoRepository = new Mock<ICaminhaoRepository>();
            atualizarCaminhaoValidator = new Mock<IAtualizarCaminhaoValidator>();

            atualizarCaminhao = new AtualizarCaminhao(
                unitOfWork.Object,
                caminhaoRepository.Object,
                atualizarCaminhaoValidator.Object);
        }

        [Test]
        public async Task Vai_atualizar_o_caminhao()
        {
            var caminhao = new Caminhao();

            atualizarCaminhaoValidator.Setup(a => a.ValidateAsync(It.IsAny<Caminhao>(), default))
                .ReturnsAsync(ValidResult());

            await atualizarCaminhao.Atualizar(caminhao);

            unitOfWork.Verify(u => u.BeginAsync(), Times.Once);
            unitOfWork.Verify(u => u.CommitAsync(), Times.Once);
            unitOfWork.Verify(u => u.RollbackAsync(), Times.Never);

            atualizarCaminhaoValidator.Verify(u => u.ValidateAsync(caminhao, default), Times.Once);
            caminhaoRepository.Verify(c => c.AtualizarTudo(caminhao), Times.Once);
        }

        [Test]
        public async Task Nao_vai_atualizar_o_caminhao_porque_esta_invalido()
        {
            var caminhao = new Caminhao();

            atualizarCaminhaoValidator.Setup(a => a.ValidateAsync(It.IsAny<Caminhao>(), default))
                .ReturnsAsync(InvalidResult());

            await atualizarCaminhao.Atualizar(caminhao);

            unitOfWork.Verify(u => u.BeginAsync(), Times.Once);
            unitOfWork.Verify(u => u.CommitAsync(), Times.Never);
            unitOfWork.Verify(u => u.RollbackAsync(), Times.Once);

            atualizarCaminhaoValidator.Verify(u => u.ValidateAsync(caminhao, default), Times.Once);
            caminhaoRepository.Verify(c => c.AtualizarTudo(caminhao), Times.Never);
        }

        [Test]
        public void Nao_vai_atualizar_o_caminhao_porque_houve_um_problema_com_o_banco_de_dados()
        {
            var caminhao = new Caminhao();

            atualizarCaminhaoValidator.Setup(a => a.ValidateAsync(It.IsAny<Caminhao>(), default))
                .ReturnsAsync(ValidResult());

            caminhaoRepository.Setup(a => a.AtualizarTudo(It.IsAny<Caminhao>()))
                .Throws(new Exception());

            Assert.CatchAsync(() => atualizarCaminhao.Atualizar(caminhao));

            unitOfWork.Verify(u => u.BeginAsync(), Times.Once);
            unitOfWork.Verify(u => u.CommitAsync(), Times.Never);
            unitOfWork.Verify(u => u.RollbackAsync(), Times.Once);

            atualizarCaminhaoValidator.Verify(u => u.ValidateAsync(caminhao, default), Times.Once);
            caminhaoRepository.Verify(c => c.AtualizarTudo(caminhao), Times.Once);
        }
    }
}

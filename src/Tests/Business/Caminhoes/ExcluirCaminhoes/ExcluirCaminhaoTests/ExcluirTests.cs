using Business.Caminhoes.ExcluirCaminhoes;
using Data.Context;
using Data.Repositories.Caminhoes;
using Models.Caminhoes;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Business.Caminhoes.ExcluirCaminhoes.ExcluirCaminhaoTests
{
    public class ExcluirTests : BaseTests
    {
        ExcluirCaminhao excluirCaminhao = null!;
        Mock<IUnitOfWork> unitOfWork = null!;
        Mock<ICaminhaoRepository> caminhaoRepository = null!;
        Mock<IExcluirCaminhaoValidator> excluirCaminhaoValidator = null!;

        [SetUp]
        public void Setup()
        {
            unitOfWork = new Mock<IUnitOfWork>();
            caminhaoRepository = new Mock<ICaminhaoRepository>();
            excluirCaminhaoValidator = new Mock<IExcluirCaminhaoValidator>();

            excluirCaminhao = new ExcluirCaminhao(
                unitOfWork.Object,
                caminhaoRepository.Object,
                excluirCaminhaoValidator.Object);
        }

        [Test]
        public async Task Vai_excluir_o_caminhao()
        {
            var id = 1;

            excluirCaminhaoValidator.Setup(e => e.ValidateAsync(It.IsAny<Caminhao>(), default))
                .ReturnsAsync(ValidResult());

            var resultado = await excluirCaminhao.Excluir(id);

            Assert.AreEqual(id, resultado.Id);

            unitOfWork.Verify(u => u.BeginAsync(), Times.Once);
            unitOfWork.Verify(u => u.CommitAsync(), Times.Once);
            unitOfWork.Verify(u => u.RollbackAsync(), Times.Never);

            excluirCaminhaoValidator.Verify(e => e.ValidateAsync(resultado, default), Times.Once);
            caminhaoRepository.Verify(c => c.Excluir(resultado), Times.Once);
        }

        [Test]
        public async Task Nao_vai_excluir_o_caminhao_porque_o_caminhao_esta_invalido()
        {
            var id = 1;

            excluirCaminhaoValidator.Setup(e => e.ValidateAsync(It.IsAny<Caminhao>(), default))
                .ReturnsAsync(InvalidResult());

            var resultado = await excluirCaminhao.Excluir(id);

            Assert.AreEqual(id, resultado.Id);

            unitOfWork.Verify(u => u.BeginAsync(), Times.Once);
            unitOfWork.Verify(u => u.CommitAsync(), Times.Never);
            unitOfWork.Verify(u => u.RollbackAsync(), Times.Once);

            excluirCaminhaoValidator.Verify(e => e.ValidateAsync(resultado, default), Times.Once);
            caminhaoRepository.Verify(c => c.Excluir(resultado), Times.Never);
        }

        [Test]
        public void Nao_vai_excluir_o_caminhao_porque_houve_um_problema_com_banco_de_dados()
        {
            var id = 1;

            excluirCaminhaoValidator.Setup(e => e.ValidateAsync(It.IsAny<Caminhao>(), default))
                .Throws(new Exception());

            Assert.CatchAsync(() => excluirCaminhao.Excluir(id));

            unitOfWork.Verify(u => u.BeginAsync(), Times.Once);
            unitOfWork.Verify(u => u.CommitAsync(), Times.Never);
            unitOfWork.Verify(u => u.RollbackAsync(), Times.Once);

            excluirCaminhaoValidator.Verify(e => e.ValidateAsync(It.IsAny<Caminhao>(), default), Times.Once);
            caminhaoRepository.Verify(c => c.Excluir(It.IsAny<Caminhao>()), Times.Never);
        }
    }
}

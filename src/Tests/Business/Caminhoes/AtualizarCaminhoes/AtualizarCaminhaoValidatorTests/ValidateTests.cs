using Business.Caminhoes;
using Business.Caminhoes.AtualizarCaminhoes;
using Models.Caminhoes;
using Moq;
using NUnit.Framework;

namespace Tests.Business.Caminhoes.AtualizarCaminhoes.AtualizarCaminhaoValidatorTests
{
    public class ValidateTests : BaseTests
    {
        AtualizarCaminhaoValidator atualizarCaminhaoValidator = null!;
        Mock<IValidarModelo> validarModelo = null!;
        Mock<IValidarAnoFabricacao> validarAnoFabricacao = null!;
        Mock<IValidarAnoModelo> validarAnoModelo = null!;
        Mock<IValidarCaminhaoCadastrado> validarCaminhaoCadastrado = null!;

        [SetUp]
        public void Setup()
        {
            validarModelo = new Mock<IValidarModelo>();
            validarAnoModelo = new Mock<IValidarAnoModelo>();
            validarAnoFabricacao = new Mock<IValidarAnoFabricacao>();
            validarCaminhaoCadastrado = new Mock<IValidarCaminhaoCadastrado>();

            atualizarCaminhaoValidator = new AtualizarCaminhaoValidator(
                validarModelo.Object,
                validarAnoFabricacao.Object,
                validarAnoModelo.Object,
                validarCaminhaoCadastrado.Object);
        }

        [Test]
        public void Vai_retornar_caminhao_valido()
        {
            var caminhao = new Caminhao()
            {
                Id = 1
            };
            
            var resultado = atualizarCaminhaoValidator.Validate(caminhao);

            Assert.IsTrue(resultado.IsValid);
            NaoContemErro(resultado, "AtualizarCaminhaoValidator01");
        }

        [Test]
        public void Vai_retornar_caminhao_invalido()
        {
            var caminhao = new Caminhao();

            var resultado = atualizarCaminhaoValidator.Validate(caminhao);

            Assert.IsFalse(resultado.IsValid);
            ContemErro(resultado, "AtualizarCaminhaoValidator01");
        }
    }
}

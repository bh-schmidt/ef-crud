using Business.Caminhoes;
using Models.Caminhoes;
using Moq;
using NUnit.Framework;

namespace Tests.Business.Caminhoes.InserirCaminhoes.InserirCaminhaoValidatorTests
{
    public class ValidateTests : BaseTests
    {
        private const string CodigoDoErroInserirCaminhaoValidator01 = "InserirCaminhaoValidator01";
        InserirCaminhaoValidator inserirCaminhaoValidator = null!;
        Mock<IValidarModelo> validarModelo = null!;
        Mock<IValidarAnoFabricacao> validarAnoFabricacao = null!;
        Mock<IValidarAnoModelo> validarAnoModelo = null!;

        [SetUp]
        public void Setup()
        {
            validarModelo = new Mock<IValidarModelo>();
            validarAnoModelo = new Mock<IValidarAnoModelo>();
            validarAnoFabricacao = new Mock<IValidarAnoFabricacao>();

            inserirCaminhaoValidator = new InserirCaminhaoValidator(
                validarModelo.Object,
                validarAnoFabricacao.Object,
                validarAnoModelo.Object);
        }

        [Test]
        public void Vai_retornar_caminhao_valido()
        {
            var caminhao = new Caminhao();

            var resultado = inserirCaminhaoValidator.Validate(caminhao);

            Assert.IsTrue(resultado.IsValid);
            NaoContemErro(resultado, CodigoDoErroInserirCaminhaoValidator01);
        }

        [Test]
        public void Vai_retornar_caminhao_invalido()
        {
            var caminhao = new Caminhao()
            {
                Id = 1
            };

            var resultado = inserirCaminhaoValidator.Validate(caminhao);

            Assert.IsFalse(resultado.IsValid);
            ContemErro(resultado, CodigoDoErroInserirCaminhaoValidator01);
        }
    }
}

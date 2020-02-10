using Business.Caminhoes;
using Moq;
using NUnit.Framework;

namespace Tests.Business.Caminhoes.InserirCaminhoes.InserirCaminhaoValidatorTests
{
    public class ConstructorTests : BaseTests
    {
        InserirCaminhaoValidator inserirCaminhaoValidator = null!;
        Mock<IValidarModelo> validarModelo = null!;
        Mock<IValidarAnoFabricacao> validarAnoFabricacao = null!;
        Mock<IValidarAnoModelo> validarAnoModelo = null!;

        [Test]
        public void Vai_configurar_as_validacoes()
        {
            validarModelo = new Mock<IValidarModelo>();
            validarAnoModelo = new Mock<IValidarAnoModelo>();
            validarAnoFabricacao = new Mock<IValidarAnoFabricacao>();

            inserirCaminhaoValidator = new InserirCaminhaoValidator(
                validarModelo.Object,
                validarAnoFabricacao.Object,
                validarAnoModelo.Object);

            validarModelo.Verify(v => v.AdicionarValidacao(inserirCaminhaoValidator));
            validarAnoModelo.Verify(v => v.AdicionarValidacao(inserirCaminhaoValidator));
            validarAnoFabricacao.Verify(v => v.AdicionarValidacao(inserirCaminhaoValidator));
        }
    }
}

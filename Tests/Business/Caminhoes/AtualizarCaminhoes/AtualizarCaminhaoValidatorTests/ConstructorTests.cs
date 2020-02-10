using Business.Caminhoes;
using Business.Caminhoes.AtualizarCaminhoes;
using Moq;
using NUnit.Framework;

namespace Tests.Business.Caminhoes.AtualizarCaminhoes.AtualizarCaminhaoValidatorTests
{
    public class ConstructorTests : BaseTests
    {
        AtualizarCaminhaoValidator atualizarCaminhaoValidator = null!;
        Mock<IValidarModelo> validarModelo = null!;
        Mock<IValidarAnoFabricacao> validarAnoFabricacao = null!;
        Mock<IValidarAnoModelo> validarAnoModelo = null!;
        Mock<IValidarCaminhaoCadastrado> validarCaminhaoCadastrado = null!;

        [Test]
        public void Vai_adicionar_as_validacoes()
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

            validarModelo.Verify(v => v.AdicionarValidacao(atualizarCaminhaoValidator));
            validarAnoModelo.Verify(v => v.AdicionarValidacao(atualizarCaminhaoValidator));
            validarAnoFabricacao.Verify(v => v.AdicionarValidacao(atualizarCaminhaoValidator));
            validarCaminhaoCadastrado.Verify(v => v.AdicionarValidacao(atualizarCaminhaoValidator));
        }
    }
}

using Business.Caminhoes;
using Business.Caminhoes.ExcluirCaminhoes;
using Moq;
using NUnit.Framework;

namespace Tests.Business.Caminhoes.ExcluirCaminhoes.ExcluirCaminhaoValidatorTests
{
    public class ConstructorTests : BaseTests
    {
        ExcluirCaminhaoValidator excluirCaminhaoValidator = null!;
        Mock<IValidarCaminhaoCadastrado> validarCaminhaoCadastrado = null!;

        [Test]
        public void Vai_configurar_as_validacoes()
        {
            validarCaminhaoCadastrado = new Mock<IValidarCaminhaoCadastrado>();
            excluirCaminhaoValidator = new ExcluirCaminhaoValidator(validarCaminhaoCadastrado.Object);

            validarCaminhaoCadastrado.Verify(v => v.AdicionarValidacao(excluirCaminhaoValidator));
        }
    }
}

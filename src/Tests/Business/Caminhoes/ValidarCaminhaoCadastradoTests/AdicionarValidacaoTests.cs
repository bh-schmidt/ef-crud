using Business.Caminhoes;
using Data.Repositories.Caminhoes;
using FluentValidation;
using Models.Caminhoes;
using Moq;
using NUnit.Framework;

namespace Tests.Business.Caminhoes.ValidarCaminhaoCadastradoTests
{
    public class AdicionarValidacaoTests : BaseTests
    {
        private const string CodigoDoErroValidarCaminhaoCadastrado01 = "ValidarCaminhaoCadastrado01";
        ValidarCaminhaoCadastrado validarCaminhaoCadastrado = null!;
        Mock<ICaminhaoRepository> caminhaoRepository = null!;

        [SetUp]
        public void Setup()
        {
            caminhaoRepository = new Mock<ICaminhaoRepository>();
            validarCaminhaoCadastrado = new ValidarCaminhaoCadastrado(caminhaoRepository.Object);
        }

        [Test]
        public void Vai_retornar_caminhao_cadastrado()
        {
            var caminhao = new Caminhao()
            {
                Id = 1
            };
            var validator = new InlineValidator<Caminhao>();

            caminhaoRepository.Setup(c => c.IdExistente(It.IsAny<long>()))
                .ReturnsAsync(true);

            validarCaminhaoCadastrado.AdicionarValidacao(validator);

            var resultado = validator.Validate(caminhao);

            Assert.IsTrue(resultado.IsValid);
            NaoContemErro(resultado, CodigoDoErroValidarCaminhaoCadastrado01);
        }

        [Test]
        public void Vai_retornar_caminhao_nao_cadastrado_porque_o_id_esta_nulo()
        {
            var caminhao = new Caminhao();
            var validator = new InlineValidator<Caminhao>();

            validarCaminhaoCadastrado.AdicionarValidacao(validator);

            var resultado = validator.Validate(caminhao);

            Assert.IsFalse(resultado.IsValid);
            ContemErro(resultado, CodigoDoErroValidarCaminhaoCadastrado01);
        }

        [Test]
        public void Vai_retornar_caminhao_nao_cadastrado()
        {
            var caminhao = new Caminhao() { 
                Id = 1
            };
            var validator = new InlineValidator<Caminhao>();

            caminhaoRepository.Setup(c => c.IdExistente(It.IsAny<long>()))
                .ReturnsAsync(false);

            validarCaminhaoCadastrado.AdicionarValidacao(validator);

            var resultado = validator.Validate(caminhao);

            Assert.IsFalse(resultado.IsValid);
            ContemErro(resultado, CodigoDoErroValidarCaminhaoCadastrado01);
        }
    }
}

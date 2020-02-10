using Business.Caminhoes;
using FluentValidation;
using Models.Caminhoes;
using NUnit.Framework;
using Utils.Extensions;

namespace Tests.Business.Caminhoes.ValidarModeloTests
{
    public class AdicionarValidacaoTests : BaseTests
    {
        private const string CodigoDoErroValidarModelo01 = "ValidarModelo01";
        ValidarModelo validarModelo = null!;

        [SetUp]
        public void Setup() => validarModelo = new ValidarModelo();

        [Test]
        public void Vai_retornar_modelo_valido()
        {
            var validator = new InlineValidator<Caminhao>();
            var caminhao = new Caminhao()
            {
                Modelo = ModeloCaminhao.FH
            };

            validarModelo.AdicionarValidacao(validator);

            var resultado = validator.Validate(caminhao);

            Assert.IsTrue(resultado.IsValid);
            NaoContemErro(resultado, CodigoDoErroValidarModelo01);
        }


        [Test]
        public void Vai_retornar_modelo_invalido()
        {
            var validator = new InlineValidator<Caminhao>();
            var caminhao = new Caminhao()
            {
                Modelo = 3.ToEnum<ModeloCaminhao>()
            };

            validarModelo.AdicionarValidacao(validator);

            var resultado = validator.Validate(caminhao);

            Assert.IsFalse(resultado.IsValid);
            ContemErro(resultado, CodigoDoErroValidarModelo01);
        }
    }
}

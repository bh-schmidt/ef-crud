using Business.Caminhoes;
using FluentValidation;
using Models.Caminhoes;
using NUnit.Framework;
using System;

namespace Tests.Business.Caminhoes.ValidarAnoFabricacaoTests
{
    public class AdicionarValidacaoTests : BaseTests
    {
        private const string CodigoDoErroValidarAnoFabricaçao01 = "ValidarAnoFabricacao01";
        ValidarAnoFabricacao validarAnoFabricacao = null!;

        [SetUp]
        public void Setup() => validarAnoFabricacao = new ValidarAnoFabricacao();

        [Test]
        public void Vai_retornar_ano_fabricacao_valido()
        {
            var caminhao = new Caminhao()
            {
                AnoFabricacao = DateTime.Now.Year
            };
            var validator = new InlineValidator<Caminhao>();
            
            validarAnoFabricacao.AdicionarValidacao(validator);

            var resultado = validator.Validate(caminhao);

            Assert.IsTrue(resultado.IsValid);
            NaoContemErro(resultado, CodigoDoErroValidarAnoFabricaçao01);
        }

        [Test]
        public void Vai_retornar_ano_fabricacao_invalido()
        {
            var caminhao = new Caminhao()
            {
                AnoFabricacao = DateTime.Now.Year + 1
            };
            var validator = new InlineValidator<Caminhao>();

            validarAnoFabricacao.AdicionarValidacao(validator);

            var resultado = validator.Validate(caminhao);

            Assert.IsFalse(resultado.IsValid);
            ContemErro(resultado, CodigoDoErroValidarAnoFabricaçao01);
        }
    }
}

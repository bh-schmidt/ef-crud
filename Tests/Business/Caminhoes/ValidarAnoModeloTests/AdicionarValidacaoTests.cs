using Business.Caminhoes;
using FluentValidation;
using Models.Caminhoes;
using NUnit.Framework;
using System;

namespace Tests.Business.Caminhoes.ValidarAnoModeloTests
{
    public class AdicionarValidacaoTests : BaseTests
    {
        private const string CodigoDoErroValidarAnoModelo01 = "ValidarAnoModelo01";
        ValidarAnoModelo validarAnoModelo = null!;

        [SetUp]
        public void Setup() => validarAnoModelo = new ValidarAnoModelo();

        [Test]
        public void Vai_retornar_ano_modelo_valido()
        {
            foreach (var ano in AnosModeloValidos())
            {
                Validar(ano);
            }
        }

        [Test]
        public void Vai_retornar_ano_modelo_invalido()
        {
            var caminhao = new Caminhao()
            {
                AnoModelo = DateTime.Now.Year + 2
            };
            var validator = new InlineValidator<Caminhao>();

            validarAnoModelo.AdicionarValidacao(validator);

            var resultado = validator.Validate(caminhao);

            Assert.IsFalse(resultado.IsValid);
            ContemErro(resultado, CodigoDoErroValidarAnoModelo01);
        }

        private void Validar(int ano)
        {
            var caminhao = new Caminhao()
            {
                AnoModelo = ano
            };
            var validator = new InlineValidator<Caminhao>();

            validarAnoModelo.AdicionarValidacao(validator);

            var resultado = validator.Validate(caminhao);

            Assert.IsTrue(resultado.IsValid);
            NaoContemErro(resultado, CodigoDoErroValidarAnoModelo01);
        }

        private int[] AnosModeloValidos() =>
            new[]
            {
                DateTime.Now.Year,
                DateTime.Now.Year + 1
            };
    }
}

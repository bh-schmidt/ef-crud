using NUnit.Framework;
using Utils.Extensions;

namespace Tests.Infra.CrossCutting.Utils.Extensions.Int32ExtensionsTests
{
    public class ToEnumTests : BaseTests
    {
        [Test]
        public void Vai_converter_o_numero_para_enum()
        {
            var valor = 1;

            var resultado = valor.ToEnum<TestEnum>();

            Assert.AreEqual(TestEnum.Valor1, resultado);
        }

        enum TestEnum
        {
            Valor1 = 1,
            Valor2 = 2
        }
    }
}

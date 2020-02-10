using NUnit.Framework;
using Utils.Extensions;

namespace Tests.Infra.CrossCutting.Utils.Extensions.ObjectExtensionsTests
{
    public class IsNullTests : BaseTests
    {
        [Test]
        public void Vai_retornar_objeto_nulo()
        {
            object? obj = null;

            Assert.IsTrue(obj.IsNull());
        }

        [Test]
        public void Vai_retornar_objeto_nao_esta_nulo()
        {
            object? obj = 1;

            Assert.IsFalse(obj.IsNull());
        }
    }
}

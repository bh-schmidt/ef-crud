using NUnit.Framework;
using System;
using Utils.Extensions;

namespace Tests.Infra.CrossCutting.Utils.Extensions.ObjectExtensionsTests
{
    public class CastToTests : BaseTests
    {
        [Test]
        public void Vai_fazer_o_cast_do_objeto()
        {
            object obj = 1;

            var resultado = obj.CastTo<int>();

            Assert.AreEqual(obj, resultado);
        }

        [Test]
        public void Nao_vai_fazer_o_cast_do_objeto_porque_os_objetos_sao_diferentes()
        {
            object obj = "Test";

            Assert.Catch(() => obj.CastTo<DateTime>());
        }
    }
}

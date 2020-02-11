using Autofac;
using IoC;
using NUnit.Framework;
using System.Linq;

namespace Tests.Infra.CrossCutting.IoC.ContainerConfigurationTests
{
    public class ConfigureTests : BaseTests
    {
        [Test]
        public void Vai_configurar_o_container()
        {
            var builder = new ContainerBuilder();
            ContainerConfiguration.Configure(builder);
            var container = builder.Build();

            Assert.Greater(container.ComponentRegistry.Registrations.Count(), 1);
        }
    }
}

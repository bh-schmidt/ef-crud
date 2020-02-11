using Microsoft.Extensions.Configuration;
using NUnit.Framework;
using SystemConfig;

namespace Tests.Infra.CrossCutting.SystemConfig.AppSettingsTests
{
    public class ConfigureTests : BaseTests
    {
        [Test]
        public void Vai_configurar_as_configuracoes_da_applicacao()
        {
            IConfiguration configuration = new ConfigurationRoot(new IConfigurationProvider[] { });

            AppSettings.Configure(configuration);
        }
    }
}

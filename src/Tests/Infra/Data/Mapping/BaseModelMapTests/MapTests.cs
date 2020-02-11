using Data.Mapping;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using NUnit.Framework;

namespace Tests.Infra.Data.Mapping.BaseModelMapTests
{
    public class MapTests : BaseTests
    {
        [Test]
        public void Vai_mapear_as_propriedades_das_models()
        {
            ModelBuilder modelBuilder = new ModelBuilder(new ConventionSet());

            BaseModelMap.Map(modelBuilder);
        }
    }
}

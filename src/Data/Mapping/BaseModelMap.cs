using Microsoft.EntityFrameworkCore;
using Models;
using System.Linq;
using System.Reflection;

namespace Data.Mapping
{
    public static class BaseModelMap
    {
        public static void Map(ModelBuilder modelBuilder)
        {
            var assembly = Assembly.GetAssembly(typeof(BaseModel));

            if (assembly is null)
                return;

            var classes = assembly.GetTypes()
                .Where(a => a.IsSubclassOf(typeof(BaseModel)));

            foreach (var classe in classes)
            {
                var builder = modelBuilder.Entity(classe);
                builder.Ignore("Valid");
                builder.Ignore("ValidationResult");
            }
        }
    }
}

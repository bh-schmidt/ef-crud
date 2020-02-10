using Microsoft.EntityFrameworkCore;

namespace Data.Context
{
    public static class ConfigureContext
    {
        public static void Configure()
        {
            using var context = new EfCrudContext();
            context.Database.Migrate();
        }
    }
}

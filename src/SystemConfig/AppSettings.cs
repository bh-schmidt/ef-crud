using Microsoft.Extensions.Configuration;

namespace SystemConfig
{
    public static class AppSettings
    {
        public static string? SqliteConnection { get; private set; }

        public static void Configure(IConfiguration configuration)
        {
            SqliteConnection = configuration.GetConnectionString("Sqlite");
        }
    }
}

using OnlineCourse.DataAccess.DbContexts;
using Microsoft.EntityFrameworkCore;
namespace OnlineCourse.WebApi.Configurations.LayerConfigurations
{
    public static class DataAcessConfiguration
    {
        public static void ConfigureDataAccess(this WebApplicationBuilder builder)
        {
            string connection = builder.Configuration.GetConnectionString("DatabaseConnectionString")!;
            builder.Services.AddDbContext<AppDbContext>(options =>
            options.UseNpgsql(connection));
        }
    }
}

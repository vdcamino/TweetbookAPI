using Microsoft.EntityFrameworkCore;
using TweetbookAPI.Data;

namespace TweetbookAPI.Installers
{
    public class DbInstaller : IInstaller
    {
        public void InstallServices(IConfiguration configuration, IServiceCollection services)
        {
            services.AddDbContext<DataContext>(options => options.UseNpgsql(configuration.GetConnectionString("PostgreSQLServer")));
        }
    }
}

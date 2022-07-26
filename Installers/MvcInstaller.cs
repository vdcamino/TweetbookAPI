namespace TweetbookAPI.Installers
{
    public class MvcInstaller : IInstaller
    {
        public void InstallServices(IConfiguration configuration, IServiceCollection services)
        {
            services.AddMvc();
            services.AddSwaggerGen();
        }
    }
}

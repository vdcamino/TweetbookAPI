﻿namespace TweetbookAPI.Installers
{
    public interface IInstaller 
    {
        void InstallServices (IConfiguration configuration, IServiceCollection services);
    }
}

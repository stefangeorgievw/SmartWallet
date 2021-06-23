using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using SmartWallet.Application.Interfaces;
using SmartWallet.Application.Mapper;
using SmartWallet.Application.Services;
using SmartWallet.Domain.Interfaces;
using SwartWallet.Infrastructure.Data.Repositories;

namespace SmartWaller.Infrastructure.IoC
{
    public class DependencyContainer
    {
        public static void RegisterDependencies(IServiceCollection services)
        {
            RegisterServices(services);
            RegisterRepositories(services);
            RegisterMapper(services);           
        }

        private static void RegisterMapper(IServiceCollection services)
        {
            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MapperProfile());
            });

            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);
        }

        private static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<IAccountService, AccountService>();
        }

        private static void RegisterRepositories(IServiceCollection services)
        {
            services.AddScoped<IAccountRepository, AccountRepository>();
        }
    }
}

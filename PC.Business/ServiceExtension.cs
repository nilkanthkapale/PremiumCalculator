

using Microsoft.Extensions.DependencyInjection;
using PC.Business.interfaces;
using PC.Business.services;
using PC.Data.Data;

namespace PC.Business
{
    public static class ServiceExtension
    {
        public static void RegisterServices(this IServiceCollection serviceCollections)
        {
            serviceCollections.AddSingleton(typeof(MasterData));
            serviceCollections.AddTransient<IRatingService, RatingServices>();
            serviceCollections.AddTransient<IOccupationService, OccupationService>();
            serviceCollections.AddTransient<IPremiumService, PremiumService>();
        }
    }
}

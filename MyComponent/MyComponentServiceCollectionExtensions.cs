using GroupDIRegistrationsInNetCore.MyComponent;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroupDIRegistrationsInNetCore.MyComponent
{
    public static class MyComponentServiceCollectionExtensions
    {
        public static void AddMyComponent(this IServiceCollection services)
        {
            if (services == null)
                throw new ArgumentNullException(nameof(services));

            services.AddTransient<IProductManager, ProductManager>();
            services.AddSingleton<IBasketManager, BasketManager>();
        }
    }
}

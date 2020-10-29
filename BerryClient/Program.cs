using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using StrawberryShake;

namespace BerryClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddHttpClient(
                "StarWarsClient",
                c => c.BaseAddress = new Uri("http://localhost:53964"));
            serviceCollection.AddStarWarsClient();

            IServiceProvider services = serviceCollection.BuildServiceProvider();
            IStarWarsClient client = services.GetRequiredService<IStarWarsClient>();

            IOperationResult<IGetFoo> result = await client.GetFooAsync("cGVvcGxlOjE=");
            Console.WriteLine(result.Data.Person.Name);
        }
    }
}

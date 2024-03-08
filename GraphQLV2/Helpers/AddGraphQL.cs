using WebApplication1.GraphQLV2.Graph;
using WebApplication1.GraphQLV2.Helpers.Registers;

namespace WebApplication1.GraphQLV2.Helpers
{
    public static class AddGraphQL
    {
        public static IServiceCollection AddGraphQLApi(this IServiceCollection services)
        {
            services.AddGraphQLServer("V2")
            .AddQueryType<Query>()
            .AddGraphQLRegisters();

            return services;
        }
    }
}
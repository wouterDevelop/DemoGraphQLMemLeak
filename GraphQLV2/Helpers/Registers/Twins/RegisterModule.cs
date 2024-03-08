using HotChocolate.Execution.Configuration;
using WebApplication1.GraphQLV2.Helpers.Registers.Twins.Assets;
using WebApplication1.GraphQLV2.Helpers.Registers.Twins.Organizations;
using WebApplication1.GraphQLV2.Helpers.Registers.Twins.Points;
using WebApplication1.GraphQLV2.Helpers.Registers.Twins.Spaces;
using WebApplication1.GraphQLV2.Helpers.Registers.Twins.Telemetries;

namespace WebApplication1.GraphQLV2.Helpers.Registers.Twins
{
    public static class RegisterModule
    {
        public static IRequestExecutorBuilder AddTwins(
this IRequestExecutorBuilder builder)
        {
            builder.AddOrganizations();
            builder.AddSpaces();
            builder.AddAssets();
            builder.AddPoints();
            builder.AddTelemetries();
            return builder;
        }
    }
}

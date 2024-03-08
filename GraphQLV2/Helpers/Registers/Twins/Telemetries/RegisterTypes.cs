using HotChocolate.Execution.Configuration;
using WebApplication1.GraphQLV2.Helpers.Registers.Twins.Telemetries.Types;

namespace WebApplication1.GraphQLV2.Helpers.Registers.Twins.Telemetries
{
    public static class RegisterTypes
    {
        public static IRequestExecutorBuilder AddTypes(
this IRequestExecutorBuilder builder)
        {
            builder.AddType<TelemetryGraphQLType>();

            return builder;
        }
    }
}

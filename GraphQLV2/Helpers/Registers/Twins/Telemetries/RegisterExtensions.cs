using HotChocolate.Execution.Configuration;

namespace WebApplication1.GraphQLV2.Helpers.Registers.Twins.Telemetries
{
    public static class RegisterExtensions
    {
        public static IRequestExecutorBuilder AddExtensions(
this IRequestExecutorBuilder builder)
        {
            return builder;
        }
    }
}

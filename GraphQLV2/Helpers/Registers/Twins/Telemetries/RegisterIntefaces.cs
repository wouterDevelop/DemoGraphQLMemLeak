using HotChocolate.Execution.Configuration;

namespace WebApplication1.GraphQLV2.Helpers.Registers.Twins.Telemetries
{
    public static class RegisterIntefaces
    {
        public static IRequestExecutorBuilder AddInterfaces(
this IRequestExecutorBuilder builder)
        {
            return builder;
        }
    }
}

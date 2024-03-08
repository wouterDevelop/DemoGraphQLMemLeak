using HotChocolate.Execution.Configuration;

namespace WebApplication1.GraphQLV2.Helpers.Registers.Twins.Telemetries
{
    public static class Register
    {
        public static IRequestExecutorBuilder AddTelemetries(
this IRequestExecutorBuilder builder)
        {
            builder.AddExtensions();
            builder.AddTypes();
            builder.AddInterfaces();

            return builder;
        }
    }
}

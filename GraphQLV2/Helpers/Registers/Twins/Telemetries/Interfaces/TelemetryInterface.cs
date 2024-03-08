using HotChocolate.Execution.Configuration;
using WebApplication1.Domain.Internal;

namespace WebApplication1.GraphQLV2.Helpers.Registers.Twins.Telemetries.Interfaces
{
    public static class TelemetryInterface
    {
        public static IRequestExecutorBuilder AddTelemetryInterface(
this IRequestExecutorBuilder builder)
        {
            builder.AddInterfaceType<Telemetry>(descriptor =>
            {
                //here defined the functions on the interface extension
            });

            return builder;
        }
    }
}

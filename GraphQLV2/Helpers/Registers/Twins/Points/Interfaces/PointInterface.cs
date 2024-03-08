using HotChocolate.Execution.Configuration;
using WebApplication1.Domain.RealEstateCore.Points;
using WebApplication1.GraphQLV2.Helpers.Registers.Twins.Telemetries.Types;

namespace WebApplication1.GraphQLV2.Helpers.Registers.Twins.Points.Interfaces
{
    public static class PointInterface
    {
        public static IRequestExecutorBuilder AddPointInterface(
this IRequestExecutorBuilder builder)
        {
            builder.AddInterfaceType<Point>(descriptor =>
            {
                descriptor.Ignore(f => f.GenerateId());

                descriptor.Field("lastKnownValue").Type<TelemetryGraphQLType>();

                descriptor.Field("timeSerie")
                .Type<ListType<TelemetryGraphQLType>>()
                .Argument("startDate", x => x.Type<DateTimeType>())
                .Argument("endDate", x => x.Type<DateTimeType>());
            });

            return builder;
        }
    }
}
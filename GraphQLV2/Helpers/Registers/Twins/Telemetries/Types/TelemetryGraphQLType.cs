using HotChocolate.Types;
using WebApplication1.Domain.Internal;

namespace WebApplication1.GraphQLV2.Helpers.Registers.Twins.Telemetries.Types
{
    public class TelemetryGraphQLType : ObjectType<Telemetry>
    {
        protected override void Configure(IObjectTypeDescriptor<Telemetry> descriptor)
        {
            descriptor.Field(t => t.TimeStamp);
            descriptor.Field(t => t.EntityId);
            descriptor.Field(t => t.Type);
            descriptor.Field("value")
                .Type<NonNullType<AnyType>>()
                .Resolve(context => context.Parent<Telemetry>().Value);
        }
    }
}

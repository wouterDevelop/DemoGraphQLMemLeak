using HotChocolate.Execution.Configuration;
using WebApplication1.Domain.RealEstateCore.Assets;
using WebApplication1.Domain.Spaces;

namespace WebApplication1.GraphQLV2.Helpers.Registers.Twins.Spaces.Interfaces
{
    public static class SpacesInterface
    {
        public static IRequestExecutorBuilder AddSpaceInterface(
this IRequestExecutorBuilder builder)
        {
            builder.AddInterfaceType<Space>(descriptor =>
            {
                //here defined the functions on the interface extension
                descriptor.Field("childSpaces").Type<ListType<InterfaceType<Space>>>();
                descriptor.Field("parentSpace").Type<InterfaceType<Space>>();
                descriptor.Field("assets").Type<ListType<InterfaceType<Asset>>>();

                descriptor.Ignore(f => f.GenerateId());
            });

            return builder;
        }
    }
}
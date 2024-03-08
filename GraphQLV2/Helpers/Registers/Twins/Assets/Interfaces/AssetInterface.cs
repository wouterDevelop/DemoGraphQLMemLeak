using HotChocolate.Execution.Configuration;
using HotChocolate.Types;
using WebApplication1.Domain.RealEstateCore.Assets;
using WebApplication1.Domain.RealEstateCore.Points;
using WebApplication1.Domain.Spaces;

namespace WebApplication1.GraphQLV2.Helpers.Registers.Twins.Assets.Interfaces
{
    public static class AssetInterface
    {
        public static IRequestExecutorBuilder AddAssetInterface(
this IRequestExecutorBuilder builder)
        {
            builder.AddInterfaceType<Asset>(descriptor =>
            {
                descriptor.Field("points").Type<ListType<InterfaceType<Point>>>();

                descriptor.Field("childAssets").Type<ListType<InterfaceType<Asset>>>();

                descriptor.Field("parentSpace").Type<InterfaceType<Space>>();

                descriptor.Ignore(f => f.GenerateId());
            });

            return builder;
        }
    }
}

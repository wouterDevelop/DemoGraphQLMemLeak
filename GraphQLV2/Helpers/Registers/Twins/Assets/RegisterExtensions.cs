using HotChocolate.Execution.Configuration;
using WebApplication1.GraphQLV2.Graph.Twin.Assets.Extensions;

namespace WebApplication1.GraphQLV2.Helpers.Registers.Twins.Assets
{
    public static class RegisterExtensions
    {
        public static IRequestExecutorBuilder AddExtensions(
this IRequestExecutorBuilder builder)
        {
            builder.AddTypeExtension<AssetExtensions>();

            return builder;
        }
    }
}

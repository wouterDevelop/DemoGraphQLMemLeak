using HotChocolate.Execution.Configuration;
using WebApplication1.GraphQLV2.Helpers.Registers.Twins.Assets.Interfaces;

namespace WebApplication1.GraphQLV2.Helpers.Registers.Twins.Assets
{
    public static class RegisterIntefaces
    {
        public static IRequestExecutorBuilder AddInterfaces(
this IRequestExecutorBuilder builder)
        {
            builder.AddAssetInterface();

            return builder;
        }
    }
}

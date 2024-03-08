using HotChocolate.Execution.Configuration;

namespace WebApplication1.GraphQLV2.Helpers.Registers.Twins.Assets
{
    public static class Register
    {
        public static IRequestExecutorBuilder AddAssets(
this IRequestExecutorBuilder builder)
        {
            builder.AddExtensions();
            builder.AddTypes();
            builder.AddInterfaces();

            return builder;
        }
    }
}

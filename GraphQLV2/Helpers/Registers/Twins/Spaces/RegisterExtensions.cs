using HotChocolate.Execution.Configuration;
using WebApplication1.GraphQLV2.Graph.Twin.Spaces.Extensions;

namespace WebApplication1.GraphQLV2.Helpers.Registers.Twins.Spaces
{
    public static class RegisterExtensions
    {
        public static IRequestExecutorBuilder AddExtensions(
this IRequestExecutorBuilder builder)
        {
            builder.AddTypeExtension<SpacesExtenions>();
            builder.AddTypeExtension<SiteExtensions>();

            return builder;
        }
    }
}

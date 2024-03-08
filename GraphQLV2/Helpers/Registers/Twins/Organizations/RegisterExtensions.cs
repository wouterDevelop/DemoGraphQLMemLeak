using HotChocolate.Execution.Configuration;
using WebApplication1.GraphQLV2.Graph.Twin.Organizations.Extensions;

namespace WebApplication1.GraphQLV2.Helpers.Registers.Twins.Organizations
{
    public static class RegisterExtensions
    {
        public static IRequestExecutorBuilder AddExtensions(
this IRequestExecutorBuilder builder)
        {
            builder.AddTypeExtension<OrganizationExtensions>();

            return builder;
        }
    }
}

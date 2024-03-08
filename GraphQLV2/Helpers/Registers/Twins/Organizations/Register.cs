using HotChocolate.Execution.Configuration;

namespace WebApplication1.GraphQLV2.Helpers.Registers.Twins.Organizations
{
    public static class Register
    {
        public static IRequestExecutorBuilder AddOrganizations(
this IRequestExecutorBuilder builder)
        {
            builder.AddExtensions();
            builder.AddTypes();
            builder.AddInterfaces();

            return builder;
        }
    }
}

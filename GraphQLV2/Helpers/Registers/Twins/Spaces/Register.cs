using HotChocolate.Execution.Configuration;

namespace WebApplication1.GraphQLV2.Helpers.Registers.Twins.Spaces
{
    public static class Register
    {
        public static IRequestExecutorBuilder AddSpaces(
this IRequestExecutorBuilder builder)
        {
            builder.AddExtensions();
            builder.AddTypes();
            builder.AddInterfaces();

            return builder;
        }
    }
}

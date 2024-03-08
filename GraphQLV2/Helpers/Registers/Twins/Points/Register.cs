using HotChocolate.Execution.Configuration;

namespace WebApplication1.GraphQLV2.Helpers.Registers.Twins.Points
{
    public static class Register
    {
        public static IRequestExecutorBuilder AddPoints(
this IRequestExecutorBuilder builder)
        {
            builder.AddExtensions();
            builder.AddTypes();
            builder.AddInterfaces();

            return builder;
        }
    }
}

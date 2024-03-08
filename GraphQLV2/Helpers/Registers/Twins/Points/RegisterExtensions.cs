using HotChocolate.Execution.Configuration;
using WebApplication1.GraphQLV2.Graph.Twin.Points.Loaders;

namespace WebApplication1.GraphQLV2.Helpers.Registers.Twins.Points
{
    public static class RegisterExtensions
    {
        public static IRequestExecutorBuilder AddExtensions(
this IRequestExecutorBuilder builder)
        {
            builder.AddTypeExtension<PointExtensions>();

            return builder;
        }
    }
}

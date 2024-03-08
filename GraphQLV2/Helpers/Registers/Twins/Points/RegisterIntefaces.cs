using HotChocolate.Execution.Configuration;
using WebApplication1.GraphQLV2.Helpers.Registers.Twins.Points.Interfaces;

namespace WebApplication1.GraphQLV2.Helpers.Registers.Twins.Points
{
    public static class RegisterIntefaces
    {
        public static IRequestExecutorBuilder AddInterfaces(
this IRequestExecutorBuilder builder)
        {
            builder.AddPointInterface();

            return builder;
        }
    }
}

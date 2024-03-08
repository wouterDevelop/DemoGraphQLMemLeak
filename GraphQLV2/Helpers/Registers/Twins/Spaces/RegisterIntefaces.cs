using HotChocolate.Execution.Configuration;
using WebApplication1.GraphQLV2.Helpers.Registers.Twins.Spaces.Interfaces;

namespace WebApplication1.GraphQLV2.Helpers.Registers.Twins.Spaces
{
    public static class RegisterIntefaces
    {
        public static IRequestExecutorBuilder AddInterfaces(
this IRequestExecutorBuilder builder)
        {
            builder.AddSpaceInterface();

            return builder;
        }
    }
}

using HotChocolate.Execution.Configuration;
using WebApplication1.GraphQLV2.Helpers.Registers.Twins;

namespace WebApplication1.GraphQLV2.Helpers.Registers
{
    public static class Registers
    {
        public static IRequestExecutorBuilder AddGraphQLRegisters(
    this IRequestExecutorBuilder builder)
        {
            builder.AddTwins();

            return builder;
        }
    }
}

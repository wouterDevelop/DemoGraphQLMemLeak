using HotChocolate.Execution.Configuration;
using WebApplication1.Domain.RealEstateCore.Assets;

namespace WebApplication1.GraphQLV2.Helpers.Registers.Twins.Assets
{
    public static class RegisterTypes
    {
        public static IRequestExecutorBuilder AddTypes(
this IRequestExecutorBuilder builder)
        {
            if (builder is null)
            {
                throw new ArgumentNullException(nameof(builder));
            }

            var type = typeof(Asset);
            IEnumerable<Type> types = AppDomain.CurrentDomain.GetAssemblies()
    .SelectMany(s => s.GetTypes())
    .Where(p => type.IsAssignableFrom(p) && p.IsClass).ToList();

            foreach (Type propertytype in types)
            {
                builder.AddType(propertytype);
            }

            return builder;
        }
    }
}

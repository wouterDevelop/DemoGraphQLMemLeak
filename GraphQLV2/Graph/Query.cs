using WebApplication1.GraphQLV2.Graph.Twin;

namespace WebApplication1.GraphQLV2.Graph
{
    public class Query
    {
        /// <summary>
        /// Query twin models
        /// </summary>
        ///

        public TwinQuery Twin { get; set; } = new TwinQuery();
    }
}
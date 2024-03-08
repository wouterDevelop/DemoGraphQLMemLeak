using WebApplication1.GraphQLV2.Graph.Twin.Assets;
using WebApplication1.GraphQLV2.Graph.Twin.Organizations;
using WebApplication1.GraphQLV2.Graph.Twin.Points;
using WebApplication1.GraphQLV2.Graph.Twin.Spaces;

namespace WebApplication1.GraphQLV2.Graph.Twin
{
    public class TwinQuery
    {
        /// <summary>
        /// Query Organistions
        /// </summary>
        public OrganizationsQuery Organization { get; set; } = new OrganizationsQuery();

        /// <summary>
        /// Query Spaces
        /// </summary>
        public SpacesQuery Space { get; set; } = new SpacesQuery();

        /// <summary>
        /// Query Assets
        /// </summary>
        public AssetsQuery Asset { get; set; } = new AssetsQuery();

        /// <summary>
        /// Query Point
        /// </summary>
        public PointsQuery Point { get; set; } = new PointsQuery();

        /// <summary>
        /// Query Telemetries
        /// </summary>
        //public TelemetriesQuery Telemetry { get; set; } = new TelemetriesQuery();
    }
}

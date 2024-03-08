using WebApplication1.Domain.RealEstateCore.Points;

namespace WebApplication1.GraphQLV2.Graph.Twin.Points
{
    public class PointsQuery
    {
        /// <summary>
        /// Get Points
        /// </summary>
        /// <param name="mediator"></param>
        /// <param name="pointIds"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<IEnumerable<Point>> GetAssetsAsync(IEnumerable<string> pointIds, CancellationToken cancellationToken) => new List<Point>();
    }
}
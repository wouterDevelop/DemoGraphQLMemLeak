using WebApplication1.Domain.Spaces;

namespace WebApplication1.GraphQLV2.Graph.Twin.Spaces
{
    public class SpacesQuery
    {
        /// <summary>
        ///  Get spaces by id
        /// </summary>
        /// <param name="mediator"></param>
        /// <param name="spaceIds"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<IEnumerable<Space>> GetSpacesAsync(IEnumerable<string> spaceIds, CancellationToken cancellationToken)
        {
            return new List<Space>();
        }
    }
}
namespace WebApplication1.Domain.RealEstateCore
{
    public class BasicTwinRelationship
    {
        /// <summary>
        /// The unique Id of the relationship. This field is present on every relationship.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// The unique Id of the target digital twin. This field is present on every relationship.
        /// </summary>
        public string TargetId { get; set; }

        /// <summary>
        /// The unique Id of the source digital twin. This field is present on every relationship.
        /// </summary>
        public string SourceId { get; set; }

        /// <summary>
        /// The name of the relationship, which defines the type of link (e.g. Contains). This field is present on every relationship.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Additional, custom properties defined in the DTDL model.
        /// This property will contain any relationship properties that are not already defined in this class.
        /// </summary>
        public IDictionary<string, object> Properties { get; set; } = new Dictionary<string, object>();
    }
}

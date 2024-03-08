namespace WebApplication1.Domain.RealEstateCore
{
    public class BasicTwinInfo
    {
        public string? Id { get; set; }

        public virtual string GenerateId() => $"{GetType().Name.ToLowerInvariant()}-{RandomString()}";

        /// <summary>
        /// Generate a random string of lowercase letters and numbers
        /// </summary>
        /// <param name="length">Length of the random string, defaults to 8</param>
        /// <returns>A random string of the specified length</returns>
        protected static string RandomString(int length = 8)
        {
            var random = new Random();
            const string pool = "abcdefghijklmnopqrstuvwxyz0123456789";
            IEnumerable<char> chars = Enumerable.Range(0, length).Select(x => pool[random.Next(0, pool.Length)]);
            return new string(chars.ToArray());
        }
    }
}

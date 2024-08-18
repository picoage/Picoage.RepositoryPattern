namespace Picoage.Repository.DocumentDb.Tests
{
    internal class TestRepo : IIdompotent
    {
        public string Id { get; set; } = string.Empty;
        public string QueryId { get ; set ; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty; 
    }
}

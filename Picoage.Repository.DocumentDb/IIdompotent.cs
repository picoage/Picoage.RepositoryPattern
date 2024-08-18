namespace Picoage.Repository.DocumentDb
{
    public interface IIdompotent
    {
        public string Id { get; set; }
        public string QueryId { get; set; }
    }
}
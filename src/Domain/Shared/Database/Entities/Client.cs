namespace Domain.Shared.Database.Entities
{
    public class Client
    {
        public long Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
    }
}
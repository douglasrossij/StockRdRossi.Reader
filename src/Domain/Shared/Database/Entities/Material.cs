namespace Domain.Shared.Database.Entities
{
    public class Material
    {
        public long Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public bool Notify { get; set; } = false;
        public decimal? MinimumAmount { get; set; }
        public decimal? CurrentAmount { get; set; }
    }
}
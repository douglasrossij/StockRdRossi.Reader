namespace Domain.Shared.Database.Entities
{
    public class MaterialInput
    {
        public long Id { get; set; }
        public DateTime InputDate { get; set; }
        public decimal Amount { get; set; }
        public Material Material { get; set; }
        public Employee Employee { get; set; }
    }
}
namespace Domain.Shared.Database.Entities
{
    public class MaterialOutput
    {
        public long Id { get; set; }
        public DateTime OutputDate { get; set; }
        public decimal Amount { get; set; }
        public Material Material { get; set; }
        public Employee Employee { get; set; }
        public Client Client { get; set; }
    }
}
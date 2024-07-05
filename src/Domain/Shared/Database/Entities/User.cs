using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Shared.Database.Entities
{
    [Table("Users")]
    public class User
    {
        [Key]
        public long Id { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public bool IsAdministrator { get; set; }
    }
}
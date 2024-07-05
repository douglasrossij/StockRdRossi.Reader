namespace Domain.Shared.Database.Configuration
{
    public class DatabaseConfig
    {
        public string? Server { get; set; }
        public string? Database { get; set; }
        public string? UserID { get; set; }
        public string? Password { get; set; }
        public bool Trusted_Connection { get; set; }
        public bool TrustServerCertificate { get; set; }

        public string ToConnectionString() => $"Server={Server};Database={Database};User ID={UserID};Password={Password};Trusted_Connection={Trusted_Connection};TrustServerCertificate={TrustServerCertificate};";
    }
}
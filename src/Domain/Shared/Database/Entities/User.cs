﻿namespace Domain.Shared.Database.Entities
{
    public class User
    {
        public long Id { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public bool IsAdministrator { get; set; }
    }
}
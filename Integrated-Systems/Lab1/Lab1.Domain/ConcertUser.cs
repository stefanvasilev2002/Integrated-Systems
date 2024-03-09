using Microsoft.AspNetCore.Identity;

namespace Lab1.Domain;

public class ConcertUser : IdentityUser
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Address { get; set; }
}
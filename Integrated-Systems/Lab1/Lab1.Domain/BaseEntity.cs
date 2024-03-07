using System.ComponentModel.DataAnnotations;

namespace Lab1.Domain;

public class BaseEntity
{
    [Key]
    public Guid Id { get; set; }
}
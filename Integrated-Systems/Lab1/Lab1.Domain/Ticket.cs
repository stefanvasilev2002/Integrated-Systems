namespace Lab1.Domain;

public class Ticket : BaseEntity
{
    public int NumberOfPeople { get; set; }
    public Guid ConcertId { get; set; }
    public Guid ConcertUserId { get; set; }
}
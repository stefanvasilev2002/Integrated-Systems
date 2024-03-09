namespace Lab1.Domain;

public class Concert : BaseEntity
{
    public string ConcertName { get; set; }
    public DateTime ConcertDate { get; set; }
    public int ConcertPrice { get; set; }
    public string ConcertPlace { get; set; }
}
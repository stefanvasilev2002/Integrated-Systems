using Lab1.Domain;

namespace Lab1.Service.Interfaces;

public interface ITicketService
{
    public List<Ticket> GetAllTickets();
    public Ticket GetTicketById(Guid? id);
    public Ticket CreateNewTicket(Ticket newEntity);
    public Ticket UpdateExistingTicket(Ticket updatedTicket);
    public Ticket DeleteTicketById(Guid? id);
    public bool TicketExists(Guid? id);
}
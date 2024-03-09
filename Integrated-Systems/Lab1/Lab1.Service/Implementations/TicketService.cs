using Lab1.Domain;
using Lab1.Repository;
using Lab1.Service.Interfaces;

namespace Lab1.Service.Implementations;

public class TicketService : ITicketService
{
    private readonly IRepository<Ticket> _ticketRepository;

    public TicketService(IRepository<Ticket> ticketRepository)
    {
        _ticketRepository = ticketRepository;
    }

    public List<Ticket> GetAllTickets()
    {
        return _ticketRepository.GetAll().ToList();
    }

    public Ticket GetTicketById(Guid? id)
    {
        return _ticketRepository.GetById(id);
    }

    public Ticket CreateNewTicket(Ticket newEntity)
    {
        return _ticketRepository.Insert(newEntity);
    }

    public Ticket UpdateExistingTicket(Ticket updatedTicket)
    {
        return _ticketRepository.Update(updatedTicket);
    }

    public Ticket DeleteTicketById(Guid? id)
    {
        return _ticketRepository.Delete(GetTicketById(id));
    }

    public bool TicketExists(Guid? id)
    {
        return GetTicketById(id) != null;
    }
}
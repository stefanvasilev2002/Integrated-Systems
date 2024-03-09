using Domain;

namespace Lab1.Service.Interfaces;

public interface IConcertService
{
    public List<Concert> GetAllConcerts();
    public Concert GetConcertById(Guid? id);
    public Concert CreateNewConcert(Concert newEntity);
    public Concert UpdateExistingConcert(Concert updatedConcert);
    public Concert DeleteConcertById(Guid? id);
    public bool ConcertExists(Guid? id);
}
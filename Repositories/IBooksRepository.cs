using RocketseatBookstoreManager.Entities;

namespace RocketseatBookstoreManager.Repositories;

public interface IBooksRepository
{
    void Create(Book book);
    Book? FindById(Guid id);
    List<Book> FindMany();
    void Update(Book book);
    void Delete(Book book);
}

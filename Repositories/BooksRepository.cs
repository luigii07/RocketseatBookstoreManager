using RocketseatBookstoreManager.Entities;

namespace RocketseatBookstoreManager.Repositories;

public class BooksRepository : IBooksRepository
{
    public static List<Book> Books = [];

    public void Create(Book book)
    {
        Books.Add(book);
    }

    public Book? FindById(Guid id)
    {
        var book = Books.Find(book => book.Id == id);

        if (book == null) 
        {
            return null;
        }

        return book;
    }

    public List<Book> FindMany()
    {
        return Books;
    }

    public void Update(Book book)
    {
        var existsBook = Books.First(book => book.Id == book.Id);

        if (existsBook == null)
        {
            return;
        }

        existsBook = book;
    }

    public void Delete(Book book)
    {
        var existsBook = Books.First(book => book.Id == book.Id);

        if (existsBook == null)
        {
            return;
        }

        Books.Remove(existsBook);
    }
}

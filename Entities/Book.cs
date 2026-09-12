using RocketseatBookstoreManager.Enums;

namespace RocketseatBookstoreManager.Entities;

public class Book
{
    public Guid Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string AuthorId { get; set; } = string.Empty;
    public BookGenre Genre { get; set; }
    public decimal Price { get; set; } = decimal.Zero;
    public int Stock { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }

    public Book(string title, string authorId, BookGenre genre, decimal price, int stock, Guid? id = null)
    {
        Title = title;
        AuthorId = authorId;
        Genre = genre;
        Price = price;
        Stock = stock;
        CreatedAt = DateTime.UtcNow;
        UpdatedAt = DateTime.UtcNow;
        Id = id ?? Guid.NewGuid();
    }
}

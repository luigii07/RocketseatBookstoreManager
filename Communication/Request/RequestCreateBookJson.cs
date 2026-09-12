using RocketseatBookstoreManager.Enums;

namespace RocketseatBookstoreManager.Communication.Request;

public class RequestCreateBookJson
{
    public string Title { get; set; } = string.Empty;
    public string AuthorId { get; set; } = string.Empty;
    public BookGenre Genre { get; set; }
    public decimal Price { get; set; } = decimal.Zero;
    public int Stock { get; set; }
}

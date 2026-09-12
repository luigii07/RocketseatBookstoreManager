using Microsoft.AspNetCore.Mvc;
using RocketseatBookstoreManager.Communication.Request;
using RocketseatBookstoreManager.Communication.Response;
using RocketseatBookstoreManager.Entities;
using RocketseatBookstoreManager.Repositories;

namespace RocketseatBookstoreManager.Controllers;

public class BooksController : BookstoreManagerBaseController
{
    private IBooksRepository _booksRepository;

    public BooksController(IBooksRepository booksRepository)
    {
        _booksRepository = booksRepository;
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status400BadRequest)]
    public IActionResult Create([FromBody] RequestCreateBookJson body)
    {
        if (body.Title.Length < 2 || body.Title.Length > 100)
        {
            return BadRequest(new ResponseErrorJson() { Message = "Title must be between 2 and 100 characters" });
        }

        var book = new Book (
            title: body.Title,
            authorId: body.AuthorId,
            genre: body.Genre,
            price: body.Price,
            stock: body.Stock
        );

        _booksRepository.Create(book);

        return Created();
    }

    [HttpGet]
    [ProducesResponseType(typeof(List<Book>), StatusCodes.Status200OK)]
    public IActionResult GetAll()
    {
        var books = _booksRepository.FindMany();

        return Ok(books);
    }

    [HttpPut]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status404NotFound)]
    public IActionResult Update([FromRoute] string id, [FromBody] RequestUpdateBookJson body)
    {
        var book = _booksRepository.FindById(Guid.Parse(id));

        if (book == null)
        {
            return NotFound(new ResponseErrorJson() { Message = "Book not found." });
        }

        book.Title = body.Title;
        book.AuthorId = body.AuthorId;
        book.Genre = body.Genre;
        book.Price = body.Price;
        book.Stock = body.Stock;
        book.UpdatedAt = DateTime.UtcNow;

        _booksRepository.Update(book);

        return NoContent();
    }

    [HttpGet]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status404NotFound)]
    public IActionResult Get([FromRoute] Guid id)
    {
        var book = _booksRepository.FindById(id);

        if (book == null)
        {
            return NotFound(new ResponseErrorJson() { Message = "Book not found." });
        }

        return Ok(book);
    }

    [HttpDelete]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status404NotFound)]
    public IActionResult Delete([FromRoute] Guid id)
    {
        var book = _booksRepository.FindById(id);

        if (book == null)
        {
            return NotFound(new ResponseErrorJson() { Message = "Book not found." });
        }

        _booksRepository.Delete(book);

        return NoContent();
    }
}

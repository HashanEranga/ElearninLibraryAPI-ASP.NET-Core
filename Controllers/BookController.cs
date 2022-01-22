using ElearninLibraryAPI_ASP.Models;
using ElearninLibraryAPI_ASP.Services;
using Microsoft.AspNetCore.Mvc;

namespace ElearninLibraryAPI_ASP.Controllers;

[ApiController]
[Route("[controller]")]

public class BookController : ControllerBase
{
    public BookController()
    {

    }

    // GET All the Books
    [HttpGet]
    public ActionResult <List<Book>> GetAll()=> BookService.GetAll();

    // GET a Book by Book ID
    [HttpGet("{bookId}")]
    public ActionResult <Book> Get(int bookId)
    {
        var book = BookService.Get(bookId);

        if(book == null)
            return NotFound();
        
        return book;
    }

    // POST a new Book item
    [HttpPost]
    public IActionResult Create(Book book)
    {
        BookService.Add(book);
        return CreatedAtAction(nameof(Create), new {BookId = book.BookId, book});
    }

    // DELETE a existing Book item
}
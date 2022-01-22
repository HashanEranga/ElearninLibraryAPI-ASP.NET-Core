namespace ElearninLibraryAPI_ASP.Models;

// implement the Book Schema
public class Book
{
    public int BookId { get; set; }
    public string? BookName { get; set; }
    public bool IsBookBorrowed { get; set; }
    
}
using ElearninLibraryAPI_ASP.Models;

namespace ElearninLibraryAPI_ASP.Services;

public static class BookService
{
    static List<Book> Books {get;}
    static int nextId = 3;
    static BookService()
    {
        Books = new List<Book>{
            new Book { BookId = 1, BookName = "Physics101", IsBookBorrowed = false},
            new Book { BookId = 2, BookName = "General Chemistry", IsBookBorrowed = true}
        };
    }

    public static List<Book> GetAll() => Books;

    public static Book? Get(int BookId) => Books.FirstOrDefault(b => b.BookId == BookId);

    public static void Add(Book book)
    {
        book.BookId = nextId++;
        Books.Add(book);
    }

    public static void Delete(int bookId)
    {
        var book = Get(bookId);
        if(book is null) return;

        Books.Remove(book);
    }

    public static void Update(Book book)
    {
        var index = Books.FindIndex(b => b.BookId == book.BookId);
        if(index == -1) return;

        Books[index] = book;
    }
}
using System.Text.Json;
using BookSRP.Interfaces;
using BookSRP.Models;

namespace BookSRP.Repositories;

public class BookRepository : IBookRepository
{
    private readonly string _storagePath;

    public BookRepository(string storagePath = "./books")
    {
        _storagePath = storagePath;
    }

    public void Save(Book book)
    {
        string filename = $"{book.Title} - {book.Author}.json";
        string filepath = Path.Combine(_storagePath, filename);

        Console.WriteLine($"[BookRepository] Saving book to: {filepath}");
    }

    public Book? Load(string title, string author)
    {
        string filename = $"{title} - {author}.json";
        string filepath = Path.Combine(_storagePath, filename);

        Console.WriteLine($"[BookRepository] Loading book from: {filepath}");
        return null;
    }
}
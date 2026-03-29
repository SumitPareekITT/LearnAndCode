using BookSRP.Models;

namespace BookSRP.Interfaces;

public interface IBookRepository
{
    void Save(Book book);
    Book? Load(string title, string author);
}
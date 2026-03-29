using BookSRP.Models;

namespace BookSRP.Interfaces;

public interface ILibraryLocator
{
    LibraryLocation GetLocation(Book book);
}
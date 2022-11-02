using BookAPI.Models;
using Grpc.Net.Client;
using GrpcService;

namespace BookAPI.Service
{
    public interface IBookService
    {
        public Task<List<Book>> GetAllBooks();
        public Task<List<Book>> GetAllBooksfiltered(string? subject, double? budget);

        public Task <bool> BuyBook (BuyBookDto BuyBookDto);

        public Task<bool> ReturnBook(int bookId);
    }
    public class BookService : IBookService
    {
        public Task<bool> BuyBook(BuyBookDto BuyBookDto)
        {
            throw new NotImplementedException();
        }

        public  async Task<List<Book>> GetAllBooks()
        {
            var channel = GrpcChannel.ForAddress("https://localhost:7011");
            var client = new Greeter.GreeterClient(channel);
            var ost =  client.GetAllBooks(new Empty());
           var listOfBooks =  ost.BookReply.Select(b => new Book { Subject = b.Subject, Title = b.Title, Author = b.Author, Price = b.Price, ReleaseDate = b.ReleaseDate, IsAvailable = b.IsAvaible, StudyProgrammeId = b.StudyProgrammeId }).ToList();
            return listOfBooks;
        }

        public Task<List<Book>> GetAllBooksfiltered(string? subject, double? budget)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ReturnBook(int bookId)
        {
            throw new NotImplementedException();
        }
    }
}

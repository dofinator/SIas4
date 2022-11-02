using Grpc.Core;
using GrpcService;
using GrpcService.Models;
using GrpcService.Repository;
using System;

namespace GrpcService.Services
{
    public class BookService : Greeter.GreeterBase
    {
        private readonly IBookRepository _bookRepository;
        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }
        public override async Task <BookReplyList> GetAllBooks(Empty empty, ServerCallContext context)
        {
           var ost = await _bookRepository.GetAllBooks().Select(b => new BookReply {Subject = b.Subject, Title = b.Title, Author = b.Author, Price = b.Price, ReleaseDate = b.ReleaseDate, IsAvaible = b.IsAvailable, StudyProgrammeId = b.StudyProgrammeId }).ToList();
            var bookReplyList = new BookReplyList();
            bookReplyList.BookReply.AddRange(ost);

            return  bookReplyList;
            
          

        }
        //public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
        //{
        //    return Task.FromResult(new HelloReply
        //    {
        //        Message = "Hello " + request.Name
        //    });
        //}
    }
}
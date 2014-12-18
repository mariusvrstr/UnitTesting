// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BookRepository.cs" company="Spikes">
//   Spikes
// </copyright>
// <summary>
//   Book Repository
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Spikes.Library.Books
{
    using System;
    using Contracts;
    using Contracts.Books;
    using Contracts.Exceptions;
    using DataStub;

    /// <summary>
    /// Book Repository
    /// </summary>
    public class BookRepository : IBookRepository
    {
        /// <summary>
        /// The author repo
        /// </summary>
        private IAuthorRepository authorRepo;

        /// <summary>
        /// Initializes a new instance of the <see cref="BookRepository"/> class.
        /// </summary>
        public BookRepository()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BookRepository"/> class.
        /// </summary>
        /// <param name="authorRepo">The author repo.</param>
        public BookRepository(IAuthorRepository authorRepo)
        {
            this.authorRepo = authorRepo;
        }

        /// <summary>
        /// Gets the author repo.
        /// </summary>
        /// <value>The author repo</value>
        public IAuthorRepository AuthorRepo
        {
            get
            {
                return this.authorRepo ?? (this.authorRepo = RepositoryFactory.CreateAuthorRepository());
            }
        }

        /// <summary>
        /// Adds the book.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>A Book</returns>
        public Book AddBook(AddBookRequest request)
        {
            var author = this.AuthorRepo.GetAuthorById(request.AuthorId);

            if (author == null)
            {
                throw new AuthorNotFoundException();
            }

            var book = new Book
                    {
                        Id = Guid.NewGuid(),
                        Author = author
                    };

            Database.Books.Add(book);
               
            return book;
        }

        /// <summary>
        /// Removes the book.
        /// </summary>
        /// <param name="bookId">The book identifier.</param>
        /// <returns>Successful removal</returns>
        public bool RemoveBook(Guid bookId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Updates the book.
        /// </summary>
        /// <param name="book">The book.</param>
        /// <returns>Successful update</returns>
        public bool UpdateBook(Book book)
        {
            throw new NotImplementedException();
        }
    }
}

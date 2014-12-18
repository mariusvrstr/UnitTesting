// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IBookRepository.cs" company="Spikes">
//   Spikes
// </copyright>
// <summary>
//   Book Repository Contract
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Spikes.Contracts
{
    using System;

    using Contracts.Books;

    /// <summary>
    /// Book Repository Contract
    /// </summary>
    public interface IBookRepository
    {
        /// <summary>
        /// Gets the author repo.
        /// </summary>
        /// <value>The author repo</value>
        IAuthorRepository AuthorRepo { get; }

        /// <summary>
        /// Adds the book.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>A Book</returns>
        Book AddBook(AddBookRequest request);

        /// <summary>
        /// Removes the book.
        /// </summary>
        /// <param name="bookId">The book identifier.</param>
        /// <returns>Successful removal</returns>
        bool RemoveBook(Guid bookId);

        /// <summary>
        /// Updates the book.
        /// </summary>
        /// <param name="book">The book.</param>
        /// <returns>Successful update</returns>
        bool UpdateBook(Book book);
    }
}

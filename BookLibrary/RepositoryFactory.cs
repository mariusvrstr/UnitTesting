// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RepositoryFactory.cs" company="Spikes">
//   Spikes
// </copyright>
// <summary>
//   Defines the RepositoryFactory type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Spikes.Library
{
    using Contracts;
    using Spikes.Library.Authors;
    using Spikes.Library.Books;

    /// <summary>
    /// Repository Factory
    /// </summary>
    public static class RepositoryFactory
    {
        /// <summary>
        /// Creates the author repository.
        /// </summary>
        /// <returns>Author Repository</returns>
        public static IAuthorRepository CreateAuthorRepository()
        {
            return new AuthorRepository();
        }

        /// <summary>
        /// Creates the book repository.
        /// </summary>
        /// <returns>Author Repository</returns>
        public static IBookRepository CreateBookRepository()
        {
            return new BookRepository();
        }
    }
}

// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Database.cs" company="Spikes">
//   Spikes
// </copyright>
// <summary>
//   Defines the Database type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Spikes.DataStub
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    using Spikes.Contracts.Authors;
    using Spikes.Contracts.Books;

    /// <summary>
    /// Database Box
    /// </summary>
    public static class Database
    {
        /// <summary>
        /// The books
        /// </summary>
        private static ICollection<Book> books;

        /// <summary>
        /// The authors
        /// </summary>
        private static ICollection<Author> authors;
        
        /// <summary>
        /// Gets the books.
        /// </summary>
        /// <value>
        /// The books.
        /// </value>
        public static ICollection<Book> Books
        {
            get
            {
                return books ?? (books = new Collection<Book>());
            }
        }

        /// <summary>
        /// Gets the authors.
        /// </summary>
        /// <value>
        /// The authors.
        /// </value>
        public static ICollection<Author> Authors
        {
            get
            {
                return authors ?? (authors = new Collection<Author>());
            }
        }

        /// <summary>
        /// Clears the data.
        /// </summary>
        public static void ClearData()
        {
            books = null;
            authors = null;
        }
    }
}

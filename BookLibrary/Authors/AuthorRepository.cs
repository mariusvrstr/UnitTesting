// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AuthorRepository.cs" company="Spikes">
//   Spikes
// </copyright>
// <summary>
//   Defines the AuthorRepository type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Spikes.Library.Authors
{
    using System;
    using System.Linq;
    using DataStub;
    using Spikes.Contracts;
    using Spikes.Contracts.Authors;
    using Spikes.Contracts.Exceptions;

    /// <summary>
    /// Author Repository
    /// </summary>
    public class AuthorRepository : IAuthorRepository
    {
        /// <summary>
        /// Adds the author.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>Added User</returns>
        public Author AddAuthor(AddAuthorRequest request)
        {
            var author = new Author
                    {
                        Id = Guid.NewGuid(),
                        BirthDay = request.BirthDay,
                        Name = request.Name,
                        Surname = request.Surname
                    };

            Database.Authors.Add(author);

            return author;
        }

        /// <summary>
        /// Removes the author.
        /// </summary>
        /// <param name="authorId">The author identifier.</param>
        /// <returns>Successful removal</returns>
        public bool RemoveAuthor(Guid authorId)
        {
            var author = Database.Authors.FirstOrDefault(auth => auth.Id == authorId);

            if (author == null)
            {
                throw new AuthorNotFoundException();
            }

            Database.Authors.Remove(author);

            return true;
        }

        /// <summary>
        /// Gets the author by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>The author</returns>
        public Author GetAuthorById(Guid id)
        {
            return Database.Authors.FirstOrDefault(auth => auth.Id == id);
        }
    }
}

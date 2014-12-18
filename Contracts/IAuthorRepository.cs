// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IAuthorRepository.cs" company="Spikes">
//   Spikes
// </copyright>
// <summary>
//   Defines the IAuthorRepository type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Spikes.Contracts
{
    using System;

    using Spikes.Contracts.Authors;

    /// <summary>
    /// Author Repository Contract
    /// </summary>
    public interface IAuthorRepository
    {
        /// <summary>
        /// Adds the author.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>Added author</returns>
        Author AddAuthor(AddAuthorRequest request);

        /// <summary>
        /// Removes the author.
        /// </summary>
        /// <param name="authorId">The author identifier.</param>
        /// <returns>Successful remove</returns>
        bool RemoveAuthor(Guid authorId);

        /// <summary>
        /// Gets the author by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>The author</returns>
        Author GetAuthorById(Guid id);
    }
}

// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AddBookRequest.cs" company="Spikes">
//   Spikes
// </copyright>
// <summary>
//   Defines the AddBookRequest type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Spikes.Contracts.Books
{
    using System;

    /// <summary>
    /// Add Book Request
    /// </summary>
    public class AddBookRequest
    {
        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the release date.
        /// </summary>
        /// <value>
        /// The release date.
        /// </value>
        public DateTime ReleaseDate { get; set; }

        /// <summary>
        /// Gets or sets the author identifier.
        /// </summary>
        /// <value>
        /// The author identifier.
        /// </value>
        public Guid AuthorId { get; set; }
    }
}

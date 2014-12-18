// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Book.cs" company="Spikes">
//   Copyright Spikes
// </copyright>
// <summary>
//   The Book Entity
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Spikes.Contracts.Books
{
    using System;
    using Spikes.Contracts.Authors;

    /// <summary>
    /// The Book Entity
    /// </summary>
    public class Book
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public Guid Id { get; set; }

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
        /// Gets or sets the author.
        /// </summary>
        /// <value>
        /// The author.
        /// </value>
        public Author Author { get; set; }

        /// <summary>
        /// Determines whether the specified <see cref="System.Object" />, is equal to this instance.
        /// </summary>
        /// <param name="obj">The <see cref="System.Object" /> to compare with this instance.</param>
        /// <returns>
        ///   <c>true</c> if the specified <see cref="System.Object" /> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (obj.GetType() != this.GetType())
            {
                return false;
            }

            return this.Equals((Book)obj);
        }

        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        /// <returns>
        /// A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. 
        /// </returns>
        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = this.Id.GetHashCode();
                hashCode = (hashCode * 397) ^ (this.Title != null ? this.Title.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ this.ReleaseDate.GetHashCode();
                hashCode = (hashCode * 397) ^ (this.Author != null ? this.Author.GetHashCode() : 0);
                return hashCode;
            }
        }

        /// <summary>
        /// Equals the specified other.
        /// </summary>
        /// <param name="other">The other.</param>
        /// <returns>Is Equal</returns>
        protected bool Equals(Book other)
        {
            return this.Id.Equals(other.Id) && string.Equals(this.Title, other.Title) && this.ReleaseDate.Equals(other.ReleaseDate) && Equals(this.Author, other.Author);
        }
    }
}

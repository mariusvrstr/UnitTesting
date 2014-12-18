// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Author.cs" company="Spikes">
//   Spikes
// </copyright>
// <summary>
//   Author Entity
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Spikes.Contracts.Authors
{
    using System;

    /// <summary>
    /// Author Entity
    /// </summary>
    public class Author
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the surname.
        /// </summary>
        /// <value>
        /// The surname.
        /// </value>
        public string Surname { get; set; }

        /// <summary>
        /// Gets or sets the birth day.
        /// </summary>
        /// <value>
        /// The birth day.
        /// </value>
        public DateTime BirthDay { get; set; }

        /// <summary>
        /// Gets the get age.
        /// </summary>
        /// <value>The get age</value>
        public int Age
        {
            get
            {
                var zeroTime = new DateTime(1, 1, 1);
                var timespan = DateTime.Now - this.BirthDay;

                return (zeroTime + timespan).Year - 1;
            }
        }

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

            return this.Equals((Author)obj);
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
                hashCode = (hashCode * 397) ^ (this.Name != null ? this.Name.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (this.Surname != null ? this.Surname.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ this.BirthDay.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// Equals the specified other.
        /// </summary>
        /// <param name="other">The other.</param>
        /// <returns>Is Equal</returns>
        protected bool Equals(Author other)
        {
            return this.Id.Equals(other.Id) && string.Equals(this.Name, other.Name) && string.Equals(this.Surname, other.Surname) && this.BirthDay.Equals(other.BirthDay);
        }
    }
}

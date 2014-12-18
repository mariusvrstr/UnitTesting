// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AddAuthorRequest.cs" company="Spikes">
//   Spikes
// </copyright>
// <summary>
//   Add Author Request
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Spikes.Contracts.Authors
{
    using System;

    /// <summary>
    /// Add Author Request
    /// </summary>
    public class AddAuthorRequest
    {
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
    }
}

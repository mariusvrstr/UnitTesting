// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AuthorBuilder.cs" company="Spikes">
//   Spikes
// </copyright>
// <summary>
//   Author Builder
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Spikes.DataStub.Builders
{
    using System;
    using Spikes.Contracts.Authors;

    /// <summary>
    /// Author Builder
    /// </summary>
    public class AuthorBuilder : Author
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorBuilder"/> class.
        /// </summary>
        public AuthorBuilder()
        {
            this.Id = Guid.NewGuid();
        }
        
        /// <summary>
        /// Gets or sets the birthday.
        /// </summary>
        /// <value>
        /// The birthday.
        /// </value>
        private DateTime Birthday { get; set; }

        /// <summary>
        /// Authors the one.
        /// </summary>
        /// <returns>Author Owner</returns>
        public AuthorBuilder AuthorOne()
        {
            this.Name = "Marius";
            this.Surname = "Vorster";
            this.Birthday = new DateTime(1986, 3, 4);

            return this;
        }

        /// <summary>
        /// Wilbur Smith
        /// </summary>
        /// <returns>Builder instance</returns>
        public AuthorBuilder WilburSmith()
        {
            this.Name = "Wilbur";
            this.Surname = "Smith";
            this.Birthday = new DateTime(1933, 1, 9);

            return this;
        }
        
        /// <summary>
        /// Clive the Custler.
        /// </summary>
        /// <returns>Builder instance</returns>
        public AuthorBuilder CliveCustler()
        {
            this.Name = "Clive";
            this.Surname = "Custler";
            this.Birthday = new DateTime(1931, 6, 15);
      
            return this;
        }

        /// <summary>
        /// Builds the author.
        /// </summary>
        /// <returns>Build Author</returns>
        public Author Build()
        {
            return new Author
                       {
                           Id = this.Id,
                           Name = this.Name,
                           Surname = this.Surname,
                           BirthDay = this.Birthday
                       };
        }

        /// <summary>
        /// Builds the author request.
        /// </summary>
        /// <returns>Build Author Request</returns>
        public AddAuthorRequest BuildRequest()
        {
            return new AddAuthorRequest
            {
                Name = this.Name,
                Surname = this.Surname,
                BirthDay = this.Birthday
            };
        }
    }
}

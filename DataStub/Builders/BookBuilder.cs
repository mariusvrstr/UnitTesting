// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BookBuilder.cs" company="Spikes">
//   Copyright Spikes
// </copyright>
// <summary>
//   Defines the BookBuilder type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Spikes.DataStub.Builders
{
    using System;
    using Spikes.Contracts.Books;
    using Spikes.DataStub.ObjectMother;

    /// <summary>
    /// Book Builder
    /// </summary>
    public class BookBuilder : Book
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BookBuilder"/> class.
        /// </summary>
        public BookBuilder()
        {
            this.Id = Guid.NewGuid();
        }

        /// <summary>
        /// Deeps the six.
        /// </summary>
        /// <returns>Deep Six</returns>
        public BookBuilder BookWithoutAuthor()
        {
            this.Title = "Eragon";
            this.Author = null;
            this.ReleaseDate = new DateTime(2002);

            return this;
        }

        /// <summary>
        /// Deeps the six.
        /// </summary>
        /// <returns>Deep Six</returns>
        public BookBuilder DeepSix()
        {
            this.Title = "Deep Six";
            this.Author = ObjectMother.Instance.Authors.CliveCustler;
            this.ReleaseDate = new DateTime(1984);

            return this;
        }

        /// <summary>
        /// Pacific the Vortex.
        /// </summary>
        /// <returns>Pacific Vortex</returns>
        public BookBuilder PacificVortex()
        {
            this.Title = "Pacific Vortex";
            this.Author = ObjectMother.Instance.Authors.CliveCustler;
            this.ReleaseDate = new DateTime(1983);

            return this;
        }

        /// <summary>
        /// Assegais this instance.
        /// </summary>
        /// <returns>Assegai book</returns>
        public BookBuilder Assegai()
        {
            this.Title = "Assegai";
            this.Author = ObjectMother.Instance.Authors.WilburSmith;
            this.ReleaseDate = new DateTime(2009);

            return this;
        }

        /// <summary>
        /// Birds of pray.
        /// </summary>
        /// <returns>Birds of pray</returns>
        public BookBuilder BirdsOfPray()
        {
            this.Title = "Pacific Vortex";
            this.Author = ObjectMother.Instance.Authors.WilburSmith;
            this.ReleaseDate = new DateTime(1997);

            return this;
        }

        /// <summary>
        /// Birds of pray.
        /// </summary>
        /// <returns>Birds of pray</returns>
        public BookBuilder BookOne()
        {
            this.Title = "Test Book";
            this.Author = ObjectMother.Instance.Authors.CliveCustler;
            this.ReleaseDate = new DateTime(2002);

            return this;
        }

        /// <summary>
        /// Builds this instance.
        /// </summary>
        /// <returns>The book</returns>
        public Book Build()
        {
            return new Book
                       {
                           Id = this.Id,
                           Author = this.Author,
                           ReleaseDate = this.ReleaseDate,
                           Title = this.Title
                       };
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>Add book request</returns>
        public AddBookRequest BuildRequest()
        {
            return new AddBookRequest
                       {
                           AuthorId = (this.Author != null) ? this.Author.Id : Guid.NewGuid(),
                           ReleaseDate = this.ReleaseDate,
                           Title = this.Title
                       };
        }
    }
}

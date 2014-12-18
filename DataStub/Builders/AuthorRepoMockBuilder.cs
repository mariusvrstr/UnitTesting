// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AuthorRepoMockBuilder.cs" company="Spikes">
//   Copyright Spikes
// </copyright>
// <summary>
//   Defines the AuthorRepositoryMockBuilder type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Spikes.DataStub.Builders
{
    using System;
    using Rhino.Mocks;
    using Spikes.Contracts;
    using Spikes.Contracts.Authors;

    /// <summary>
    /// Author Repository Mock Builder
    /// </summary>
    public class AuthorRepoMockBuilder
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorRepoMockBuilder"/> class.
        /// </summary>
        public AuthorRepoMockBuilder()
        {
            this.Repo = MockRepository.GenerateStub<IAuthorRepository>();
        }

        /// <summary>
        /// Gets or sets the repo.
        /// </summary>
        /// <value>The repo</value>
        private IAuthorRepository Repo { get; set; }

        /// <summary>
        /// Gets the author by identifier.
        /// </summary>
        /// <param name="authorId">The author identifier.</param>
        /// <param name="author">The author.</param>
        /// <param name="expectCall">if set to <c>true</c> [expect call].</param>
        /// <returns>A fluent object</returns>
        public AuthorRepoMockBuilder GetAuthorById(Guid? authorId, Author author, bool expectCall = false)
        {
            if (authorId != null)
            {
                this.Repo.Stub(auth => auth.GetAuthorById(authorId.Value)).Return(author);
            }
            else
            {
                this.Repo.Stub(auth => auth.GetAuthorById(Arg<Guid>.Is.Anything)).Return(author);
            }

            if (expectCall)
            {
                this.Repo.Expect(auth => auth.GetAuthorById(Arg<Guid>.Is.Anything));
            }
            
            return this;
        }

        /// <summary>
        /// Builds this instance.
        /// </summary>
        /// <returns>The mocked repository</returns>
        public IAuthorRepository Build()
        {
            return this.Repo;
        }
    }
}

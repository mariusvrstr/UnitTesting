// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BookData.cs" company="Spikes">
//   Copyright Spikes
// </copyright>
// <summary>
//   Defines the BookData type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Spikes.DataStub.ObjectMother
{
    using Spikes.Contracts.Books;
    using Spikes.DataStub.Builders;

    /// <summary>
    /// Book Data
    /// </summary>
    public class BookData
    {
        /// <summary>
        /// Gets or sets the deep six.
        /// </summary>
        /// <value>The deep six.</value>
        public Book DeepSix { get; set; }

        /// <summary>
        /// Gets or sets the Pacific Vortex.
        /// </summary>
        /// <value>The pacific Vortex</value>
        public Book PacificVortex { get; set; }

        /// <summary>
        /// Gets or sets the assegai.
        /// </summary>
        /// <value>The assegai</value>
        public Book Assegai { get; set; }

        /// <summary>
        /// Gets or sets the birds of pray.
        /// </summary>
        /// <value>The birds of pray</value>
        public Book BirdsOfPray { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorData" /> class.
        /// </summary>
        /// <returns>The book data</returns>
        public BookData Init()
        {
            this.DeepSix = new BookBuilder().DeepSix().Build();
            Database.Books.Add(this.DeepSix);

            this.PacificVortex = new BookBuilder().PacificVortex().Build();
            Database.Books.Add(this.PacificVortex);

            this.Assegai = new BookBuilder().Assegai().Build();
            Database.Books.Add(this.Assegai);

            this.BirdsOfPray = new BookBuilder().BirdsOfPray().Build();
            Database.Books.Add(this.BirdsOfPray);

            return this;
        }
    }
}

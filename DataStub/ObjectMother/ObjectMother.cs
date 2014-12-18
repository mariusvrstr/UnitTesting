// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ObjectMother.cs" company="Spikes">
//   Copyright Spikes
// </copyright>
// <summary>
//   Defines the ObjectMother type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Spikes.DataStub.ObjectMother
{
    /// <summary>
    /// Object Mother
    /// </summary>
    public class ObjectMother
    {
        /// <summary>
        /// The instance
        /// </summary>
        private static ObjectMother instance;

        /// <summary>
        /// Gets the instance.
        /// </summary>
        /// <value>The instance</value>
        public static ObjectMother Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ObjectMother();
                    instance.Init();
                }

                return instance;
            }
        }

        /// <summary>
        /// Gets or sets the authors.
        /// </summary>
        /// <value>The authors</value>
        public AuthorData Authors { get; set; }

        /// <summary>
        /// Gets or sets the books.
        /// </summary>
        /// <value>The books</value>
        public BookData Books { get; set; }
        
        /// <summary>
        /// Clears the data.
        /// </summary>
        public void ResetData()
        {
            Database.ClearData();
            instance = null;
        }

        /// <summary>
        /// Initializes this instance.
        /// </summary>
        private void Init()
        {
            this.Authors = new AuthorData().Init();
            this.Books = new BookData().Init();
        }
    }
}

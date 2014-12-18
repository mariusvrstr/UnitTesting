// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AuthorData.cs" company="Spikes">
//   Copyright Spikes
// </copyright>
// <summary>
//   Author Data
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Spikes.DataStub.ObjectMother
{
    using Spikes.Contracts.Authors;
    using Spikes.DataStub.Builders;

    /// <summary>
    /// Author Data
    /// </summary>
    public class AuthorData
    {
        /// <summary>
        /// Gets or sets the Clive Custler.
        /// </summary>
        /// <value> The clive Custler. </value>
        public Author CliveCustler { get; set; }
        
        /// <summary>
        /// Gets or sets the Wilbur Smith.
        /// </summary>
        /// <value>The Wilbur Smith</value>
        public Author WilburSmith { get; set; }

        /// <summary>
        /// Initializes this instance.
        /// </summary>
        /// <returns>The updated instance</returns>
        public AuthorData Init()
        {
            this.CliveCustler = new AuthorBuilder().CliveCustler().Build();
            Database.Authors.Add(this.CliveCustler);
             
            this.WilburSmith = new AuthorBuilder().WilburSmith().Build();
            Database.Authors.Add(this.WilburSmith);

            return this;
        }
    }
}

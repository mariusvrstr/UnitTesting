// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AuthorTestWorker.cs" company="Spikes">
//   Copyright Spikes
// </copyright>
// <summary>
//   The author test worker.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Spikes.UnitTests.Workers
{
    using System;

    /// <summary>
    /// The author test worker.
    /// </summary>
    public static class AuthorTestWorker
    {
        /// <summary>
        /// Calculates the age.
        /// </summary>
        /// <param name="birthday">The birthday.</param>
        /// <returns>The age</returns>
        public static int CalculateAge(DateTime birthday)
        {
            var zeroTime = new DateTime(1, 1, 1);
            var timespan = DateTime.Now - birthday;

            return (zeroTime + timespan).Year - 1;
        }
    }
}

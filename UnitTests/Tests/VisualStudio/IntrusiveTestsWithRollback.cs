
namespace Spikes.UnitTests.Tests.VisualStudio
{
    using System.Transactions;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using DataStub.ObjectMother;
    using Library;

    [TestClass]
    public class IntrusiveTestsWithRollback
    {
        private TransactionScope _transaction;

        /// <summary>
        /// Initializes this instance.
        /// </summary>
        [TestInitialize]
        public void Initialize()
        {
            this._transaction = new TransactionScope(TransactionScopeOption.RequiresNew);
            ObjectMother.Instance.ResetData();
        }

        /// <summary>
        /// Cleanup this instance.
        /// </summary>
        [TestCleanup]
        public void Cleanup()
        {
            this._transaction.Dispose();
        }

        /// <summary>
        /// Intrusive the test that does not persist changes.
        /// </summary>
        [TestMethod]
        public void IntrusiveTestThatDoesNotPersistChanges()
        {
            // Ensure that 'Distributed Transaction Coordinato' service is running
            // Any context that is created will be linked to the encapsulating transaction
            var repo = RepositoryFactory.CreateAuthorRepository();
            var author = ObjectMother.Instance.Authors.CliveCustler;

            // Ensure author exists
            Assert.IsNotNull(repo.GetAuthorById(author.Id));

            repo.RemoveAuthor(author.Id);

            // Ensure author is gone
            Assert.IsNull(repo.GetAuthorById(author.Id));
        }
    }
}

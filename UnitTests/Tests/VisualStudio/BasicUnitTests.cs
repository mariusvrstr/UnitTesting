
namespace Spikes.UnitTests.Tests.VisualStudio
{
    using System.Linq;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Contracts.Exceptions;
    using DataStub;
    using DataStub.Builders;
    using DataStub.ObjectMother;
    using Library;

    [TestClass]
    public class BasicUnitTests
    {
        /// <summary>
        /// Initializes the test data.
        /// </summary>
        [TestInitialize]
        public void InitializeTestData()
        {
            ObjectMother.Instance.ResetData();
        }

        /// <summary>
        /// Ensures the unit test fails.
        /// </summary>
        [TestMethod]
        public void SetErrorAssertResult()
        {
            Assert.Fail("Unit test not yet implimented");
        }

        /// <summary>
        /// Ensures the unit test fails.
        /// </summary>
        [TestMethod]
        public void SetInconclusiveAssertResult()
        {
            if (true)
            {
                Assert.Inconclusive("This test do not have a conclusive result");
            }
             
            Assert.IsTrue(true);
        }

        /// <summary>
        /// Ignores the units tests that is not ready.
        /// </summary>
        [TestMethod, Ignore]
        public void IgnoreUnitsTestsThatIsNotReady()
        {
            // Do not submit failing unit tests, if you need to commit a version that is not working disable those tests
            // TODO: Explination on what this test is supposed to do
        }

        /// <summary>
        /// Ignores the units tests that is not ready.
        /// </summary>
        [TestMethod]
        [Timeout(TestTimeout.Infinite)]
        public void LongRunningUnitTestShouldNotTimeout()
        {
            Assert.IsTrue(true);
        }

        /// <summary>
        /// Ignores the units tests that is not ready.
        /// </summary>
        [TestMethod]
        public void TestingWithValueAsserts()
        {
            const int expected = 33;

            Assert.IsTrue(true);
            Assert.IsNotNull(new object());
            Assert.IsNull(null);
            Assert.AreEqual(expected, 30 + 3);
        }

        /// <summary>
        /// Adds the author must succeed.
        /// </summary>
        [TestMethod]
        public void AddAuthorWithSuccess()
        {
            var repo = RepositoryFactory.CreateAuthorRepository();
            var request = new AuthorBuilder().AuthorOne().BuildRequest();

            var response = repo.AddAuthor(request);

            var found = Database.Authors.FirstOrDefault(auth => auth.Id == response.Id);

            Assert.AreEqual(response, found);
        }
        
        /// <summary>
        /// Gets the author by identifier must succeed.
        /// </summary>
        [TestMethod]
        public void GetAuthorByIdMustSucceed()
        {
            var repo = RepositoryFactory.CreateAuthorRepository();

            var author = repo.GetAuthorById(ObjectMother.Instance.Authors.CliveCustler.Id);

            Assert.IsNotNull(author);
            Assert.IsTrue(ObjectMother.Instance.Authors.CliveCustler.Equals(author));
        }

        /// <summary>
        /// Adding a book with invalid author should fail.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(AuthorNotFoundException))]
        public void AddingBookWithInvalidAuthorShouldFail()
        {
            var repo = RepositoryFactory.CreateBookRepository();

            repo.AddBook(new BookBuilder().BookWithoutAuthor().BuildRequest());
        }
    }
}

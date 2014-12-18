
namespace Spikes.UnitTests.Tests.VisualStudio
{
    using System;
    using System.Fakes;
    using Microsoft.QualityTools.Testing.Fakes;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Contracts.Authors.Fakes;
    using Contracts.Books;
    using DataStub.Builders;
    using DataStub.ObjectMother;
    using Library;
    using Library.Books;
    using Library.Books.Fakes;

    [TestClass]
    public class IsolationUsingFakes
    {
        /// <summary>
        /// Initializes the class.
        /// </summary>
        [TestInitialize]
        public void InitializeClass()
        {
            ObjectMother.Instance.ResetData();
        }

        /// <summary>
        /// Tests the using delegate SHIM.
        /// </summary>
        [TestMethod, Ignore] // Only VS Premium and Ultimate has Fakes
        public void TestShimPropertyDelegateForDateTimeNow()
        {
            int response;
            const int expected = 77;
            
            using (ShimsContext.Create())
            {
                // Generate fake DLL by right clicking on DLL reference 'System' (Unit Test Project) with interface and selecting 'Add Fakes Assembly'
                ShimDateTime.NowGet = () => new DateTime(2009, 1, 1);

                var repo = RepositoryFactory.CreateAuthorRepository();
                response = repo.GetAuthorById(ObjectMother.Instance.Authors.CliveCustler.Id).Age;
            }

            Assert.AreEqual(expected, response);
        }
        
        /// <summary>
        /// Tests the with SHIV complete dependant repository.
        /// </summary>
        [TestMethod, Ignore] // Only VS Premium and Ultimate has Fakes
        public void TestWithShivCompleteDependantRepository()
        {
            var author = new AuthorBuilder().CliveCustler().Build();
            var request = new BookBuilder().DeepSix().BuildRequest();
            Book response;

            using (ShimsContext.Create())
            {
                // Create SHIV
                var stubAuthRepo = new Contracts.Fakes.StubIAuthorRepository
                               { 
                                   // Method = (parameters) => { method }
                                   GetAuthorByIdGuid = id => author 
                               };

                // SHIM the property that retrieves the repository
                ShimBookRepository.AllInstances.AuthorRepoGet = _ => stubAuthRepo;

                var repo = new BookRepository();
                response = repo.AddBook(request);
            }

            Assert.IsNotNull(response);
            Assert.AreEqual(author, response.Author);
        }

        /// <summary>
        /// Tests the using delegate SHIM.
        /// </summary>
        [TestMethod, Ignore] // Only VS Premium and Ultimate has Fakes
        public void TestShimCustomPropertyDelegate()
        {
            int response;
            const int expected = 70;

            using (ShimsContext.Create())
            {
                ShimAuthor.AllInstances.AgeGet = _ => expected;
                
                var repo = RepositoryFactory.CreateAuthorRepository();
                response = repo.GetAuthorById(ObjectMother.Instance.Authors.CliveCustler.Id).Age;
            }

            Assert.AreEqual(expected, response);
        }
    }
}

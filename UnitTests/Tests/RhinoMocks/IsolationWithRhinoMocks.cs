
namespace Spikes.UnitTests.Tests.RhinoMocks
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Rhino.Mocks;
    using Contracts;
    using DataStub.Builders;
    using DataStub.ObjectMother;
    using Library.Books;

    [TestClass]
    public class IsolationWithRhinoMocks
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
        /// Mocks the author repository from books.
        /// </summary>
        [TestMethod]
        public void MockAuthorRetrievalForBooksRepository()
        {
            var bookBuilder = new BookBuilder().BookWithoutAuthor();
            var authorBuilder = new AuthorBuilder().CliveCustler();

            // Setup author stub = Required for test
            var stubAuthorRepo =
                 MockRepository.GenerateStub<IAuthorRepository>();

            // Create a stub repository for Author
            stubAuthorRepo.Stub(auth => auth.GetAuthorById(Arg<Guid>.Is.Anything))
                          .Return(authorBuilder.Build());

            var repo = new BookRepository(stubAuthorRepo);
            var book = repo.AddBook(bookBuilder.BuildRequest());

            Assert.IsNotNull(book);
            Assert.AreEqual(authorBuilder.Build().Id, book.Author.Id);
        }

        /// <summary>
        /// Mocks the author repository from books.
        /// </summary>
        [TestMethod]
        public void VerifyThatSpecificMethodsWasExecutedBehindCall()
        {
            var stubAuthorRepo = new AuthorRepoMockBuilder().GetAuthorById(
                null, ObjectMother.Instance.Authors.CliveCustler, true).Build();

            var repo = new BookRepository(stubAuthorRepo);
            var book = repo.AddBook(new BookBuilder().BookOne().BuildRequest());

            repo.AuthorRepo.VerifyAllExpectations();
            Assert.IsNotNull(book);
            Assert.AreEqual(ObjectMother.Instance.Authors.CliveCustler.Id, book.Author.Id);
        }
    }
}

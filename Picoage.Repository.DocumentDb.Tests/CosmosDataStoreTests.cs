namespace Picoage.Repository.DocumentDb.Tests
{
    [TestClass]

    public class CosmosDataStoreTests
    {
        [TestMethod]
        public async Task Should_Savedata_ToCosmos()
        {
            //Arrange
            IDataStore<TestRepo> dataStore = new CosmosDataStore<TestRepo>();
            TestRepo testRepo = new TestRepo { Id = "1234", QueryId = "234", Description = "TestDes", Name = "Testname" };

            //Act
            await dataStore.UpsertAsync(testRepo);
            TestRepo actual = await dataStore.FindAsync(e => e.Id == testRepo.Id);


            //Assert
            Assert.IsNotNull(actual);
            Assert.AreSame(testRepo, actual);

            await dataStore.DeleteAsync(e => e.Id == testRepo.Id);
        }

    }
}

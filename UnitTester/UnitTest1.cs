using Vs_Toemrer_Lagerstyringssystemsprojekt.Business_Infrastructure;
using Vs_Toemrer_Lagerstyringssystemsprojekt.Model;
using Vs_Toemrer_Lagerstyringssystemsprojekt.Persistence;
using Vs_Toemrer_Lagerstyringssystemsprojekt.Persistence.MaterialRepositories;

namespace UnitTester
{
    [TestClass]
    public class UnitTest1
    {
        private WoodRepository woodRepo;
        private NailRepository nailRepo;
        private ScrewRepository screwRepo;
        private ProjectRepository projectRepo;
        private MaterialSearchService<IMaterial> mss;

        [TestInitialize]
        public void Setup()
        {
            woodRepo = WoodRepository.Instance;
            nailRepo = NailRepository.Instance;
            screwRepo = ScrewRepository.Instance;
            projectRepo = ProjectRepository.Instance;
            mss = new MaterialSearchService<IMaterial>(woodRepo, nailRepo, screwRepo);
        }

        [TestMethod]
        public void MaterialSearchServiceReturnsBasedOnASearchTerm()
        {
            // This TestMethod is directly tied to the database, as the repository cannot be accessed without the database.

            // Arrange
            string searchTerm = "p";

            // Act
            var results = mss.SearchMaterials(searchTerm).Select(m => m.Name).ToList();

            // Assert
            var expectedResults = new List<string> { "Phillips 5mm Hardened", "Philips Head 10x0,5mm Greasy!" }; // This variable needs to change based on whatever is in the repositories...
            CollectionAssert.AreEqual(expectedResults, results);
        }
    }
}
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
            // Arrange
            var searchTerm = "p";

            // Create new instances of repositories
            var nailRepo = NailRepository.Instance;
            var screwRepo = ScrewRepository.Instance;
            var woodRepo = WoodRepository.Instance;

            // Clear existing materials for a clean test environment
            ClearRepositories(nailRepo, screwRepo, woodRepo);

            // Add test materials to the repositories
            nailRepo.GetAll().Add(new Nail(5.0, "Squared", 100, "Hardened"));
            screwRepo.GetAll().Add(new Screw("Phillips Head", 20, 10.0, 50, "Greasy"));
            woodRepo.GetAll().Add(new Wood("Pine", "Board", 2.5, 5.0, 10.0, 20, "Finely treated"));

            var mss = new MaterialSearchService<IMaterial>(nailRepo, screwRepo, woodRepo);

            // Act
            var results = mss.SearchMaterials(searchTerm).Select(m => m.Name).ToList();

            // Build the expected results dynamically based on the search term
            var expectedResults = new List<string>
            {
            "Squared 5mm Hardened",
            "Phillips Head 10x0,5mm Greasy",
            "Pine Board 2.5x5.0x10.0 Treated"
            };

            // Assert
            Assert.AreEqual(expectedResults.Count, results.Count, "Number of results is not as expected.");

            // Verify each expected result is present in the actual results
            foreach (var expectedResult in expectedResults)
            {
                Assert.IsTrue(results.Contains(expectedResult), $"Expected result '{expectedResult}' not found in actual results.");
            }
        }

        private void ClearRepositories(NailRepository nailRepo, ScrewRepository screwRepo, WoodRepository woodRepo)
        {
            nailRepo.GetAll().Clear();
            screwRepo.GetAll().Clear();
            woodRepo.GetAll().Clear();
        }

        [TestMethod]
        public void ProjectCreateAndGet()
        {
            // Arrange
            ProjectRepository projectRepo = ProjectRepository.Instance;
            int initialCount = projectRepo.GetAll().Count;

            Project newProject = new Project("Title" + initialCount, "1.0", "Description" + initialCount, "Address" + initialCount);
            projectRepo.Add(newProject);

            // Act
            Project retrievedProject = projectRepo.GetAll().FirstOrDefault(p => p.Title == newProject.Title);

            // Assert
            Assert.IsNotNull(retrievedProject, "Project was not found in the repository.");
            Assert.AreEqual(newProject.Title, retrievedProject.Title);
            Assert.AreEqual(newProject.Offer, retrievedProject.Offer);
            Assert.AreEqual(newProject.Description, retrievedProject.Description);
            Assert.AreEqual(newProject.Address, retrievedProject.Address);
        }

        [TestMethod]
        public void AddProjectTest()
        {
            // Arrange
            ProjectRepository projectRepo = ProjectRepository.Instance;
            int initialCount = projectRepo.GetAll().Count;

            Project newProject = new Project("NewTitle", "1.0", "NewDescription", "NewAddress");

            // Act
            projectRepo.Add(newProject);
            int newCount = projectRepo.GetAll().Count;

            // Assert
            Assert.AreEqual(initialCount + 1, newCount, "The project count should increase by one after adding a new project.");
            Project addedProject = projectRepo.GetAll().FirstOrDefault(p => p.Title == "NewTitle");
            Assert.IsNotNull(addedProject, "The new project should be found in the repository.");
        }

        [TestMethod]
        public void GetAllProjectsTest()
        {
            // Arrange
            ProjectRepository projectRepo = ProjectRepository.Instance;

            // Act
            List<Project> projects = projectRepo.GetAll();

            // Assert
            Assert.IsNotNull(projects, "The list of projects should not be null.");
            Assert.IsInstanceOfType(projects, typeof(List<Project>), "The method should return a list of projects.");
        }

        [TestMethod]
        public void SingletonTest()
        {
            // Act
            ProjectRepository instance1 = ProjectRepository.Instance;
            ProjectRepository instance2 = ProjectRepository.Instance;

            // Assert
            Assert.AreSame(instance1, instance2, "Both instances should be the same, ensuring singleton pattern is correctly implemented.");
        }

        [TestMethod]
        public void ProjectEqualityTest()
        {
            // Arrange
            Project project1 = new Project("Title", "1.0", "Description", "Address");
            Project project2 = new Project("Title", "1.0", "Description", "Address");

            // Act & Assert
            Assert.AreEqual(project1.Title, project2.Title);
            Assert.AreEqual(project1.Offer, project2.Offer);
            Assert.AreEqual(project1.Description, project2.Description);
            Assert.AreEqual(project1.Address, project2.Address);
        }

        [TestMethod]
        public void AddNailTest()
        {
            // Arrange
            NailRepository nailRepo = NailRepository.Instance;
            int initialCount = nailRepo.GetAll().Count;

            Nail newNail = new Nail(-1.0, "TestForm", -1, "TestTreatment");

            // Act
            nailRepo.GetAll().Add(newNail);
            int newCount = nailRepo.GetAll().Count;

            // Assert
            Assert.AreEqual(initialCount + 1, newCount, "The nail count should increase by one after adding a new nail.");
            Nail addedNail = nailRepo.GetAll().FirstOrDefault(n => n.Length == -1.0 && n.Form == "TestForm" && n.Quantity == -1 && n.Treatment == "TestTreatment");
            Assert.IsNotNull(addedNail, "The new nail should be found in the repository.");
        }

        [TestMethod]
        public void AddWoodTest()
        {
            // Arrange
            WoodRepository woodRepo = WoodRepository.Instance;
            int initialCount = woodRepo.GetAll().Count;

            Wood newWood = new Wood("TestSort", "TestType", -1.0, -1.0, -1.0, -1, "TestTreatment");

            // Act
            woodRepo.GetAll().Add(newWood);
            int newCount = woodRepo.GetAll().Count;

            // Assert
            Assert.AreEqual(initialCount + 1, newCount, "The wood count should increase by one after adding a new wood.");
            Wood addedWood = woodRepo.GetAll().FirstOrDefault(w => w.Sort == "TestSort" && w.Type == "TestType" && w.Length == -1.0 && w.Width == -1.0 && w.Height == -1.0 && w.Quantity == -1 && w.Treatment == "TestTreatment");
            Assert.IsNotNull(addedWood, "The new wood should be found in the repository.");
        }

        [TestMethod]
        public void AddScrewTest()
        {
            // Arrange
            ScrewRepository screwRepo = ScrewRepository.Instance;
            int initialCount = screwRepo.GetAll().Count;

            Screw newScrew = new Screw("TestHead", -1, -1.0, -1, "TestTreatment");

            // Act
            screwRepo.GetAll().Add(newScrew);
            int newCount = screwRepo.GetAll().Count;

            // Assert
            Assert.AreEqual(initialCount + 1, newCount, "The screw count should increase by one after adding a new screw.");
            Screw addedScrew = screwRepo.GetAll().FirstOrDefault(s => s.ScrewHead == "TestHead" && s.Length == -1 && s.Diameter == -1.0 && s.Quantity == -1 && s.Treatment == "TestTreatment");
            Assert.IsNotNull(addedScrew, "The new screw should be found in the repository.");
        }

        [TestMethod]
        public void GetAllNailsTest()
        {
            // Arrange
            NailRepository nailRepo = NailRepository.Instance;

            // Act
            List<Nail> nails = nailRepo.GetAll();

            // Assert
            Assert.IsNotNull(nails, "The list of nails should not be null.");
            Assert.IsInstanceOfType(nails, typeof(List<Nail>), "The method should return a list of nails.");
        }

        [TestMethod]
        public void SingletonNailTest()
        {
            // Act
            NailRepository instance1 = NailRepository.Instance;
            NailRepository instance2 = NailRepository.Instance;

            // Assert
            Assert.AreSame(instance1, instance2, "Both instances should be the same, ensuring singleton pattern is correctly implemented.");
        }
    }
}
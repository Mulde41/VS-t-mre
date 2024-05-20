using System.Runtime.CompilerServices;
using Vs_Toemrer_Lagerstyringssystemsprojekt.Model;
using Vs_Toemrer_Lagerstyringssystemsprojekt.Persistence;
using Vs_Toemrer_Lagerstyringssystemsprojekt.Viewmodel;
using Vs_Toemrer_Lagerstyringssystemsprojekt.Business_Infrastructure;

namespace LavNytProjekt_UnitTest
{
    [TestClass]
    public class UnitTest
    {
        ProjectRepository projectRepo;
        List<Project> testList;
        Project pro1, pro2, pro3;
        [TestInitialize]
        public void Initialize()
        {
            projectRepo = new ProjectRepository();
            testList = new List<Project>();
        }
        //[TestMethod]
        //public void AddToRepository()
        //{
        //    // Arrange
        //    //pro1 = new Project("Fix tag hos Føtex", 799.99, "FøtexVej, 5000 Odense C", "Taget er rådent og skal laves. Der skal bruges en del materialer.");
        //    //pro2 = new Project("Fix tag hos Fakta", 1099.99, "FaktaVej, 5000 Odense C", "Hele shoppen er rådden fordi Fakta ikke findes mere.");
        //    //pro3 = new Project("Fix tag hos Netto", 1199.99, "NettoVej, 5000 Odense C", "Taget er rådent og skal laves. Der skal bruges en smule materialer.");
        //    //projectRepo.Add(pro1);
        //    //projectRepo.Add(pro2);
        //    //projectRepo.Add(pro3);

        //    //List<Project> testList = new List<Project>();
        //    //testList.Add(pro1);
        //    //testList.Add(pro2);
        //    //testList.Add(pro3);

        //    // Act
        //    //List<Project> projectsInRepo = projectRepo.GetAll();
        //    //testList = projectRepo.GetAll();

        //    // Assert
        //    //Assert.AreEqual(testList.Count, projectsInRepo.Count);
        //    //CollectionAssert.AreEqual(testList, projectsInRepo);
        //}


        [TestMethod]
        public void GetFromRepository() // Tests whether the repo can collect a specific project based on the Get() method, which takes a string title as argument.
        {
            // Arrange

            // Act
            string expectedTitle = "Fix tag hos Netto";

            Project getProj1 = projectRepo.Get(expectedTitle);

            // Assert
            Assert.AreEqual(expectedTitle, getProj1.Title);
        }



    }
}